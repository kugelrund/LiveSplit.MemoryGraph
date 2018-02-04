namespace LiveSplit.MemoryGraph
{
    partial class TextStyleOverrideControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkOverrideFont = new System.Windows.Forms.CheckBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.chkOverrideColor = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkOverrideFont
            // 
            this.chkOverrideFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOverrideFont.AutoSize = true;
            this.chkOverrideFont.Location = new System.Drawing.Point(224, 8);
            this.chkOverrideFont.Margin = new System.Windows.Forms.Padding(40, 4, 0, 4);
            this.chkOverrideFont.Name = "chkOverrideFont";
            this.chkOverrideFont.Size = new System.Drawing.Size(121, 21);
            this.chkOverrideFont.TabIndex = 8;
            this.chkOverrideFont.Text = "Override Font:";
            this.chkOverrideFont.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFont.Location = new System.Drawing.Point(349, 4);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(231, 26);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "Choose...";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // chkOverrideColor
            // 
            this.chkOverrideColor.AutoSize = true;
            this.chkOverrideColor.Location = new System.Drawing.Point(0, 8);
            this.chkOverrideColor.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.chkOverrideColor.Name = "chkOverrideColor";
            this.chkOverrideColor.Size = new System.Drawing.Size(126, 21);
            this.chkOverrideColor.TabIndex = 6;
            this.chkOverrideColor.Text = "Override Color:";
            this.chkOverrideColor.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor.Location = new System.Drawing.Point(130, 5);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(24, 24);
            this.btnColor.TabIndex = 5;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // TextStyleOverrideControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkOverrideFont);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.chkOverrideColor);
            this.Controls.Add(this.btnColor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextStyleOverrideControl";
            this.Size = new System.Drawing.Size(580, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkOverrideFont;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.CheckBox chkOverrideColor;
        private System.Windows.Forms.Button btnColor;
    }
}
