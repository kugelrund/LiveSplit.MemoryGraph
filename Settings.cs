using LiveSplit.ComponentUtil;
using LiveSplit.UI;
using System;
using System.IO;
using System.Xml;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LiveSplit.MemoryGraph
{
    enum MemoryType
    {
        [Description("Float")]
        Float,
        [Description("Int")]
        Int,
        [Description("FloatVec2")]
        FloatVec2,
        [Description("IntVec2")]
        IntVec2,
        [Description("FloatVec3")]
        FloatVec3,
        [Description("IntVec3")]
        IntVec3,
        [Description("FloatVec2XZY")]
        FloatVec2XZY,
        [Description("IntVec2XZY")]
        IntVec2XZY
    }

    enum GraphStyle
    {
        [Description("Single Bar")]
        SingleBar,
        [Description("Filled Graph")]
        FilledGraph,
        [Description("Polygonal Graph")]
        Polygonal,
        [Description("Polygonal Overflowing Graph")]
        PolygonalOverflow,
        [Description("Sonic")]
        Sonic
    }

    enum GradientType
    {
        [Description("Plain")]
        Plain,
        [Description("Vertical")]
        Vertical,
        [Description("Horizontal")]
        Horizontal
    }

    enum GraphGradientType
    {
        [Description("Plain")]
        Plain,
        [Description("Vertical")]
        Vertical,
        [Description("Horizontal")]
        Horizontal,
        [Description("By Value")]
        ByValue
    }

    enum Position
    {
        [Description("None")]
        None,
        [Description("Left")]
        Left,
        [Description("Right")]
        Right,
        [Description("Center in Graph")]
        CenterInGraph,
        [Description("Left in Graph")]
        LeftInGraph,
        [Description("Right in Graph")]
        RightInGraph
    }

    enum Units
    {
        [Description("Game Units (u)")]
        None,
        [Description("Metres per second (m/s)")]
        MeterPerSecond,
        [Description("Kilometers per hour (km/h)")]
        KilometersPerHour,
        [Description("Miles per hour (mph)")]
        MilesPerHour,
        [Description("Feet per second (fps)")]
        FeetPerSecond,
    }

    partial class Settings : UserControl
    {
        CultureInfo ci = new CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
        List<string> gamesOnTheList = new List<string>();
        static string componentsFolder = "Components";
        static string listsFile = "LiveSplit.MemoryGraphList.xml";

        public Color BackgroundColor { get; set; }
        public Color BackgroundColor2 { get; set; }
        public List<Color> GraphColors { get; set; } = new List<Color>();
        /// <summary>
        /// Yields the GraphColors. If there are no GraphColors, yields Color.Red.
        /// </summary>
        public IEnumerable<Color> GraphColorsEnumeration => GraphColors.Any() ? GraphColors : new List<Color> { Color.Red };

        public float MinimumValue { get; set; }
        public float MaximumValue { get; set; }
        public int GraphWidth { get; set; }
        public int GraphHeight { get; set; }
        public int HorizontalMargins { get; set; }
        public int VerticalMargins { get; set; }

        public GraphStyle GraphStyle { get; set; }
        public GradientType BackgroundGradient { get; set; }
        public GraphGradientType GraphGradient { get; set; }
        public bool GraphSillyColors { get; set; }
        public Position ValueTextPosition { get; set; }
        public Position DescriptiveTextPosition { get; set; }
        public bool LocalMax { get; set; }
        public MemoryType ValueType { get; set; }
        public bool UnitsConversionEnabled { get; set; }
        public Units UnitsUsed { get; set; }
        public float MeterInGameUnits { get; set; }


        public Color DescriptiveTextColor { get; set; }
        public Font DescriptiveTextFont { get; set; }
        public bool DescriptiveTextOverrideColor { get; set; }
        public bool DescriptiveTextOverrideFont { get; set; }

        public Color ValueTextColor { get; set; }
        public Font ValueTextFont { get; set; }
        public bool ValueTextOverrideColor { get; set; }
        public bool ValueTextOverrideFont { get; set; }
        public int ValueTextDecimals { get; set; }

        public string ProcessName { get; set; }
        public string DescriptiveText { get; set; }

        public string AdditionalRequirement { get; set; }

        public DeepPointer Pointer { get; set; }

        public Settings()
        {
            InitializeComponent();

            if (File.Exists(Path.Combine(componentsFolder, listsFile)))
            {
                loadXML();
            }
            else
            {
                ComboBox_ListOfGames.Enabled = false;
            }


            HandleDestroyed += UpdatePointer;

            BackgroundColor = Color.Transparent;
            BackgroundColor2 = Color.Transparent;
            MinimumValue = 0;
            MaximumValue = 1000;
            GraphWidth = 200;
            GraphHeight = 30;
            HorizontalMargins = 0;
            VerticalMargins = 0;
            GraphStyle = GraphStyle.SingleBar;
            BackgroundGradient = GradientType.Plain;
            GraphGradient = GraphGradientType.Plain;
            GraphSillyColors = true;
            ValueTextPosition = Position.LeftInGraph;
            DescriptiveTextPosition = Position.Left;
            LocalMax = false;
            UnitsConversionEnabled = false;
            UnitsUsed = Units.None;
            MeterInGameUnits = 1.0f;
            ValueType = MemoryType.Float;
            ValueTextDecimals = 0;
            ProcessName = "";
            DescriptiveText = "";
            AdditionalRequirement = "";
            DescriptiveTextFont = overrideControlDescriptiveText.OverridingFont;
            ValueTextFont = overrideControlValueText.OverridingFont;

            btnBackgroundColor1.DataBindings.Add("BackColor", this, "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBackgroundColor2.DataBindings.Add("BackColor", this, "BackgroundColor2", false, DataSourceUpdateMode.OnPropertyChanged);

            txtMinimumValue.DataBindings.Add("Text", this, "MinimumValue", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMaximumValue.DataBindings.Add("Text", this, "MaximumValue", false, DataSourceUpdateMode.OnPropertyChanged);
            numWidth.DataBindings.Add("Value", this, "GraphWidth", false, DataSourceUpdateMode.OnPropertyChanged);
            numHeight.DataBindings.Add("Value", this, "GraphHeight", false, DataSourceUpdateMode.OnPropertyChanged);
            numHorizontalMargins.DataBindings.Add("Value", this, "HorizontalMargins", false, DataSourceUpdateMode.OnPropertyChanged);
            numVerticalMargins.DataBindings.Add("Value", this, "VerticalMargins", false, DataSourceUpdateMode.OnPropertyChanged);
            numValueTextDecimals.DataBindings.Add("Value", this, "ValueTextDecimals", false, DataSourceUpdateMode.OnPropertyChanged);

            cmbGraphStyle.DataBindings.Add("SelectedValue", this, "GraphStyle", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbBackgroundGradientType.DataBindings.Add("SelectedValue", this, "BackgroundGradient", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbGraphGradientType.DataBindings.Add("SelectedValue", this, "GraphGradient", false, DataSourceUpdateMode.OnPropertyChanged);
            colorsCBSillyColors.DataBindings.Add("Checked", this, "GraphSillyColors", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbValueTextPosition.DataBindings.Add("SelectedValue", this, "ValueTextPosition", false, DataSourceUpdateMode.OnPropertyChanged);

            unitConversionCB.DataBindings.Add("Checked", this, "UnitsConversionEnabled", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbUnitsUsed.DataBindings.Add("SelectedValue", this, "UnitsUsed", false, DataSourceUpdateMode.OnPropertyChanged);
            tbMeterToGameUnit.DataBindings.Add("Text", this, "MeterInGameUnits", true, DataSourceUpdateMode.OnPropertyChanged, null, "f");

            cmbDescriptiveTextPosition.DataBindings.Add("SelectedValue", this, "DescriptiveTextPosition", false, DataSourceUpdateMode.OnPropertyChanged);
            localMaxCB.DataBindings.Add("Checked", this, "LocalMax", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbType.DataBindings.Add("SelectedValue", this, "ValueType", false, DataSourceUpdateMode.OnPropertyChanged);

            txtProcessName.DataBindings.Add("Text", this, "ProcessName");
            txtDescriptiveText.DataBindings.Add("Text", this, "DescriptiveText");
            linkLabel_AdditionalFiles.DataBindings.Add("Text", this, "AdditionalRequirement");

            overrideControlDescriptiveText.DataBindings.Add("OverridingColor", this, "DescriptiveTextColor");
            overrideControlDescriptiveText.DataBindings.Add("OverridingFont", this, "DescriptiveTextFont");
            overrideControlDescriptiveText.DataBindings.Add("OverrideColor", this, "DescriptiveTextOverrideColor");
            overrideControlDescriptiveText.DataBindings.Add("OverrideFont", this, "DescriptiveTextOverrideFont");

            overrideControlValueText.DataBindings.Add("OverridingColor", this, "ValueTextColor");
            overrideControlValueText.DataBindings.Add("OverridingFont", this, "ValueTextFont");
            overrideControlValueText.DataBindings.Add("OverrideColor", this, "ValueTextOverrideColor");
            overrideControlValueText.DataBindings.Add("OverrideFont", this, "ValueTextOverrideFont");

            AddComboboxDataSources();
        }

        private void UpdatePointer(object sender, EventArgs e)
        {
            int baseAddress;
            int[] offsets;

            if (TryParseHex(txtBase.Text, out baseAddress))
            {
                if (!string.IsNullOrWhiteSpace(txtOffsets.Text))
                {
                    string[] offsetStrings = txtOffsets.Text.Split(',');
                    offsets = new int[offsetStrings.Length];
                    int j = 0;
                    foreach (string offset in offsetStrings)
                    {
                        TryParseHex(offset.Trim(), out offsets[j]);
                        j += 1;
                    }
                }
                else
                {
                    offsets = new int[0];
                }

                if (string.IsNullOrWhiteSpace(txtModule.Text))
                {
                    Pointer = new DeepPointer(baseAddress, offsets);
                }
                else
                {
                    Pointer = new DeepPointer(txtModule.Text, baseAddress, offsets);
                }
            }
            else
            {
                Pointer = null;
            }
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick((Button)sender, this);
        }

        private List<Button> GraphColorButtons = new List<Button>();

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick(AddColorButton(), this);
        }

        private Button AddColorButton()
        {
            var newButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Location = new Point(btnAddColor.Location.X, btnAddColor.Location.Y),
                Margin = btnAddColor.Margin,
                Size = btnAddColor.Size,
                BackColor = GraphColors.Skip(GraphColorButtons.Count).FirstOrDefault(),
                UseVisualStyleBackColor = false
            };
            newButton.Click += new EventHandler(ColorButtonClick);
            newButton.BackColorChanged += new EventHandler(BackColorChangedEvent);

            var delta = btnDeleteColor.Location.X - btnAddColor.Location.X;
            btnAddColor.Location = new Point(btnAddColor.Location.X + delta, btnAddColor.Location.Y);
            btnDeleteColor.Location = new Point(btnDeleteColor.Location.X + delta, btnDeleteColor.Location.Y);

            grpGraph.Controls.Add(newButton);
            GraphColorButtons.Add(newButton);
            btnAddColor.Visible = !GraphColorButtons.Skip(12).Any();
            btnDeleteColor.Visible = GraphColorButtons.Skip(2).Any();

            return newButton;
        }

        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            DeleteColorButton(true);
        }

        private void DeleteColorButton(bool fromButton)
        {
            var delta = btnDeleteColor.Location.X - btnAddColor.Location.X;
            btnAddColor.Location = new Point(btnAddColor.Location.X - delta, btnAddColor.Location.Y);
            btnDeleteColor.Location = new Point(btnDeleteColor.Location.X - delta, btnDeleteColor.Location.Y);

            grpGraph.Controls.Remove(GraphColorButtons.Last());
            GraphColorButtons.RemoveAt(GraphColorButtons.Count - 1);
            if (fromButton)
            {
                GraphColors.RemoveAt(GraphColors.Count - 1);
            }
            btnAddColor.Visible = !GraphColorButtons.Skip(12).Any();
            btnDeleteColor.Visible = GraphColorButtons.Skip(2).Any();
        }

        private void BackColorChangedEvent(object sender, EventArgs e)
        {
            GraphColors.Clear();
            GraphColors.AddRange(GraphColorButtons.Select(b => b.BackColor));
        }

        public void SetSettings(System.Xml.XmlNode node)
        {
            System.Xml.XmlElement element = (System.Xml.XmlElement)node;

            BackgroundColor = SettingsHelper.ParseColor(element["BackgroundColor"]);
            BackgroundColor2 = SettingsHelper.ParseColor(element["BackgroundColor2"]);
            GraphColors.Clear();
            // GraphColor and GraphColor2 were the old values used to store the GraphColors. If they exist, add their values to our new list of colors.
            var GraphColor = SettingsHelper.ParseColor(element["GraphColor"]);
            if (GraphColor != default(Color))
            {
                GraphColors.Add(GraphColor);
            }
            var GraphColor2 = SettingsHelper.ParseColor(element["GraphColor2"]);
            if (GraphColor2 != default(Color))
            {
                GraphColors.Add(GraphColor2);
            }
            // Regular parsing of GraphColors. We can't use a default Parser since it's a list and needs to be comma seperated.
            if (element[nameof(GraphColors)] != null)
            {
                GraphColors.AddRange(element[nameof(GraphColors)].InnerText.Split(',').Select(x => Color.FromArgb(int.Parse(x, NumberStyles.HexNumber))));
            }
            // The trigger that occurs when GraphGradientType is Plain fires too early. Redo it!
            cmbGraphGradientType_SelectedValueChanged(null, null);
            MinimumValue = SettingsHelper.ParseFloat(element["MinimumValue"]);
            MaximumValue = SettingsHelper.ParseFloat(element["MaximumValue"]);
            GraphWidth = SettingsHelper.ParseInt(element["GraphWidth"]);
            GraphHeight = SettingsHelper.ParseInt(element["GraphHeight"]); ;
            HorizontalMargins = SettingsHelper.ParseInt(element["HorizontalMargins"]); ;
            VerticalMargins = SettingsHelper.ParseInt(element["VerticalMargins"]); ;
            GraphStyle = SettingsHelper.ParseEnum<GraphStyle>(element["GraphStyle"]);
            BackgroundGradient = SettingsHelper.ParseEnum<GradientType>(element["BackgroundGradient"]);
            GraphGradient = SettingsHelper.ParseEnum<GraphGradientType>(element["GraphGradient"]);
            GraphSillyColors = SettingsHelper.ParseBool(element["GraphSillyColors"]);
            ValueTextPosition = SettingsHelper.ParseEnum<Position>(element["ValueTextPosition"]);
            DescriptiveTextPosition = SettingsHelper.ParseEnum<Position>(element["DescriptiveTextPosition"]);
            LocalMax = SettingsHelper.ParseBool(element["LocalMax"]);
            ProcessName = SettingsHelper.ParseString(element["ProcessName"]);
            DescriptiveText = SettingsHelper.ParseString(element["DescriptiveText"]);

            txtModule.Text = SettingsHelper.ParseString(element["Module"]);
            txtBase.Text = SettingsHelper.ParseString(element["Base"]);
            txtOffsets.Text = SettingsHelper.ParseString(element["Offsets"]);
            ValueType = SettingsHelper.ParseEnum<MemoryType>(element["ValueType"]);

            DescriptiveTextColor = SettingsHelper.ParseColor(element["DescriptiveTextColor"]);
            DescriptiveTextFont = SettingsHelper.GetFontFromElement(element["DescriptiveTextFont"]);
            DescriptiveTextOverrideColor = SettingsHelper.ParseBool(element["DescriptiveTextOverrideColor"]);
            DescriptiveTextOverrideFont = SettingsHelper.ParseBool(element["DescriptiveTextOverrideFont"]);

            ValueTextColor = SettingsHelper.ParseColor(element["ValueTextColor"]);
            ValueTextFont = SettingsHelper.GetFontFromElement(element["ValueTextFont"]);
            ValueTextOverrideColor = SettingsHelper.ParseBool(element["ValueTextOverrideColor"]);
            ValueTextOverrideFont = SettingsHelper.ParseBool(element["ValueTextOverrideFont"]);
            ValueTextDecimals = SettingsHelper.ParseInt(element["ValueTextDecimals"]);
            UnitsConversionEnabled = SettingsHelper.ParseBool(element["UnitConversionEnabled"]);
            UnitsUsed = SettingsHelper.ParseEnum<Units>(element["UnitsUsed"]);
            MeterInGameUnits = CultureSafeFloatParse(SettingsHelper.ParseString(element["MeterInGameUnits"]));

            UpdatePointer(null, null);
        }

        private float CultureSafeFloatParse(string vstr, float def = 1)
        {
            //This is due to Floats being really crappy in XMLs. What I mean is they can be stored as:
            //#1 - 0.5
            //#2 - 0,5
            //So this function use it to parse it properly no matter what culture they were stored in.
            if (vstr != null)
            {
                float value = 0;
                if (!float.TryParse(vstr, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out value) &&
                    //Then try in US english
                    !float.TryParse(vstr, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out value) &&
                    //Then in neutral language
                    !float.TryParse(vstr, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out value))
                {
                    return def;
                }

                return value;
            }
            else
                return def;
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            System.Xml.XmlElement parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public static int CreateSetting(XmlDocument document, XmlElement parent, string name, IEnumerable<Color> colors)
        {
            if (document != null)
            {
                var element = document.CreateElement(name);
                element.InnerText = String.Join(",", colors.Select(c => c.ToArgb().ToString("X8")));
                parent.AppendChild(element);
            }
            return colors.GetHashCode();
        }

        private int CreateSettingsNode(System.Xml.XmlDocument document, System.Xml.XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor", BackgroundColor) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor2", BackgroundColor2) ^
            CreateSetting(document, parent, nameof(GraphColors), GraphColors) ^
            SettingsHelper.CreateSetting(document, parent, "MinimumValue", MinimumValue) ^
            SettingsHelper.CreateSetting(document, parent, "MaximumValue", MaximumValue) ^
            SettingsHelper.CreateSetting(document, parent, "GraphWidth", GraphWidth) ^
            SettingsHelper.CreateSetting(document, parent, "GraphHeight", GraphHeight) ^
            SettingsHelper.CreateSetting(document, parent, "HorizontalMargins", HorizontalMargins) ^
            SettingsHelper.CreateSetting(document, parent, "VerticalMargins", VerticalMargins) ^
            SettingsHelper.CreateSetting(document, parent, "GraphStyle", GraphStyle) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundGradient", BackgroundGradient) ^
            SettingsHelper.CreateSetting(document, parent, "GraphGradient", GraphGradient) ^
            SettingsHelper.CreateSetting(document, parent, "GraphSillyColors", GraphSillyColors) ^
            SettingsHelper.CreateSetting(document, parent, "ValueTextPosition", ValueTextPosition) ^
            SettingsHelper.CreateSetting(document, parent, "DescriptiveTextPosition", DescriptiveTextPosition) ^
            SettingsHelper.CreateSetting(document, parent, "LocalMax", LocalMax) ^
            SettingsHelper.CreateSetting(document, parent, "ProcessName", ProcessName) ^
            SettingsHelper.CreateSetting(document, parent, "DescriptiveText", DescriptiveText) ^

            SettingsHelper.CreateSetting(document, parent, "Module", txtModule.Text) ^
            SettingsHelper.CreateSetting(document, parent, "Base", txtBase.Text) ^
            SettingsHelper.CreateSetting(document, parent, "Offsets", txtOffsets.Text) ^
            SettingsHelper.CreateSetting(document, parent, "ValueType", ValueType) ^

            SettingsHelper.CreateSetting(document, parent, "DescriptiveTextColor", DescriptiveTextColor) ^
            SettingsHelper.CreateSetting(document, parent, "DescriptiveTextFont", DescriptiveTextFont) ^
            SettingsHelper.CreateSetting(document, parent, "DescriptiveTextOverrideColor", DescriptiveTextOverrideColor) ^
            SettingsHelper.CreateSetting(document, parent, "DescriptiveTextOverrideFont", DescriptiveTextOverrideFont) ^

            SettingsHelper.CreateSetting(document, parent, "ValueTextColor", ValueTextColor) ^
            SettingsHelper.CreateSetting(document, parent, "ValueTextFont", ValueTextFont) ^
            SettingsHelper.CreateSetting(document, parent, "ValueTextOverrideColor", ValueTextOverrideColor) ^
            SettingsHelper.CreateSetting(document, parent, "ValueTextOverrideFont", ValueTextOverrideFont) ^
            SettingsHelper.CreateSetting(document, parent, "ValueTextDecimals", ValueTextDecimals) ^
            SettingsHelper.CreateSetting(document, parent, "UnitConversionEnabled", UnitsConversionEnabled) ^
            SettingsHelper.CreateSetting(document, parent, "UnitsUsed", UnitsUsed) ^
            SettingsHelper.CreateSetting(document, parent, "MeterInGameUnits", MeterInGameUnits);
        }

        private void cmbBackgroundGradientType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBackgroundGradientType.SelectedValue == null)
            {
                return;
            }

            btnBackgroundColor1.Visible = ((GradientType)cmbBackgroundGradientType.SelectedValue != GradientType.Plain);
            btnBackgroundColor2.DataBindings.Clear();
            btnBackgroundColor2.DataBindings.Add("BackColor", this, btnBackgroundColor1.Visible ? "BackgroundColor2" : "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void cmbGraphGradientType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbGraphGradientType.SelectedValue == null)
            {
                return;
            }
            else if ((GraphGradientType)cmbGraphGradientType.SelectedValue == GraphGradientType.Horizontal &&
                     GraphStyle == GraphStyle.FilledGraph)
            {
                MessageBox.Show("Horizontal Gradient for Filled Graph is not supported", "Invalid value!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGraphGradientType.SelectedValue = GraphGradientType.Plain;
                return;
            }

            while (GraphColorButtons.Any())
            {
                DeleteColorButton(false);
            }
            var ggt = (GraphGradientType)cmbGraphGradientType.SelectedValue;
            switch (ggt)
            {
                default:
                case GraphGradientType.Plain:
                    AddColorButton();

                    btnAddColor.Visible = false;
                    btnDeleteColor.Visible = false;
                    break;

                case GraphGradientType.Vertical:
                case GraphGradientType.Horizontal:
                case GraphGradientType.ByValue:
                    foreach (var color in GraphColors)
                    {
                        AddColorButton();
                    }

                    btnAddColor.Visible = !GraphColorButtons.Skip(12).Any();
                    btnDeleteColor.Visible = GraphColorButtons.Skip(2).Any();
                    break;
            }
        }

        private void txtBase_Validating(object sender, CancelEventArgs e)
        {
            int parsed;
            if (!TryParseHex(txtBase.Text, out parsed))
            {
                MessageBox.Show("'Base' has to be a hexadecimal number!", "Invalid value!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
        }

        private void txtOffsets_Validating(object sender, CancelEventArgs e)
        {
            int parsed;
            string[] offsets = txtOffsets.Text.Split(',');
            if (offsets.Length == 1 && string.IsNullOrEmpty(offsets[0]))
            {
                return;
            }

            foreach (string offset in offsets)
            {
                if (!TryParseHex(offset, out parsed))
                {
                    MessageBox.Show("All offsets have to be hexadecimal numbers!", "Invalid value!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void txtMinimumValue_Validating(object sender, CancelEventArgs e)
        {
            float parsed;
            if (!float.TryParse(txtMinimumValue.Text, out parsed))
            {
                MessageBox.Show("Minimum Value has to be a number!", "Invalid value!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
        }

        private void txtMaximumValue_Validating(object sender, CancelEventArgs e)
        {
            float parsed;
            if (!float.TryParse(txtMaximumValue.Text, out parsed))
            {
                MessageBox.Show("Maximum Value has to be a number!", "Invalid value!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
        }

        public static bool TryParseHex(string str, out int integer)
        {
            integer = 0;
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            else
            {
                if (str.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase))
                {
                    str = str.Substring(2);
                }

                return int.TryParse(str, NumberStyles.HexNumber, null, out integer);
            }
        }

        #region XML database functions
        //////////////////////////////////////////
        /////Related to loading XML, list etc.////
        //////////////////////////////////////////

        private void loadXML()
        {
            ComboBox_ListOfGames.DataSource = null;
            gamesOnTheList.Clear();
            XmlDocument XmlGames = new XmlDocument();
            XmlGames.Load(Path.Combine(componentsFolder, listsFile));
            gamesOnTheList.Add("-None-");
            foreach (XmlNode gameNode in XmlGames.DocumentElement)
            {
                string name = gameNode.Attributes[0].Value;
                gamesOnTheList.Add(name);
            }

            ComboBox_ListOfGames.DataSource = gamesOnTheList;
            ComboBox_ListOfGames.Enabled = true;
        }

        private void ComboBox_ListOfGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)ComboBox_ListOfGames.SelectedValue == "-None-")
            {
            }
            else
            {
                XmlDocument XmlGames = new XmlDocument();
                XmlGames.Load(Path.Combine(componentsFolder, listsFile));
                foreach (XmlNode gameNode in XmlGames.DocumentElement)
                {
                    string name = gameNode.Attributes[0].Value;
                    if (name == (string)ComboBox_ListOfGames.SelectedValue)
                    {
                        ProcessName = GetSafeStringValueFromXML(gameNode, "process");
                        txtProcessName.Text = ProcessName;
                        AdditionalRequirement = GetSafeStringValueFromXML(gameNode, "additional_requirement_url");

                        txtModule.Text = GetSafeStringValueFromXML(gameNode, "module");
                        txtBase.Text = GetSafeStringValueFromXML(gameNode, "base");
                        txtOffsets.Text = GetSafeStringValueFromXML(gameNode, "offsets");
                        cmbType.SelectedIndex = GetSafeTypeFromXML(gameNode, "type");
                        txtMaximumValue.Text = GetSafeStringValueFromXML(gameNode, "maximumValue");
                        numValueTextDecimals.Value = GetSafeUIntFromXML(gameNode, "decimals");
                        tbMeterToGameUnit.Text = GetSafeStringValueFromXML(gameNode, "unitConverter");

                        var versions = gameNode.SelectSingleNode("versions");
                        if (versions != null)
                        {
                            // Update the versions drop down to include the verisons.
                            var versionNames = new List<string>();
                            foreach (XmlNode versionNode in versions.ChildNodes)
                            {
                                versionNames.Add(versionNode.Attributes[0].Value);
                            }
                            var prevSource = ComboBox_GameVersion.DataSource as List<string>;
                            if (prevSource == null || !prevSource.SequenceEqual(versionNames))
                            {
                                ComboBox_GameVersion.DataSource = versionNames;
                            }
                            ComboBox_GameVersion.Enabled = versionNames.Any();

                            foreach (XmlNode versionNode in versions.ChildNodes)
                            {
                                var versionName = versionNode.Attributes[0].Value;
                                if (versionName == (string)ComboBox_GameVersion.SelectedValue)
                                {
                                    // TODO: Parse values, but only the valid ones.
                                }
                            }
                        }

                        break;
                    }
                }
            }
        }
        private void B_UpdateXML_Click(object sender, EventArgs e)
        {
            MonkeyDownloadingXML _downloader = new MonkeyDownloadingXML();
            bool result = _downloader.DownloadNew();
            if (result)
            {
                loadXML();
            }
        }

        #region GetSafeValuesFunctions
        private string GetSafeStringValueFromXML(XmlNode docNode, string nodeName)
        {
            if (docNode.SelectSingleNode(nodeName) != null)
            {
                return docNode.SelectSingleNode(nodeName).InnerText;
            }
            else
                return "";
        }

        private int GetSafeTypeFromXML(XmlNode docNode, string nodeName)
        {
            if (docNode.SelectSingleNode(nodeName) != null)
            {
                string typeTemp = docNode.SelectSingleNode(nodeName).InnerText.ToLower();
                if (typeTemp == "float")
                {
                    return (int)MemoryType.Float;
                }
                else if (typeTemp == "int")
                {
                    return (int)MemoryType.Int;
                }
                else if (typeTemp == "floatvec2")
                {
                    return (int)MemoryType.FloatVec2;
                }
                else if (typeTemp == "floatvec3")
                {
                    return (int)MemoryType.FloatVec3;
                }
                else if (typeTemp == "intvec2")
                {
                    return (int)MemoryType.IntVec2;
                }
                else if (typeTemp == "intvec3")
                {
                    return (int)MemoryType.IntVec3;
                }
                else if (typeTemp == "floatvec2xzy")
                {
                    return (int)MemoryType.FloatVec2XZY;
                }
                else if (typeTemp == "intvec2xzy")
                {
                    return (int)MemoryType.IntVec2XZY;
                }
                else
                    return (int)MemoryType.Float;
            }
            return (int)MemoryType.Float;
        }

        private uint GetSafeUIntFromXML(XmlNode docNode, string nodeName)
        {
            if (docNode.SelectSingleNode(nodeName) != null)
            {
                string text = docNode.SelectSingleNode(nodeName).InnerText;
                uint value;
                if (uint.TryParse(text, out value))
                {
                    return value;
                }
                else
                    return 0;
            }
            return 0;
        }
        #endregion

        private void linkLabel_AdditionalFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel_AdditionalFiles.Text.StartsWith("http"))
            {
                Process.Start(linkLabel_AdditionalFiles.Text);
            }
        }

        private void linkLabel_AdditionalFiles_TextChanged(object sender, EventArgs e)
        {
            if (!linkLabel_AdditionalFiles.Text.StartsWith("http"))
            {
                linkLabel_AdditionalFiles.Text = "";
                L_Requires.Visible = false;
            }
            else
            {
                L_Requires.Visible = true;
                linkLabel_AdditionalFiles.LinkArea = new LinkArea(0, linkLabel_AdditionalFiles.Text.Length);
            }
        }
        #endregion

        private void cmbUnitsUsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnitsUsed.SelectedValue == null)
            {
                return;
            }
        }

        private void colorsCBSillyColors_MouseHover(object sender, EventArgs e)
        {
            //Displays tooltip
            toolTip.Show("This options allows the multiplier to exceed '1.0', meaning that if using color grading, the maximum color can be brighter than specified.", colorsCBSillyColors);
        }

        private void localMaxCB_MouseHover(object sender, EventArgs e)
        {
            // Displays tooltip
            toolTip.Show("Shows the largest value which is visible on the graph.", localMaxCB);
        }
    }
}
