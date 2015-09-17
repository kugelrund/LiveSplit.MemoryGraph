using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace LiveSplit.MemoryGraph
{
    struct FloatVec2
    {
        float x;
        float y;

        public FloatVec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public double Norm => Math.Sqrt(x * x + y * y);
    }

    struct FloatVec3
    {
        float x;
        float y;
        float z;

        public FloatVec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Norm => Math.Sqrt(x * x + y * y + z * z);
    }

    struct IntVec2
    {
        int x;
        int y;

        public IntVec2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Norm => Math.Sqrt(x * x + y * y);
    }

    struct IntVec3
    {
        int x;
        int y;
        int z;

        public IntVec3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Norm => Math.Sqrt(x * x + y * y + z * z);
    }

    public class Component : IComponent
    {
        private Settings settings = new Settings();

        public string ComponentName => "MemoryGraph";

        public float PaddingTop => 0;
        public float PaddingLeft => 0;
        public float PaddingBottom => 0;
        public float PaddingRight => 0;

        public float VerticalHeight { get; private set; }         
        public float MinimumWidth { get; private set; }
        public float HorizontalWidth { get; private set; }
        public float MinimumHeight { get; private set; }

        public IDictionary<string, Action> ContextMenuControls => null;

        private int graphHeight;
        private int graphWidth;

        private float currentValue;
        private System.Diagnostics.Process process;

        private Bitmap bmpBuffer;
        private Graphics gBuffer;

        private Brush graphBrush;
        private StringFormat valueTextFormat;
        private StringFormat descriptiveTextFormat;

        public Component(LiveSplitState state)
        {
            valueTextFormat = new StringFormat(StringFormatFlags.NoWrap);
            valueTextFormat.LineAlignment = StringAlignment.Center;

            descriptiveTextFormat = new StringFormat(StringFormatFlags.NoWrap);
            descriptiveTextFormat.LineAlignment = StringAlignment.Center;

            graphBrush = Brushes.Transparent;

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

            VerticalHeight = graphHeight + 2 * settings.VerticalMargins;
            MinimumWidth = graphWidth + 2 * settings.HorizontalMargins;
            HorizontalWidth = graphWidth + 2 * settings.HorizontalMargins;
            MinimumHeight = graphHeight + 2 * settings.VerticalMargins;
        }

        private static Color Blend(Color backColor, Color color, double amount)
        {
            byte a = (byte)((color.A * amount) + backColor.A * (1 - amount));
            byte r = (byte)((color.R * amount) + backColor.R * (1 - amount));
            byte g = (byte)((color.G * amount) + backColor.G * (1 - amount));
            byte b = (byte)((color.B * amount) + backColor.B * (1 - amount));
            return Color.FromArgb(a, r, g, b);
        }

        public void DrawGraph(Graphics g, LiveSplitState state, float width, float height)
        {
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
            float relativeValue = (currentValue - settings.MinimumValue) / settings.MaximumValue;

            // create brush
            switch (settings.GraphGradient)
            {
                case GraphGradientType.Plain:
                    graphBrush = new SolidBrush(settings.GraphColor);
                    break;
                case GraphGradientType.Horizontal:
                    graphBrush = new LinearGradientBrush(graphRect,
                                                         settings.GraphColor,
                                                         settings.GraphColor2,
                                                         LinearGradientMode.Horizontal);
                    break;
                case GraphGradientType.Vertical:
                    graphBrush = new LinearGradientBrush(new Point(0, 0),
                                                         new Point(0, graphHeight),
                                                         settings.GraphColor2,
                                                         settings.GraphColor);
                    break;
                case GraphGradientType.ByValue:
                    graphBrush = new SolidBrush(Blend(settings.GraphColor, 
                                                      settings.GraphColor2,
                                                      relativeValue));
                    break;
            }

            // draw actual graph
            switch (settings.GraphStyle)
            {
                case GraphStyle.FilledGraph:
                    gBuffer.DrawImageUnscaled(bmpBuffer, -1, 0);
                    gBuffer.FillRectangle(Brushes.Transparent, graphWidth - 1, 0, 1, graphHeight);

                    if (currentValue > settings.MinimumValue)
                    {
                        gBuffer.FillRectangle(graphBrush, 
                                              graphWidth - 1, (1 - relativeValue) * graphHeight, 
                                              1, relativeValue * graphHeight);
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

                        barRect.Width *= relativeValue;
                        g.FillRectangle(graphBrush, barRect);
                    }
                    break;
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
                g.DrawString(currentValue.ToString("n" + settings.ValueTextDecimals),
                             font, brush, rect, valueTextFormat);
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
                process.ProcessName == settings.ProcessName)
            {
                switch (settings.ValueType)
                {
                    case MemoryType.Float:
                        currentValue = settings.Pointer.Deref<float>(process);
                        break;
                    case MemoryType.Int:
                        currentValue = settings.Pointer.Deref<int>(process);
                        break;
                    case MemoryType.FloatVec2:
                        currentValue = (float)settings.Pointer.Deref< FloatVec2>(process).Norm;
                        break;
                    case MemoryType.FloatVec3:
                        currentValue = (float)settings.Pointer.Deref<FloatVec3>(process).Norm;
                        break;
                    case MemoryType.IntVec2:
                        currentValue = (float)settings.Pointer.Deref<IntVec2>(process).Norm;
                        break;
                    case MemoryType.IntVec3:
                        currentValue = (float)settings.Pointer.Deref<IntVec3>(process).Norm;
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
