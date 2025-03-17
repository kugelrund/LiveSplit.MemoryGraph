﻿using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace LiveSplit.MemoryGraph
{
    public class Component : IComponent
    {
        private Settings settings;

        SonicHandling sonic;

        public string ComponentName => "MemoryGraph";

        public float PaddingTop => 0;
        public float PaddingLeft => 0;
        public float PaddingBottom => 0;
        public float PaddingRight => 0;

        public float VerticalHeight => settings.GraphHeight + 2 * settings.VerticalMargins;
        public float MinimumWidth => settings.GraphWidth + 2 * settings.HorizontalMargins;
        public float HorizontalWidth => settings.GraphWidth + 2 * settings.HorizontalMargins;
        public float MinimumHeight => settings.GraphHeight + 2 * settings.VerticalMargins;

        public IDictionary<string, Action> ContextMenuControls => null;
        bool firstLoad = true;

        private int graphHeight;
        private int graphWidth;
        private int drawCounter = 0;                                        //For smoothing out
        private float averagedValue;                                    //For smoothing out
        private float[] fake_particles;

        private Queue<float> pastValues { get; } = new Queue<float>();
        private float? _localMax = 0;
        private float LocalMax => _localMax ?? (_localMax = pastValues.Max()).Value;
        private float _currentValue;
        private float currentValue
        {
            get => _currentValue;
            set
            {
                if (settings.LocalMax)
                {
                    pastValues.Enqueue(value);

                    if (!_localMax.HasValue || value == _localMax)
                    {
                        while (pastValues.Count > graphWidth)
                        {
                            pastValues.Dequeue();
                        }
                    }
                    else if (value > _localMax)
                    {
                        _localMax = value;

                        while (pastValues.Count > graphWidth)
                        {
                            pastValues.Dequeue();
                        }
                    }
                    else
                    {
                        while (pastValues.Count > graphWidth)
                        {
                            // Don't bother recalculating the Max() until it looks like we've dequeued the Max value().
                            if (pastValues.Dequeue() == _localMax)
                            {
                                _localMax = null;
                            }
                        }
                    }
                }

                _currentValue = value;
            }
        }
        private System.Diagnostics.Process process;

        private Bitmap bmpBuffer;
        private Graphics gBuffer;

        private Brush graphBrush;
        private StringFormat valueTextFormat;
        private StringFormat descriptiveTextFormat;
        private PointF[] polygon_points;
        private Pen graphPen;



        public Component(LiveSplitState state)
        {
            valueTextFormat = new StringFormat(StringFormatFlags.NoWrap);
            valueTextFormat.LineAlignment = StringAlignment.Center;

            descriptiveTextFormat = new StringFormat(StringFormatFlags.NoWrap);
            descriptiveTextFormat.LineAlignment = StringAlignment.Center;

            graphBrush = Brushes.Transparent;
            polygon_points = new PointF[4] { new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0), };  //LB, LU, RU, RB
            fake_particles = new float[5] { 185, 143, 6, 168, 91 };
            graphPen = new Pen(graphBrush);
            sonic = new SonicHandling();

            settings = new Settings();
            settings.HandleDestroyed += SettingsUpdated;
            SettingsUpdated(null, null);
        }

        private void SettingsUpdated(object sender, EventArgs e)
        {
            if (graphHeight != settings.GraphHeight || graphWidth != settings.GraphWidth)
            {
                graphHeight = settings.GraphHeight;
                graphWidth = settings.GraphWidth;

                bmpBuffer = new Bitmap(graphWidth, graphHeight);
                gBuffer = Graphics.FromImage(bmpBuffer);

                gBuffer.Clear(Color.Transparent);
                gBuffer.CompositingMode = CompositingMode.SourceCopy;

            }
        }

        private static Color Blend(IEnumerable<Color> colors, float amount, bool sillyColors)
        {
            if (float.IsNaN(amount) || amount <= 0 || colors.Count() == 1)
            {
                // If the amount is in error, default to the first color.
                return colors.First();
            }

            if (amount >= 1)
            {
                if (!sillyColors)
                {
                    // No need to blend: we know the last color will provide 100% of the value.
                    return colors.Last();
                }
                else
                {
                    return BlendTwo(colors.Reverse().Skip(1).First(), colors.Last(), amount);
                }
            }

            // Stretch the amount to cover then range (0, colors.Count() - 1).
            var floatingIndex = amount * (colors.Count() - 1);

            // Pick the highest index as the above value rounded up: [1, colors.Count() - 1]
            var index = (int)Math.Ceiling(floatingIndex);

            var color1 = colors.Skip(index - 1).First();
            var color2 = colors.Skip(index).First();

            // Blend with the decimal part of the floatingIndex.
            return BlendTwo(color1, color2, floatingIndex - (index - 1));
        }

        private static Color BlendTwo(Color zeroColor, Color oneColor, double amount)
        {
            byte a = (byte)((oneColor.A * amount) + zeroColor.A * (1 - amount));
            byte r = (byte)((oneColor.R * amount) + zeroColor.R * (1 - amount));
            byte g = (byte)((oneColor.G * amount) + zeroColor.G * (1 - amount));
            byte b = (byte)((oneColor.B * amount) + zeroColor.B * (1 - amount));
            return Color.FromArgb(a, r, g, b);
        }

        public void DrawGraph(Graphics g, LiveSplitState state, float width, float height)
        {
            if(firstLoad)
            {
                SettingsUpdated(null, null);
                firstLoad = false;
            }
            // figure out where to draw the graph
            RectangleF graphRect = new RectangleF();
            graphRect.Y = (height - graphHeight) / 2;
            graphRect.Width = graphWidth;
            graphRect.Height = graphHeight;
            if ((settings.DescriptiveTextPosition == Position.Left && settings.ValueTextPosition == Position.Right) ||
                (settings.DescriptiveTextPosition == Position.Right && settings.ValueTextPosition == Position.Left))
            {
                graphRect.X = (width - graphWidth) / 2;
            }
            else if (settings.DescriptiveTextPosition == Position.Left ||
                     settings.ValueTextPosition == Position.Left)
            {
                graphRect.X = width - graphWidth - settings.HorizontalMargins;
            }
            else
            {
                graphRect.X = settings.HorizontalMargins;
            }

            // shall there be text left or right of the graph?
            bool descriptiveNextToGraph = (settings.DescriptiveTextPosition == Position.Left ||
                                           settings.DescriptiveTextPosition == Position.Right);
            bool valueNextToGraph = (settings.ValueTextPosition == Position.Left ||
                                     settings.ValueTextPosition == Position.Right);

            // calculate relative value between 0 and 1
            float relativeValue = (currentValue - settings.MinimumValue) / (settings.MaximumValue - settings.MinimumValue);
            float relativeValueClamped = Math.Min(1.0f, Math.Max(0.0f, relativeValue));

            // create brush
            switch (settings.GraphGradient)
            {
                case GraphGradientType.Plain:
                    graphBrush = new SolidBrush(settings.GraphColorsEnumeration.First());
                    graphPen.Brush = graphBrush;
                    break;
                case GraphGradientType.Horizontal:
                case GraphGradientType.Vertical:
                    if (settings.GraphColorsEnumeration.Count() <= 1)
                    {
                        graphBrush = new SolidBrush(settings.GraphColorsEnumeration.First());
                    }
                    else
                    {
                        var color_blend = new ColorBlend
                        {
                            Colors = settings.GraphColorsEnumeration.Reverse().ToArray()
                        };
                        int position = 0;
                        color_blend.Positions = color_blend.Colors.Select(
                            x => position++ / (color_blend.Colors.Length - 1f)).ToArray();

                        LinearGradientBrush gradient_graph_brush;
                        if (settings.GraphGradient == GraphGradientType.Horizontal)
                        {
                            gradient_graph_brush = new LinearGradientBrush(
                                graphRect, Color.Black, Color.Black, LinearGradientMode.Horizontal);
                        }
                        else
                        {
                            gradient_graph_brush = new LinearGradientBrush(
                                new Point(0, 0), new Point(0, graphHeight), Color.Black, Color.Black);
                        }
                        graphBrush = gradient_graph_brush;
                    }
                    graphPen.Brush = graphBrush;
                    break;
                case GraphGradientType.ByValue:
                    graphBrush = new SolidBrush(Blend(settings.GraphColorsEnumeration,
                                                relativeValue, settings.GraphSillyColors));
                    graphPen.Brush = graphBrush;
                    break;
            }

            // draw actual graph
            switch (settings.GraphStyle)
            {
                #region Filled_Graph
                case GraphStyle.FilledGraph:
                    gBuffer.DrawImageUnscaled(bmpBuffer, -1, 0);
                    gBuffer.FillRectangle(Brushes.Transparent, graphWidth - 1, 0, 1, graphHeight);

                    if (currentValue > settings.MinimumValue)
                    {
                        gBuffer.FillRectangle(graphBrush,
                                              graphWidth - 1, (1 - relativeValueClamped) * graphHeight,
                                              1, relativeValueClamped * graphHeight);
                    }

                    if (descriptiveNextToGraph || valueNextToGraph)
                    {
                        g.DrawImageUnscaled(bmpBuffer, (int)graphRect.X, (int)graphRect.Y);
                    }
                    else
                    {
                        g.DrawImage(bmpBuffer, settings.HorizontalMargins, settings.VerticalMargins,
                                    width - 2 * settings.HorizontalMargins, height - 2 * settings.VerticalMargins);
                    }
                    break;
                #endregion
                #region SingleBar
                case GraphStyle.SingleBar:
                    if (currentValue > settings.MinimumValue)
                    {
                        RectangleF barRect;
                        if (descriptiveNextToGraph || valueNextToGraph)
                        {
                            barRect = graphRect;
                        }
                        else
                        {
                            barRect = g.ClipBounds;
                            barRect.X += settings.HorizontalMargins;
                            barRect.Y += settings.VerticalMargins;
                            barRect.Width -= 2 * settings.HorizontalMargins;
                            barRect.Height -= 2 * settings.VerticalMargins;
                        }

                        barRect.Width *= relativeValueClamped;
                        g.FillRectangle(graphBrush, barRect);
                    }
                    break;
                    #endregion
                #region Polygonal
                case GraphStyle.Polygonal:
                    gBuffer.DrawImageUnscaled(bmpBuffer, -1, 0);
                    gBuffer.FillRectangle(Brushes.Transparent, graphWidth - 1, 0, 1, graphHeight);

                    averagedValue += relativeValueClamped;

                    if (drawCounter==10)
                    {
                        averagedValue = averagedValue / 10.0f;
                        //LU, LL, RB, RU
                        //X,Y, width, height
                        polygon_points[0].X = graphWidth - 11;
                        polygon_points[0].Y = polygon_points[3].Y;
                        polygon_points[1].X = graphWidth - 11;
                        polygon_points[1].Y = graphHeight;
                        polygon_points[2].X = graphWidth;
                        polygon_points[2].Y = graphHeight;
                        polygon_points[3].X = graphWidth;
                        if (currentValue > settings.MinimumValue)
                            polygon_points[3].Y = graphHeight - (averagedValue * graphHeight);
                        else
                            polygon_points[3].Y = graphHeight;
                        gBuffer.FillPolygon(graphBrush, polygon_points);
                        averagedValue = 0;
                        drawCounter = 0;
                    }
                    else
                        drawCounter++;




                    if (descriptiveNextToGraph || valueNextToGraph)
                    {
                        g.DrawImageUnscaled(bmpBuffer, (int)graphRect.X, (int)graphRect.Y);
                    }
                    else
                    {
                        g.DrawImage(bmpBuffer, settings.HorizontalMargins, settings.VerticalMargins,
                                    width - 2 * settings.HorizontalMargins, height - 2 * settings.VerticalMargins);
                    }
                    break;
                    #endregion
                #region PolygonalOverflow
                case GraphStyle.PolygonalOverflow:
                    gBuffer.DrawImageUnscaled(bmpBuffer, -1, 0);
                    gBuffer.FillRectangle(Brushes.Transparent, graphWidth - 1, 0, 1, graphHeight);


                    //LU, LL, RB, RU
                    //X,Y, width, height
                    polygon_points[0].X = graphWidth - 15;
                    polygon_points[0].Y = polygon_points[3].Y;
                    polygon_points[1].X = graphWidth - 15;
                    polygon_points[1].Y = graphHeight;
                    polygon_points[2].X = graphWidth;
                    polygon_points[2].Y = graphHeight;
                    polygon_points[3].X = graphWidth;
                    if (currentValue > settings.MinimumValue)
                        polygon_points[3].Y = graphHeight - (relativeValueClamped * graphHeight);
                    else
                        polygon_points[3].Y = graphHeight;
                    gBuffer.FillPolygon(graphBrush, polygon_points);

                    if (descriptiveNextToGraph || valueNextToGraph)
                    {
                        g.DrawImageUnscaled(bmpBuffer, (int)graphRect.X, (int)graphRect.Y);
                    }
                    else
                    {
                        g.DrawImage(bmpBuffer, settings.HorizontalMargins, settings.VerticalMargins,
                                    width - 2 * settings.HorizontalMargins, height - 2 * settings.VerticalMargins);
                    }
                    break;
                    #endregion
                #region Sonic_Graph
                case GraphStyle.Sonic:
                    averagedValue += relativeValue;

                    if (drawCounter==3)
                    {
                        averagedValue = averagedValue / 3;
                        gBuffer.Clear(Color.Transparent);

                        if(graphHeight>graphWidth)
                            gBuffer.DrawImage(sonic.getBitmap(relativeValue), 0, 0, graphWidth, graphWidth*1.27f);
                        else
                            gBuffer.DrawImage(sonic.getBitmap(relativeValue), 0, 0, graphHeight/1.27f, graphHeight);


                        gBuffer.DrawLine(graphPen, fake_particles[0] - 10 * averagedValue, graphHeight * 0.44f, fake_particles[0], graphHeight * 0.44f);
                        gBuffer.DrawLine(graphPen, fake_particles[1] - 10 * averagedValue, graphHeight * 0.76f, fake_particles[1], graphHeight * 0.76f);
                        gBuffer.DrawLine(graphPen, fake_particles[2] - 10 * averagedValue, graphHeight * 0.67f, fake_particles[2], graphHeight * 0.67f);
                        gBuffer.DrawLine(graphPen, fake_particles[3] - 10 * averagedValue, graphHeight * 0.14f, fake_particles[3], graphHeight * 0.14f);
                        gBuffer.DrawLine(graphPen, fake_particles[4] - 10 * averagedValue, graphHeight * 0.33f, fake_particles[4], graphHeight * 0.33f);

                        drawCounter = 0;

                        for (int i = 0; i < fake_particles.Length; i++)
                        {
                            fake_particles[i] = fake_particles[i] - 15 * averagedValue;
                            if (fake_particles[i] < 0)
                                fake_particles[i] += graphWidth + 5;
                        }
                    }
                    else
                    {
                        drawCounter++;
                    }

                    //LU, LL, RB, RU
                    //X,Y, width, height

                    if (descriptiveNextToGraph || valueNextToGraph)
                    {
                        g.DrawImageUnscaled(bmpBuffer, (int)graphRect.X, (int)graphRect.Y);
                    }
                    else
                    {
                        g.DrawImage(bmpBuffer, settings.HorizontalMargins, settings.VerticalMargins,
                                    width - 2 * settings.HorizontalMargins, height - 2 * settings.VerticalMargins);
                    }
                    break;
                #endregion
            }

            // draw descriptive text
            if (settings.DescriptiveTextPosition != Position.None)
            {
                switch (settings.DescriptiveTextPosition)
                {
                    case Position.Left:
                    case Position.LeftInGraph:
                        descriptiveTextFormat.Alignment = StringAlignment.Near;
                        break;
                    case Position.Right:
                    case Position.RightInGraph:
                        descriptiveTextFormat.Alignment = StringAlignment.Far;
                        break;
                    case Position.CenterInGraph:
                        descriptiveTextFormat.Alignment = StringAlignment.Center;
                        break;
                }

                Font font = (settings.DescriptiveTextOverrideFont ?
                             settings.DescriptiveTextFont :
                             state.LayoutSettings.TextFont);
                Brush brush = new SolidBrush(settings.DescriptiveTextOverrideColor ?
                                             settings.DescriptiveTextColor :
                                             state.LayoutSettings.TextColor);
                RectangleF rect = descriptiveNextToGraph ? g.ClipBounds : graphRect;
                rect.X += 5;
                rect.Width -= 10;
                g.DrawString(settings.DescriptiveText, font, brush, rect, descriptiveTextFormat);
            }

            // draw value text
            if (settings.ValueTextPosition != Position.None)
            {
                switch (settings.ValueTextPosition)
                {
                    case Position.Left:
                    case Position.LeftInGraph:
                        valueTextFormat.Alignment = StringAlignment.Near;
                        break;
                    case Position.Right:
                    case Position.RightInGraph:
                        valueTextFormat.Alignment = StringAlignment.Far;
                        break;
                    case Position.CenterInGraph:
                        valueTextFormat.Alignment = StringAlignment.Center;
                        break;
                }

                Font font = (settings.ValueTextOverrideFont ?
                             settings.ValueTextFont :
                             state.LayoutSettings.TextFont);
                Brush brush = new SolidBrush(settings.ValueTextOverrideColor ?
                                             settings.ValueTextColor :
                                             state.LayoutSettings.TextColor);
                RectangleF rect = valueNextToGraph ? g.ClipBounds : graphRect;
                rect.X += 5;
                rect.Width -= 10;
                string str;
                if (!settings.UnitsConversionEnabled)
                {
                    str = currentValue.ToString("n" + settings.ValueTextDecimals);
                    if (settings.LocalMax)
                    {
                        str += " (" + LocalMax.ToString("n" + settings.ValueTextDecimals) + ")";
                    }
                }
                else
                {
                    str = convertUnits(currentValue, settings.ValueTextDecimals);
                    if (settings.LocalMax)
                    {
                        str += " (" + convertUnits(LocalMax, settings.ValueTextDecimals) + ")";
                    }
                }
                g.DrawString(str, font, brush, rect, valueTextFormat);
            }
        }

        private string convertUnits(float currentValue, int valueTextDecimals)
        {
            float multiplier = settings.MeterInGameUnits;
            Units unitsSelected = settings.UnitsUsed;
            switch (unitsSelected)
            {
                case Units.None:
                    {
                        return currentValue.ToString("n" + valueTextDecimals) + " (u)";
                    }
                case Units.MeterPerSecond:
                    {
                        float returnValue = currentValue / multiplier;
                        return returnValue.ToString("n" + valueTextDecimals) + " (m/s)";
                    }
                case Units.KilometersPerHour:
                    {
                        float returnValue = (currentValue / multiplier)  * 3.6f;
                        return returnValue.ToString("n" + valueTextDecimals) + " (km/h)";
                    }
                case Units.MilesPerHour:
                    {
                        float returnValue = (currentValue / multiplier) * 2.23693629f;
                        return returnValue.ToString("n" + valueTextDecimals) + " (mph)";
                    }
                case Units.FeetPerSecond:
                    {
                        float returnValue = (currentValue / multiplier) * 3.2808399f;
                        return returnValue.ToString("n" + valueTextDecimals) + " (fps)";
                    }
                default:
                    return currentValue.ToString("n" + valueTextDecimals) + " (u)";
            }

        }

        private void DrawBackground(Graphics g, LiveSplitState state, float width, float height)
        {
            if ((settings.BackgroundColor.A == 0 || settings.BackgroundGradient != GradientType.Plain) &&
                settings.BackgroundColor2.A == 0)
            {
                bool horizontal = (settings.BackgroundGradient == GradientType.Horizontal);
                bool plain = (settings.BackgroundGradient == GradientType.Plain);
                LinearGradientBrush gradientBrush = new LinearGradientBrush(
                    new PointF(0, 0),
                    horizontal ? new PointF(width, 0) : new PointF(0, height),
                    settings.BackgroundColor,
                    plain ? settings.BackgroundColor : settings.BackgroundColor2);
                g.FillRectangle(gradientBrush, 0, 0, width, height);
            }
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            DrawBackground(g, state, width, VerticalHeight);
            DrawGraph(g, state, width, VerticalHeight);
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            DrawBackground(g, state, HorizontalWidth, height);
            DrawGraph(g, state, HorizontalWidth, height);
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (process != null && settings.Pointer != null && !process.HasExited &&
                string.Equals(process.ProcessName, settings.ProcessName, StringComparison.OrdinalIgnoreCase))
            {
                switch (settings.ValueType)
                {
                    case MemoryType.Float:
                        {
                            currentValue = settings.Pointer.Deref<float>(process);
                        }
                        break;
                    case MemoryType.Int:
                        {
                            currentValue = settings.Pointer.Deref<int>(process);
                        }
                        break;
                    case MemoryType.FloatVec2:
                        {
                            currentValue = (float)settings.Pointer.Deref<FloatVec2>(process).Norm;
                        }
                        break;
                    case MemoryType.FloatVec3:
                        {
                            currentValue = (float)settings.Pointer.Deref<FloatVec3>(process).Norm;
                        }
                        break;
                    case MemoryType.IntVec2:
                        {
                            currentValue = (float)settings.Pointer.Deref<IntVec2>(process).Norm;
                        }

                        break;
                    case MemoryType.IntVec3:
                        {
                            currentValue = (float)settings.Pointer.Deref<IntVec3>(process).Norm;
                        }

                        break;
                    case MemoryType.FloatVec2XZY:
                        {
                            currentValue = (float)settings.Pointer.Deref<FloatVec2XZY>(process).Norm;
                        }
                        break;
                    case MemoryType.IntVec2XZY:
                        {
                            currentValue = (float)settings.Pointer.Deref<IntVec2XZY>(process).Norm;
                        }
                        break;
                }

                if (invalidator != null)
                {
                    invalidator.Invalidate(0, 0, width, height);
                }
            }
            else
            {
                process = System.Diagnostics.Process.GetProcessesByName(settings.ProcessName).FirstOrDefault();
            }
        }

        public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode)
        {
            return settings;
        }

        public void SetSettings(System.Xml.XmlNode settings)
        {
            this.settings.SetSettings(settings);
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return settings.GetSettings(document);
        }

        public int GetSettingsHashCode()
        {
            return settings.GetSettingsHashCode();
        }

        protected virtual void Dispose(bool disposing)
        {
            bmpBuffer.Dispose();
            valueTextFormat.Dispose();
            descriptiveTextFormat.Dispose();
            graphBrush.Dispose();
            settings.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
