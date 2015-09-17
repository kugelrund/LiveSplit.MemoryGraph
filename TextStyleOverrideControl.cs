using System;
using System.Drawing;
using System.Windows.Forms;

namespace LiveSplit.MemoryGraph
{
    public partial class TextStyleOverrideControl : UserControl
    {
        public bool OverrideColor { get; set; }
        public bool OverrideFont { get; set; }

        public Color OverridingColor { get; set; }
        public Font OverridingFont { get; set; }
        private string OverridingFontString => string.Format("{0} {1}", OverridingFont.FontFamily.Name, OverridingFont.Style);
        
        public TextStyleOverrideControl()
        {
            InitializeComponent();

            OverridingColor = Color.White;
            OverrideColor = false;
            OverridingFont = new Font("Segoe UI", 13, FontStyle.Regular, GraphicsUnit.Pixel);
            OverrideFont = false;

            btnColor.DataBindings.Add("BackColor", this, "OverridingColor", false, DataSourceUpdateMode.OnPropertyChanged);
            chkOverrideColor.DataBindings.Add("Checked", this, "OverrideColor", false, DataSourceUpdateMode.OnPropertyChanged);
            chkOverrideFont.DataBindings.Add("Checked", this, "OverrideFont", false, DataSourceUpdateMode.OnPropertyChanged);
            chkOverrideColor_CheckedChanged(null, null);
            chkOverrideFont_CheckedChanged(null, null);
        }

        private void chkOverrideColor_CheckedChanged(object sender, EventArgs e)
        {
            btnColor.Enabled = chkOverrideColor.Checked;
        }

        private void chkOverrideFont_CheckedChanged(object sender, EventArgs e)
        {
            btnFont.Enabled = chkOverrideFont.Checked;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            UI.SettingsHelper.ColorButtonClick((Button)sender, this);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            CustomFontDialog.FontDialog dialog = UI.SettingsHelper.GetFontDialog(OverridingFont, 7, 20);
            dialog.FontChanged += (s, ev) => OverridingFont = ((CustomFontDialog.FontChangedEventArgs) ev).NewFont;
            dialog.ShowDialog(this);
            btnFont.Text = OverridingFontString;
        }
    }
}
