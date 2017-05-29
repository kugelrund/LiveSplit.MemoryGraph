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

    partial class Settings : UserControl
    {
        List<string> gamesOnTheList = new List<string>();
        static string componentsFolder = "Components";
        static string listsFile = "LiveSplit.MemoryGraphList.xml";

        public Color BackgroundColor { get; set; }
        public Color BackgroundColor2 { get; set; }
        public Color GraphColor { get; set; }
        public Color GraphColor2 { get; set; }

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
        public MemoryType ValueType { get; set; }

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
            GraphColor = Color.Red;
            GraphColor2 = Color.Red;
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
            ValueType = MemoryType.Float;
            ValueTextDecimals = 0;
            ProcessName = "";
            DescriptiveText = "";
            AdditionalRequirement = "";
            DescriptiveTextFont = overrideControlDescriptiveText.OverridingFont;
            ValueTextFont = overrideControlValueText.OverridingFont;

            btnBackgroundColor1.DataBindings.Add("BackColor", this, "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBackgroundColor2.DataBindings.Add("BackColor", this, "BackgroundColor2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnGraphColor1.DataBindings.Add("BackColor", this, "GraphColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnGraphColor2.DataBindings.Add("BackColor", this, "GraphColor2", false, DataSourceUpdateMode.OnPropertyChanged);

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
            cmbDescriptiveTextPosition.DataBindings.Add("SelectedValue", this, "DescriptiveTextPosition", false, DataSourceUpdateMode.OnPropertyChanged);
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

        public void SetSettings(System.Xml.XmlNode node)
        {
            System.Xml.XmlElement element = (System.Xml.XmlElement) node;

            BackgroundColor = SettingsHelper.ParseColor(element["BackgroundColor"]);
            BackgroundColor2 = SettingsHelper.ParseColor(element["BackgroundColor2"]);
            GraphColor = SettingsHelper.ParseColor(element["GraphColor"]);
            GraphColor2 = SettingsHelper.ParseColor(element["GraphColor2"]);
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


            UpdatePointer(null, null);
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

        private int CreateSettingsNode(System.Xml.XmlDocument document, System.Xml.XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor", BackgroundColor) ^
            SettingsHelper.CreateSetting(document, parent, "BackgroundColor2", BackgroundColor2) ^
            SettingsHelper.CreateSetting(document, parent, "GraphColor", GraphColor) ^
            SettingsHelper.CreateSetting(document, parent, "GraphColor2", GraphColor2) ^
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
            SettingsHelper.CreateSetting(document, parent, "ValueTextDecimals", ValueTextDecimals);
        }

        private void cmbBackgroundGradientType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBackgroundGradientType.SelectedValue == null)
            {
                return;
            }

            btnBackgroundColor1.Visible = ((GradientType) cmbBackgroundGradientType.SelectedValue != GradientType.Plain);
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

            btnGraphColor1.Visible = ((GraphGradientType) cmbGraphGradientType.SelectedValue != GraphGradientType.Plain);
            btnGraphColor2.DataBindings.Clear();
            btnGraphColor2.DataBindings.Add("BackColor", this, btnGraphColor1.Visible ? "GraphColor2" : "GraphColor", false, DataSourceUpdateMode.OnPropertyChanged);
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
                        txtProcessName.Text = GetSafeStringValueFromXML(gameNode, "process");
                        ProcessName = GetSafeStringValueFromXML(gameNode, "process");
                        AdditionalRequirement = GetSafeStringValueFromXML(gameNode, "additional_requirement_url");

                        txtModule.Text = GetSafeStringValueFromXML(gameNode, "module");
                        txtBase.Text = GetSafeStringValueFromXML(gameNode, "base");
                        txtOffsets.Text = GetSafeStringValueFromXML(gameNode, "offsets");
                        cmbType.SelectedIndex = GetSafeTypeFromXML(gameNode, "type");
                        txtMaximumValue.Text = GetSafeStringValueFromXML(gameNode, "maximumValue");
                        numValueTextDecimals.Value = GetSafeUIntFromXML(gameNode, "decimals");                     

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

        private void colorsCBSillyColors_MouseHover(object sender, EventArgs e)
        {
            //Displays tooltip
            toolTip.Show("This options allows the multiplier to exceed '1.0', meaning that if using color grading, the maximum color can be brighter than specified.", colorsCBSillyColors);
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
            if(docNode.SelectSingleNode(nodeName) != null)
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
                else if (typeTemp == "floatvec2XZY")
                {
                    return (int)MemoryType.FloatVec2XZY;
                }
                else if (typeTemp == "intvec2XZY")
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
    }
}
