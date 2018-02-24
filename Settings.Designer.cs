using LiveSplit.UI;
using System;
using System.ComponentModel;
using System.Linq;

namespace LiveSplit.MemoryGraph
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.grpDescriptiveText = new System.Windows.Forms.GroupBox();
            this.overrideControlDescriptiveText = new LiveSplit.MemoryGraph.TextStyleOverrideControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescriptiveText = new System.Windows.Forms.TextBox();
            this.lblDescriptiveTextPosition = new System.Windows.Forms.Label();
            this.cmbDescriptiveTextPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMeterToGameUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUnitsUsed = new System.Windows.Forms.ComboBox();
            this.unitConversionCB = new System.Windows.Forms.CheckBox();
            this.grpPointerPath = new System.Windows.Forms.GroupBox();
            this.ComboBox_GameOption = new System.Windows.Forms.ComboBox();
            this.L_Requires = new System.Windows.Forms.Label();
            this.linkLabel_AdditionalFiles = new System.Windows.Forms.LinkLabel();
            this.ComboBox_ListOfGames = new System.Windows.Forms.ComboBox();
            this.B_UpdateXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblModule = new System.Windows.Forms.Label();
            this.txtOffsets = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblOffsets = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.grpGraph = new System.Windows.Forms.GroupBox();
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.colorsCBSillyColors = new System.Windows.Forms.CheckBox();
            this.cmbGraphGradientType = new System.Windows.Forms.ComboBox();
            this.lblGraphStyle = new System.Windows.Forms.Label();
            this.grpValueText = new System.Windows.Forms.GroupBox();
            this.localMaxCB = new System.Windows.Forms.CheckBox();
            this.numValueTextDecimals = new System.Windows.Forms.NumericUpDown();
            this.lblDecimals = new System.Windows.Forms.Label();
            this.overrideControlValueText = new LiveSplit.MemoryGraph.TextStyleOverrideControl();
            this.cmbValueTextPosition = new System.Windows.Forms.ComboBox();
            this.lblValueTextPosition = new System.Windows.Forms.Label();
            this.cmbGraphStyle = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaximumValue = new System.Windows.Forms.Label();
            this.txtMaximumValue = new System.Windows.Forms.TextBox();
            this.lblMinimumValue = new System.Windows.Forms.Label();
            this.lblHorizontalMargins = new System.Windows.Forms.Label();
            this.txtMinimumValue = new System.Windows.Forms.TextBox();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblVerticalMargins = new System.Windows.Forms.Label();
            this.numVerticalMargins = new System.Windows.Forms.NumericUpDown();
            this.numHorizontalMargins = new System.Windows.Forms.NumericUpDown();
            this.lblGraphColor = new System.Windows.Forms.Label();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.btnBackgroundColor1 = new System.Windows.Forms.Button();
            this.btnBackgroundColor2 = new System.Windows.Forms.Button();
            this.cmbBackgroundGradientType = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpDescriptiveText.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpPointerPath.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpGraph.SuspendLayout();
            this.grpValueText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValueTextDecimals)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerticalMargins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontalMargins)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDescriptiveText
            // 
            this.grpDescriptiveText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDescriptiveText.Controls.Add(this.overrideControlDescriptiveText);
            this.grpDescriptiveText.Controls.Add(this.tableLayoutPanel4);
            this.grpDescriptiveText.Location = new System.Drawing.Point(15, 574);
            this.grpDescriptiveText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDescriptiveText.Name = "grpDescriptiveText";
            this.grpDescriptiveText.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDescriptiveText.Size = new System.Drawing.Size(581, 94);
            this.grpDescriptiveText.TabIndex = 2;
            this.grpDescriptiveText.TabStop = false;
            this.grpDescriptiveText.Text = "Descriptive Text";
            // 
            // overrideControlDescriptiveText
            // 
            this.overrideControlDescriptiveText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overrideControlDescriptiveText.Location = new System.Drawing.Point(5, 54);
            this.overrideControlDescriptiveText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overrideControlDescriptiveText.Name = "overrideControlDescriptiveText";
            this.overrideControlDescriptiveText.OverrideColor = false;
            this.overrideControlDescriptiveText.OverrideFont = false;
            this.overrideControlDescriptiveText.OverridingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.overrideControlDescriptiveText.OverridingFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.overrideControlDescriptiveText.Size = new System.Drawing.Size(571, 36);
            this.overrideControlDescriptiveText.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.txtDescriptiveText, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDescriptiveTextPosition, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbDescriptiveTextPosition, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(571, 30);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txtDescriptiveText
            // 
            this.txtDescriptiveText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescriptiveText.Location = new System.Drawing.Point(3, 2);
            this.txtDescriptiveText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescriptiveText.Name = "txtDescriptiveText";
            this.txtDescriptiveText.Size = new System.Drawing.Size(280, 20);
            this.txtDescriptiveText.TabIndex = 2;
            // 
            // lblDescriptiveTextPosition
            // 
            this.lblDescriptiveTextPosition.AutoSize = true;
            this.lblDescriptiveTextPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescriptiveTextPosition.Location = new System.Drawing.Point(299, 0);
            this.lblDescriptiveTextPosition.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.lblDescriptiveTextPosition.Name = "lblDescriptiveTextPosition";
            this.lblDescriptiveTextPosition.Size = new System.Drawing.Size(77, 30);
            this.lblDescriptiveTextPosition.TabIndex = 0;
            this.lblDescriptiveTextPosition.Text = "Position:";
            this.lblDescriptiveTextPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDescriptiveTextPosition
            // 
            this.cmbDescriptiveTextPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDescriptiveTextPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescriptiveTextPosition.FormattingEnabled = true;
            this.cmbDescriptiveTextPosition.Location = new System.Drawing.Point(382, 2);
            this.cmbDescriptiveTextPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDescriptiveTextPosition.Name = "cmbDescriptiveTextPosition";
            this.cmbDescriptiveTextPosition.Size = new System.Drawing.Size(186, 21);
            this.cmbDescriptiveTextPosition.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "game units (u)";
            // 
            // tbMeterToGameUnit
            // 
            this.tbMeterToGameUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMeterToGameUnit.Location = new System.Drawing.Point(181, 126);
            this.tbMeterToGameUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMeterToGameUnit.Name = "tbMeterToGameUnit";
            this.tbMeterToGameUnit.Size = new System.Drawing.Size(277, 20);
            this.tbMeterToGameUnit.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Conversion:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "1 meter is";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Units:";
            // 
            // cmbUnitsUsed
            // 
            this.cmbUnitsUsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnitsUsed.FormattingEnabled = true;
            this.cmbUnitsUsed.Location = new System.Drawing.Point(267, 98);
            this.cmbUnitsUsed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnitsUsed.Name = "cmbUnitsUsed";
            this.cmbUnitsUsed.Size = new System.Drawing.Size(297, 21);
            this.cmbUnitsUsed.TabIndex = 1;
            this.cmbUnitsUsed.SelectedIndexChanged += new System.EventHandler(this.cmbUnitsUsed_SelectedIndexChanged);
            // 
            // unitConversionCB
            // 
            this.unitConversionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unitConversionCB.AutoSize = true;
            this.unitConversionCB.Location = new System.Drawing.Point(5, 104);
            this.unitConversionCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitConversionCB.Name = "unitConversionCB";
            this.unitConversionCB.Size = new System.Drawing.Size(137, 17);
            this.unitConversionCB.TabIndex = 0;
            this.unitConversionCB.Text = "Enable Unit Conversion";
            this.unitConversionCB.UseVisualStyleBackColor = true;
            // 
            // grpPointerPath
            // 
            this.grpPointerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPointerPath.Controls.Add(this.ComboBox_GameOption);
            this.grpPointerPath.Controls.Add(this.L_Requires);
            this.grpPointerPath.Controls.Add(this.linkLabel_AdditionalFiles);
            this.grpPointerPath.Controls.Add(this.ComboBox_ListOfGames);
            this.grpPointerPath.Controls.Add(this.B_UpdateXML);
            this.grpPointerPath.Controls.Add(this.label1);
            this.grpPointerPath.Controls.Add(this.txtProcessName);
            this.grpPointerPath.Controls.Add(this.lblProcessName);
            this.grpPointerPath.Controls.Add(this.tableLayoutPanel2);
            this.grpPointerPath.Location = new System.Drawing.Point(15, 14);
            this.grpPointerPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPointerPath.Name = "grpPointerPath";
            this.grpPointerPath.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPointerPath.Size = new System.Drawing.Size(581, 158);
            this.grpPointerPath.TabIndex = 0;
            this.grpPointerPath.TabStop = false;
            this.grpPointerPath.Text = "Pointer path";
            // 
            // ComboBox_GameOption
            // 
            this.ComboBox_GameOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_GameOption.FormattingEnabled = true;
            this.ComboBox_GameOption.Location = new System.Drawing.Point(330, 18);
            this.ComboBox_GameOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox_GameOption.Name = "ComboBox_GameOption";
            this.ComboBox_GameOption.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_GameOption.TabIndex = 12;
            this.ComboBox_GameOption.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ListOfGames_SelectedIndexChanged);
            // 
            // L_Requires
            // 
            this.L_Requires.AutoSize = true;
            this.L_Requires.Location = new System.Drawing.Point(5, 46);
            this.L_Requires.Name = "L_Requires";
            this.L_Requires.Size = new System.Drawing.Size(52, 13);
            this.L_Requires.TabIndex = 11;
            this.L_Requires.Text = "Requires:";
            // 
            // linkLabel_AdditionalFiles
            // 
            this.linkLabel_AdditionalFiles.AutoSize = true;
            this.linkLabel_AdditionalFiles.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel_AdditionalFiles.Location = new System.Drawing.Point(81, 46);
            this.linkLabel_AdditionalFiles.Name = "linkLabel_AdditionalFiles";
            this.linkLabel_AdditionalFiles.Size = new System.Drawing.Size(55, 13);
            this.linkLabel_AdditionalFiles.TabIndex = 10;
            this.linkLabel_AdditionalFiles.TabStop = true;
            this.linkLabel_AdditionalFiles.Text = "linkLabel1";
            this.linkLabel_AdditionalFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AdditionalFiles_LinkClicked);
            this.linkLabel_AdditionalFiles.TextChanged += new System.EventHandler(this.linkLabel_AdditionalFiles_TextChanged);
            // 
            // ComboBox_ListOfGames
            // 
            this.ComboBox_ListOfGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_ListOfGames.FormattingEnabled = true;
            this.ComboBox_ListOfGames.Location = new System.Drawing.Point(84, 18);
            this.ComboBox_ListOfGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox_ListOfGames.Name = "ComboBox_ListOfGames";
            this.ComboBox_ListOfGames.Size = new System.Drawing.Size(240, 21);
            this.ComboBox_ListOfGames.TabIndex = 9;
            this.ComboBox_ListOfGames.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ListOfGames_SelectedIndexChanged);
            // 
            // B_UpdateXML
            // 
            this.B_UpdateXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_UpdateXML.Location = new System.Drawing.Point(436, 17);
            this.B_UpdateXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_UpdateXML.Name = "B_UpdateXML";
            this.B_UpdateXML.Size = new System.Drawing.Size(140, 26);
            this.B_UpdateXML.TabIndex = 8;
            this.B_UpdateXML.Text = "Update XML file";
            this.B_UpdateXML.UseVisualStyleBackColor = true;
            this.B_UpdateXML.Click += new System.EventHandler(this.B_UpdateXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcessName.Location = new System.Drawing.Point(132, 128);
            this.txtProcessName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(444, 20);
            this.txtProcessName.TabIndex = 5;
            // 
            // lblProcessName
            // 
            this.lblProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(5, 130);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(91, 13);
            this.lblProcessName.TabIndex = 4;
            this.lblProcessName.Text = "Name of Process:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel2.Controls.Add(this.lblModule, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtOffsets, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBase, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtModule, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBase, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblOffsets, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblType, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbType, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 64);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(571, 60);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModule.Location = new System.Drawing.Point(3, 0);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(106, 24);
            this.lblModule.TabIndex = 0;
            this.lblModule.Text = "Module:";
            this.lblModule.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtOffsets
            // 
            this.txtOffsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOffsets.Location = new System.Drawing.Point(227, 26);
            this.txtOffsets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOffsets.Name = "txtOffsets";
            this.txtOffsets.Size = new System.Drawing.Size(218, 20);
            this.txtOffsets.TabIndex = 1;
            this.txtOffsets.Validating += new System.ComponentModel.CancelEventHandler(this.txtOffsets_Validating);
            // 
            // txtBase
            // 
            this.txtBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase.Location = new System.Drawing.Point(115, 26);
            this.txtBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(106, 20);
            this.txtBase.TabIndex = 1;
            this.txtBase.Validating += new System.ComponentModel.CancelEventHandler(this.txtBase_Validating);
            // 
            // txtModule
            // 
            this.txtModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModule.Location = new System.Drawing.Point(3, 26);
            this.txtModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(106, 20);
            this.txtModule.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBase.Location = new System.Drawing.Point(115, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(106, 24);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base:";
            this.lblBase.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblOffsets
            // 
            this.lblOffsets.AutoSize = true;
            this.lblOffsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOffsets.Location = new System.Drawing.Point(227, 0);
            this.lblOffsets.Name = "lblOffsets";
            this.lblOffsets.Size = new System.Drawing.Size(218, 24);
            this.lblOffsets.TabIndex = 2;
            this.lblOffsets.Text = "Offsets (comma seperated):";
            this.lblOffsets.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Location = new System.Drawing.Point(451, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(117, 24);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbType
            // 
            this.cmbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(451, 26);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(117, 21);
            this.cmbType.TabIndex = 4;
            // 
            // grpGraph
            // 
            this.grpGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGraph.Controls.Add(this.btnDeleteColor);
            this.grpGraph.Controls.Add(this.btnAddColor);
            this.grpGraph.Controls.Add(this.colorsCBSillyColors);
            this.grpGraph.Controls.Add(this.cmbGraphGradientType);
            this.grpGraph.Controls.Add(this.lblGraphStyle);
            this.grpGraph.Controls.Add(this.grpValueText);
            this.grpGraph.Controls.Add(this.cmbGraphStyle);
            this.grpGraph.Controls.Add(this.tableLayoutPanel5);
            this.grpGraph.Controls.Add(this.lblGraphColor);
            this.grpGraph.Controls.Add(this.lblBackgroundColor);
            this.grpGraph.Controls.Add(this.btnBackgroundColor1);
            this.grpGraph.Controls.Add(this.btnBackgroundColor2);
            this.grpGraph.Controls.Add(this.cmbBackgroundGradientType);
            this.grpGraph.Location = new System.Drawing.Point(15, 174);
            this.grpGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGraph.Size = new System.Drawing.Size(581, 395);
            this.grpGraph.TabIndex = 1;
            this.grpGraph.TabStop = false;
            this.grpGraph.Text = "Graph";
            // 
            // btnDeleteColor
            // 
            this.btnDeleteColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteColor.Location = new System.Drawing.Point(164, 204);
            this.btnDeleteColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Size = new System.Drawing.Size(24, 25);
            this.btnDeleteColor.TabIndex = 9;
            this.btnDeleteColor.Text = "-";
            this.btnDeleteColor.UseVisualStyleBackColor = false;
            this.btnDeleteColor.Click += new System.EventHandler(this.btnDeleteColor_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddColor.Location = new System.Drawing.Point(134, 204);
            this.btnAddColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(24, 25);
            this.btnAddColor.TabIndex = 8;
            this.btnAddColor.Text = "+";
            this.btnAddColor.UseVisualStyleBackColor = false;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // colorsCBSillyColors
            // 
            this.colorsCBSillyColors.AutoSize = true;
            this.colorsCBSillyColors.Location = new System.Drawing.Point(9, 204);
            this.colorsCBSillyColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorsCBSillyColors.Name = "colorsCBSillyColors";
            this.colorsCBSillyColors.Size = new System.Drawing.Size(76, 17);
            this.colorsCBSillyColors.TabIndex = 0;
            this.colorsCBSillyColors.Text = "Silly Colors";
            this.colorsCBSillyColors.UseVisualStyleBackColor = true;
            this.colorsCBSillyColors.MouseHover += new System.EventHandler(this.colorsCBSillyColors_MouseHover);
            // 
            // cmbGraphGradientType
            // 
            this.cmbGraphGradientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGraphGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphGradientType.FormattingEnabled = true;
            this.cmbGraphGradientType.Location = new System.Drawing.Point(133, 176);
            this.cmbGraphGradientType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGraphGradientType.Name = "cmbGraphGradientType";
            this.cmbGraphGradientType.Size = new System.Drawing.Size(443, 21);
            this.cmbGraphGradientType.TabIndex = 4;
            this.cmbGraphGradientType.SelectedValueChanged += new System.EventHandler(this.cmbGraphGradientType_SelectedValueChanged);
            // 
            // lblGraphStyle
            // 
            this.lblGraphStyle.AutoSize = true;
            this.lblGraphStyle.Location = new System.Drawing.Point(5, 23);
            this.lblGraphStyle.Name = "lblGraphStyle";
            this.lblGraphStyle.Size = new System.Drawing.Size(65, 13);
            this.lblGraphStyle.TabIndex = 5;
            this.lblGraphStyle.Text = "Graph Style:";
            this.lblGraphStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpValueText
            // 
            this.grpValueText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpValueText.Controls.Add(this.localMaxCB);
            this.grpValueText.Controls.Add(this.label5);
            this.grpValueText.Controls.Add(this.cmbUnitsUsed);
            this.grpValueText.Controls.Add(this.tbMeterToGameUnit);
            this.grpValueText.Controls.Add(this.label2);
            this.grpValueText.Controls.Add(this.label3);
            this.grpValueText.Controls.Add(this.label4);
            this.grpValueText.Controls.Add(this.numValueTextDecimals);
            this.grpValueText.Controls.Add(this.lblDecimals);
            this.grpValueText.Controls.Add(this.unitConversionCB);
            this.grpValueText.Controls.Add(this.overrideControlValueText);
            this.grpValueText.Controls.Add(this.cmbValueTextPosition);
            this.grpValueText.Controls.Add(this.lblValueTextPosition);
            this.grpValueText.Location = new System.Drawing.Point(5, 234);
            this.grpValueText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpValueText.Name = "grpValueText";
            this.grpValueText.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpValueText.Size = new System.Drawing.Size(571, 155);
            this.grpValueText.TabIndex = 5;
            this.grpValueText.TabStop = false;
            this.grpValueText.Text = "Value as Text";
            // 
            // localMaxCB
            // 
            this.localMaxCB.AutoSize = true;
            this.localMaxCB.Location = new System.Drawing.Point(325, 23);
            this.localMaxCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localMaxCB.Name = "localMaxCB";
            this.localMaxCB.Size = new System.Drawing.Size(75, 17);
            this.localMaxCB.TabIndex = 8;
            this.localMaxCB.Text = "Local Max";
            this.localMaxCB.UseVisualStyleBackColor = true;
            this.localMaxCB.MouseHover += new System.EventHandler(this.localMaxCB_MouseHover);
            // 
            // numValueTextDecimals
            // 
            this.numValueTextDecimals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numValueTextDecimals.Location = new System.Drawing.Point(509, 22);
            this.numValueTextDecimals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numValueTextDecimals.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numValueTextDecimals.Name = "numValueTextDecimals";
            this.numValueTextDecimals.Size = new System.Drawing.Size(53, 20);
            this.numValueTextDecimals.TabIndex = 3;
            // 
            // lblDecimals
            // 
            this.lblDecimals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDecimals.AutoSize = true;
            this.lblDecimals.Location = new System.Drawing.Point(435, 25);
            this.lblDecimals.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.lblDecimals.Name = "lblDecimals";
            this.lblDecimals.Size = new System.Drawing.Size(53, 13);
            this.lblDecimals.TabIndex = 2;
            this.lblDecimals.Text = "Decimals:";
            // 
            // overrideControlValueText
            // 
            this.overrideControlValueText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.overrideControlValueText.Location = new System.Drawing.Point(5, 55);
            this.overrideControlValueText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overrideControlValueText.Name = "overrideControlValueText";
            this.overrideControlValueText.OverrideColor = false;
            this.overrideControlValueText.OverrideFont = false;
            this.overrideControlValueText.OverridingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.overrideControlValueText.OverridingFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.overrideControlValueText.Size = new System.Drawing.Size(557, 33);
            this.overrideControlValueText.TabIndex = 2;
            // 
            // cmbValueTextPosition
            // 
            this.cmbValueTextPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbValueTextPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValueTextPosition.FormattingEnabled = true;
            this.cmbValueTextPosition.Location = new System.Drawing.Point(75, 21);
            this.cmbValueTextPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbValueTextPosition.Name = "cmbValueTextPosition";
            this.cmbValueTextPosition.Size = new System.Drawing.Size(244, 21);
            this.cmbValueTextPosition.TabIndex = 1;
            // 
            // lblValueTextPosition
            // 
            this.lblValueTextPosition.AutoSize = true;
            this.lblValueTextPosition.Location = new System.Drawing.Point(5, 25);
            this.lblValueTextPosition.Name = "lblValueTextPosition";
            this.lblValueTextPosition.Size = new System.Drawing.Size(47, 13);
            this.lblValueTextPosition.TabIndex = 0;
            this.lblValueTextPosition.Text = "Position:";
            // 
            // cmbGraphStyle
            // 
            this.cmbGraphStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGraphStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphStyle.FormattingEnabled = true;
            this.cmbGraphStyle.Location = new System.Drawing.Point(99, 20);
            this.cmbGraphStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGraphStyle.Name = "cmbGraphStyle";
            this.cmbGraphStyle.Size = new System.Drawing.Size(477, 21);
            this.cmbGraphStyle.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblMaximumValue, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtMaximumValue, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblMinimumValue, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblHorizontalMargins, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtMinimumValue, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.numHeight, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblHeight, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblWidth, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.numWidth, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblVerticalMargins, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.numVerticalMargins, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.numHorizontalMargins, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 53);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(571, 86);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lblMaximumValue
            // 
            this.lblMaximumValue.AutoSize = true;
            this.lblMaximumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaximumValue.Location = new System.Drawing.Point(312, 0);
            this.lblMaximumValue.Name = "lblMaximumValue";
            this.lblMaximumValue.Size = new System.Drawing.Size(125, 28);
            this.lblMaximumValue.TabIndex = 5;
            this.lblMaximumValue.Text = "Maximum Value:";
            this.lblMaximumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaximumValue
            // 
            this.txtMaximumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaximumValue.Location = new System.Drawing.Point(443, 2);
            this.txtMaximumValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaximumValue.Name = "txtMaximumValue";
            this.txtMaximumValue.Size = new System.Drawing.Size(125, 20);
            this.txtMaximumValue.TabIndex = 6;
            this.txtMaximumValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaximumValue_Validating);
            // 
            // lblMinimumValue
            // 
            this.lblMinimumValue.AutoSize = true;
            this.lblMinimumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinimumValue.Location = new System.Drawing.Point(3, 0);
            this.lblMinimumValue.Name = "lblMinimumValue";
            this.lblMinimumValue.Size = new System.Drawing.Size(143, 28);
            this.lblMinimumValue.TabIndex = 5;
            this.lblMinimumValue.Text = "Minimum Value:";
            this.lblMinimumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorizontalMargins
            // 
            this.lblHorizontalMargins.AutoSize = true;
            this.lblHorizontalMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorizontalMargins.Location = new System.Drawing.Point(3, 56);
            this.lblHorizontalMargins.Name = "lblHorizontalMargins";
            this.lblHorizontalMargins.Size = new System.Drawing.Size(143, 30);
            this.lblHorizontalMargins.TabIndex = 5;
            this.lblHorizontalMargins.Text = "Horizontal Margins:";
            this.lblHorizontalMargins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMinimumValue
            // 
            this.txtMinimumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMinimumValue.Location = new System.Drawing.Point(152, 2);
            this.txtMinimumValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinimumValue.Name = "txtMinimumValue";
            this.txtMinimumValue.Size = new System.Drawing.Size(125, 20);
            this.txtMinimumValue.TabIndex = 5;
            this.txtMinimumValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtMinimumValue_Validating);
            // 
            // numHeight
            // 
            this.numHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHeight.Location = new System.Drawing.Point(443, 30);
            this.numHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(125, 20);
            this.numHeight.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeight.Location = new System.Drawing.Point(312, 28);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(125, 28);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWidth.Location = new System.Drawing.Point(3, 28);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(143, 28);
            this.lblWidth.TabIndex = 9;
            this.lblWidth.Text = "Width:";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numWidth
            // 
            this.numWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWidth.Location = new System.Drawing.Point(152, 30);
            this.numWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(125, 20);
            this.numWidth.TabIndex = 10;
            // 
            // lblVerticalMargins
            // 
            this.lblVerticalMargins.AutoSize = true;
            this.lblVerticalMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerticalMargins.Location = new System.Drawing.Point(312, 56);
            this.lblVerticalMargins.Name = "lblVerticalMargins";
            this.lblVerticalMargins.Size = new System.Drawing.Size(125, 30);
            this.lblVerticalMargins.TabIndex = 11;
            this.lblVerticalMargins.Text = "Vertical Margins:";
            this.lblVerticalMargins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numVerticalMargins
            // 
            this.numVerticalMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numVerticalMargins.Location = new System.Drawing.Point(443, 58);
            this.numVerticalMargins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numVerticalMargins.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numVerticalMargins.Name = "numVerticalMargins";
            this.numVerticalMargins.Size = new System.Drawing.Size(125, 20);
            this.numVerticalMargins.TabIndex = 12;
            // 
            // numHorizontalMargins
            // 
            this.numHorizontalMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHorizontalMargins.Location = new System.Drawing.Point(152, 58);
            this.numHorizontalMargins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numHorizontalMargins.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHorizontalMargins.Name = "numHorizontalMargins";
            this.numHorizontalMargins.Size = new System.Drawing.Size(125, 20);
            this.numHorizontalMargins.TabIndex = 13;
            // 
            // lblGraphColor
            // 
            this.lblGraphColor.AutoSize = true;
            this.lblGraphColor.Location = new System.Drawing.Point(5, 178);
            this.lblGraphColor.Name = "lblGraphColor";
            this.lblGraphColor.Size = new System.Drawing.Size(66, 13);
            this.lblGraphColor.TabIndex = 7;
            this.lblGraphColor.Text = "Graph Color:";
            this.lblGraphColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(5, 150);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(95, 13);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Background Color:";
            this.lblBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBackgroundColor1
            // 
            this.btnBackgroundColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor1.Location = new System.Drawing.Point(133, 146);
            this.btnBackgroundColor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackgroundColor1.Name = "btnBackgroundColor1";
            this.btnBackgroundColor1.Size = new System.Drawing.Size(24, 25);
            this.btnBackgroundColor1.TabIndex = 2;
            this.btnBackgroundColor1.UseVisualStyleBackColor = false;
            this.btnBackgroundColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnBackgroundColor2
            // 
            this.btnBackgroundColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor2.Location = new System.Drawing.Point(164, 146);
            this.btnBackgroundColor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackgroundColor2.Name = "btnBackgroundColor2";
            this.btnBackgroundColor2.Size = new System.Drawing.Size(24, 25);
            this.btnBackgroundColor2.TabIndex = 3;
            this.btnBackgroundColor2.UseVisualStyleBackColor = false;
            this.btnBackgroundColor2.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // cmbBackgroundGradientType
            // 
            this.cmbBackgroundGradientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBackgroundGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackgroundGradientType.FormattingEnabled = true;
            this.cmbBackgroundGradientType.Location = new System.Drawing.Point(193, 146);
            this.cmbBackgroundGradientType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBackgroundGradientType.Name = "cmbBackgroundGradientType";
            this.cmbBackgroundGradientType.Size = new System.Drawing.Size(383, 21);
            this.cmbBackgroundGradientType.TabIndex = 1;
            this.cmbBackgroundGradientType.SelectedValueChanged += new System.EventHandler(this.cmbBackgroundGradientType_SelectedValueChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpDescriptiveText);
            this.Controls.Add(this.grpPointerPath);
            this.Controls.Add(this.grpGraph);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.Size = new System.Drawing.Size(612, 681);
            this.grpDescriptiveText.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.grpPointerPath.ResumeLayout(false);
            this.grpPointerPath.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpGraph.ResumeLayout(false);
            this.grpGraph.PerformLayout();
            this.grpValueText.ResumeLayout(false);
            this.grpValueText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValueTextDecimals)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerticalMargins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontalMargins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void AddComboboxDataSources()
        {
            cmbType.DisplayMember = "Description";
            cmbType.ValueMember = "value";
            cmbType.DataSource = Enum.GetValues(typeof(MemoryType)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();

            cmbGraphGradientType.DisplayMember = "Description";
            cmbGraphGradientType.ValueMember = "value";
            cmbGraphGradientType.DataSource = Enum.GetValues(typeof(GraphGradientType)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();

            cmbBackgroundGradientType.DisplayMember = "Description";
            cmbBackgroundGradientType.ValueMember = "value";
            cmbBackgroundGradientType.DataSource = Enum.GetValues(typeof(GradientType)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();

            cmbGraphStyle.DisplayMember = "Description";
            cmbGraphStyle.ValueMember = "value";
            cmbGraphStyle.DataSource = Enum.GetValues(typeof(GraphStyle)).Cast<Enum>().Select(value =>
                new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                     typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                }).OrderBy(item => item.value).ToList();

            cmbValueTextPosition.DisplayMember = "Description";
            cmbValueTextPosition.ValueMember = "value";
            cmbValueTextPosition.DataSource = Enum.GetValues(typeof(Position)).Cast<Enum>().Select(value =>
               new
               {
                   (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                   value
               }).OrderBy(item => item.value).ToList();

            cmbDescriptiveTextPosition.DisplayMember = "Description";
            cmbDescriptiveTextPosition.ValueMember = "value";
            cmbDescriptiveTextPosition.DataSource = Enum.GetValues(typeof(Position)).Cast<Enum>().Select(value =>
               new
               {
                   (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                   value
               }).OrderBy(item => item.value).ToList();

            cmbUnitsUsed.DisplayMember = "Description";
            cmbUnitsUsed.ValueMember = "value";
            cmbUnitsUsed.DataSource = Enum.GetValues(typeof(Units)).Cast<Enum>().Select(value =>
               new
               {
                   (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                   value
               }).OrderBy(item => item.value).ToList();
        }
        private System.Windows.Forms.GroupBox grpPointerPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.TextBox txtOffsets;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblOffsets;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.GroupBox grpGraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblMaximumValue;
        private System.Windows.Forms.TextBox txtMaximumValue;
        private System.Windows.Forms.Label lblMinimumValue;
        private System.Windows.Forms.ComboBox cmbGraphStyle;
        private System.Windows.Forms.Label lblGraphStyle;
        private System.Windows.Forms.TextBox txtMinimumValue;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblHorizontalMargins;
        private System.Windows.Forms.Label lblVerticalMargins;
        private System.Windows.Forms.NumericUpDown numVerticalMargins;
        private System.Windows.Forms.NumericUpDown numHorizontalMargins;
        private System.Windows.Forms.GroupBox grpValueText;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.GroupBox grpDescriptiveText;
        private TextStyleOverrideControl overrideControlDescriptiveText;
        private TextStyleOverrideControl overrideControlValueText;
        private System.Windows.Forms.Label lblValueTextPosition;
        private System.Windows.Forms.ComboBox cmbValueTextPosition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cmbDescriptiveTextPosition;
        private System.Windows.Forms.TextBox txtDescriptiveText;
        private System.Windows.Forms.Label lblDescriptiveTextPosition;
        private System.Windows.Forms.Label lblDecimals;
        private System.Windows.Forms.NumericUpDown numValueTextDecimals;
        private System.Windows.Forms.Button B_UpdateXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_ListOfGames;
        private System.Windows.Forms.Label lblGraphColor;
        private System.Windows.Forms.ComboBox cmbGraphGradientType;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.ComboBox cmbBackgroundGradientType;
        private System.Windows.Forms.Button btnBackgroundColor1;
        private System.Windows.Forms.Button btnBackgroundColor2;
        private System.Windows.Forms.CheckBox colorsCBSillyColors;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.LinkLabel linkLabel_AdditionalFiles;
        private System.Windows.Forms.Label L_Requires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUnitsUsed;
        private System.Windows.Forms.CheckBox unitConversionCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMeterToGameUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox localMaxCB;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnDeleteColor;
        private System.Windows.Forms.ComboBox ComboBox_GameOption;
    }
}
