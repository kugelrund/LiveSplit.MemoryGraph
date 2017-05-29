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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpPointerPath = new System.Windows.Forms.GroupBox();
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbGraphStyle = new System.Windows.Forms.ComboBox();
            this.lblGraphStyle = new System.Windows.Forms.Label();
            this.grpValueText = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.overrideControlValueText = new LiveSplit.MemoryGraph.TextStyleOverrideControl();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblValueTextPosition = new System.Windows.Forms.Label();
            this.cmbValueTextPosition = new System.Windows.Forms.ComboBox();
            this.lblDecimals = new System.Windows.Forms.Label();
            this.numValueTextDecimals = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGraphColor = new System.Windows.Forms.Label();
            this.btnGraphColor1 = new System.Windows.Forms.Button();
            this.btnGraphColor2 = new System.Windows.Forms.Button();
            this.cmbGraphGradientType = new System.Windows.Forms.ComboBox();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.cmbBackgroundGradientType = new System.Windows.Forms.ComboBox();
            this.btnBackgroundColor1 = new System.Windows.Forms.Button();
            this.btnBackgroundColor2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorsCBSillyColors = new System.Windows.Forms.CheckBox();
            this.grpDescriptiveText = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.overrideControlDescriptiveText = new LiveSplit.MemoryGraph.TextStyleOverrideControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescriptiveText = new System.Windows.Forms.TextBox();
            this.lblDescriptiveTextPosition = new System.Windows.Forms.Label();
            this.cmbDescriptiveTextPosition = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.L_Requires = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpPointerPath.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpGraph.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerticalMargins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontalMargins)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.grpValueText.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValueTextDecimals)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpDescriptiveText.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpPointerPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpGraph, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpDescriptiveText, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 598);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpPointerPath
            // 
            this.grpPointerPath.Controls.Add(this.L_Requires);
            this.grpPointerPath.Controls.Add(this.linkLabel_AdditionalFiles);
            this.grpPointerPath.Controls.Add(this.ComboBox_ListOfGames);
            this.grpPointerPath.Controls.Add(this.B_UpdateXML);
            this.grpPointerPath.Controls.Add(this.label1);
            this.grpPointerPath.Controls.Add(this.txtProcessName);
            this.grpPointerPath.Controls.Add(this.lblProcessName);
            this.grpPointerPath.Controls.Add(this.tableLayoutPanel2);
            this.grpPointerPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPointerPath.Location = new System.Drawing.Point(3, 3);
            this.grpPointerPath.Name = "grpPointerPath";
            this.grpPointerPath.Size = new System.Drawing.Size(455, 148);
            this.grpPointerPath.TabIndex = 0;
            this.grpPointerPath.TabStop = false;
            this.grpPointerPath.Text = "Pointer path";
            // 
            // linkLabel_AdditionalFiles
            // 
            this.linkLabel_AdditionalFiles.AutoSize = true;
            this.linkLabel_AdditionalFiles.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel_AdditionalFiles.Location = new System.Drawing.Point(58, 39);
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
            this.ComboBox_ListOfGames.FormattingEnabled = true;
            this.ComboBox_ListOfGames.Location = new System.Drawing.Point(46, 15);
            this.ComboBox_ListOfGames.Name = "ComboBox_ListOfGames";
            this.ComboBox_ListOfGames.Size = new System.Drawing.Size(303, 21);
            this.ComboBox_ListOfGames.TabIndex = 9;
            this.ComboBox_ListOfGames.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ListOfGames_SelectedIndexChanged);
            // 
            // B_UpdateXML
            // 
            this.B_UpdateXML.Location = new System.Drawing.Point(354, 15);
            this.B_UpdateXML.Name = "B_UpdateXML";
            this.B_UpdateXML.Size = new System.Drawing.Size(98, 21);
            this.B_UpdateXML.TabIndex = 8;
            this.B_UpdateXML.Text = "Update XML file";
            this.B_UpdateXML.UseVisualStyleBackColor = true;
            this.B_UpdateXML.Click += new System.EventHandler(this.B_UpdateXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtProcessName.Location = new System.Drawing.Point(121, 116);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(328, 20);
            this.txtProcessName.TabIndex = 5;
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(6, 119);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(91, 13);
            this.lblProcessName.TabIndex = 4;
            this.lblProcessName.Text = "Name of Process:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.lblModule, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtOffsets, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBase, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtModule, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBase, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblOffsets, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblType, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbType, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(449, 50);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModule.Location = new System.Drawing.Point(3, 0);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(86, 20);
            this.lblModule.TabIndex = 0;
            this.lblModule.Text = "Module:";
            this.lblModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOffsets
            // 
            this.txtOffsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOffsets.Location = new System.Drawing.Point(187, 23);
            this.txtOffsets.Name = "txtOffsets";
            this.txtOffsets.Size = new System.Drawing.Size(178, 20);
            this.txtOffsets.TabIndex = 1;
            this.txtOffsets.Validating += new System.ComponentModel.CancelEventHandler(this.txtOffsets_Validating);
            // 
            // txtBase
            // 
            this.txtBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase.Location = new System.Drawing.Point(95, 23);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(86, 20);
            this.txtBase.TabIndex = 1;
            this.txtBase.Validating += new System.ComponentModel.CancelEventHandler(this.txtBase_Validating);
            // 
            // txtModule
            // 
            this.txtModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModule.Location = new System.Drawing.Point(3, 23);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(86, 20);
            this.txtModule.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBase.Location = new System.Drawing.Point(95, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(86, 20);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base:";
            this.lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOffsets
            // 
            this.lblOffsets.AutoSize = true;
            this.lblOffsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOffsets.Location = new System.Drawing.Point(187, 0);
            this.lblOffsets.Name = "lblOffsets";
            this.lblOffsets.Size = new System.Drawing.Size(178, 20);
            this.lblOffsets.TabIndex = 2;
            this.lblOffsets.Text = "Offsets (comma seperated):";
            this.lblOffsets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Location = new System.Drawing.Point(371, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(75, 20);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbType
            // 
            this.cmbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(371, 23);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(75, 21);
            this.cmbType.TabIndex = 4;
            // 
            // grpGraph
            // 
            this.grpGraph.Controls.Add(this.tableLayoutPanel3);
            this.grpGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGraph.Location = new System.Drawing.Point(3, 158);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Size = new System.Drawing.Size(455, 338);
            this.grpGraph.TabIndex = 1;
            this.grpGraph.TabStop = false;
            this.grpGraph.Text = "Graph";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.grpValueText, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(449, 319);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
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
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(443, 79);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lblMaximumValue
            // 
            this.lblMaximumValue.AutoSize = true;
            this.lblMaximumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaximumValue.Location = new System.Drawing.Point(239, 0);
            this.lblMaximumValue.Name = "lblMaximumValue";
            this.lblMaximumValue.Size = new System.Drawing.Size(104, 26);
            this.lblMaximumValue.TabIndex = 5;
            this.lblMaximumValue.Text = "Maximum Value:";
            this.lblMaximumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaximumValue
            // 
            this.txtMaximumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaximumValue.Location = new System.Drawing.Point(349, 3);
            this.txtMaximumValue.Name = "txtMaximumValue";
            this.txtMaximumValue.Size = new System.Drawing.Size(91, 20);
            this.txtMaximumValue.TabIndex = 6;
            this.txtMaximumValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaximumValue_Validating);
            // 
            // lblMinimumValue
            // 
            this.lblMinimumValue.AutoSize = true;
            this.lblMinimumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinimumValue.Location = new System.Drawing.Point(3, 0);
            this.lblMinimumValue.Name = "lblMinimumValue";
            this.lblMinimumValue.Size = new System.Drawing.Size(104, 26);
            this.lblMinimumValue.TabIndex = 5;
            this.lblMinimumValue.Text = "Minimum Value:";
            this.lblMinimumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHorizontalMargins
            // 
            this.lblHorizontalMargins.AutoSize = true;
            this.lblHorizontalMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHorizontalMargins.Location = new System.Drawing.Point(3, 52);
            this.lblHorizontalMargins.Name = "lblHorizontalMargins";
            this.lblHorizontalMargins.Size = new System.Drawing.Size(104, 27);
            this.lblHorizontalMargins.TabIndex = 5;
            this.lblHorizontalMargins.Text = "Horizontal Margins:";
            this.lblHorizontalMargins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMinimumValue
            // 
            this.txtMinimumValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMinimumValue.Location = new System.Drawing.Point(113, 3);
            this.txtMinimumValue.Name = "txtMinimumValue";
            this.txtMinimumValue.Size = new System.Drawing.Size(90, 20);
            this.txtMinimumValue.TabIndex = 5;
            this.txtMinimumValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtMinimumValue_Validating);
            // 
            // numHeight
            // 
            this.numHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHeight.Location = new System.Drawing.Point(349, 29);
            this.numHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(91, 20);
            this.numHeight.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeight.Location = new System.Drawing.Point(239, 26);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(104, 26);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWidth.Location = new System.Drawing.Point(3, 26);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(104, 26);
            this.lblWidth.TabIndex = 9;
            this.lblWidth.Text = "Width:";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numWidth
            // 
            this.numWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWidth.Location = new System.Drawing.Point(113, 29);
            this.numWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(90, 20);
            this.numWidth.TabIndex = 10;
            // 
            // lblVerticalMargins
            // 
            this.lblVerticalMargins.AutoSize = true;
            this.lblVerticalMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerticalMargins.Location = new System.Drawing.Point(239, 52);
            this.lblVerticalMargins.Name = "lblVerticalMargins";
            this.lblVerticalMargins.Size = new System.Drawing.Size(104, 27);
            this.lblVerticalMargins.TabIndex = 11;
            this.lblVerticalMargins.Text = "Vertical Margins:";
            this.lblVerticalMargins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numVerticalMargins
            // 
            this.numVerticalMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numVerticalMargins.Location = new System.Drawing.Point(349, 55);
            this.numVerticalMargins.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numVerticalMargins.Name = "numVerticalMargins";
            this.numVerticalMargins.Size = new System.Drawing.Size(91, 20);
            this.numVerticalMargins.TabIndex = 12;
            // 
            // numHorizontalMargins
            // 
            this.numHorizontalMargins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHorizontalMargins.Location = new System.Drawing.Point(113, 55);
            this.numHorizontalMargins.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHorizontalMargins.Name = "numHorizontalMargins";
            this.numHorizontalMargins.Size = new System.Drawing.Size(90, 20);
            this.numHorizontalMargins.TabIndex = 13;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.cmbGraphStyle, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblGraphStyle, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(443, 27);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // cmbGraphStyle
            // 
            this.cmbGraphStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGraphStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphStyle.FormattingEnabled = true;
            this.cmbGraphStyle.Location = new System.Drawing.Point(113, 3);
            this.cmbGraphStyle.Name = "cmbGraphStyle";
            this.cmbGraphStyle.Size = new System.Drawing.Size(327, 21);
            this.cmbGraphStyle.TabIndex = 6;
            // 
            // lblGraphStyle
            // 
            this.lblGraphStyle.AutoSize = true;
            this.lblGraphStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGraphStyle.Location = new System.Drawing.Point(3, 0);
            this.lblGraphStyle.Name = "lblGraphStyle";
            this.lblGraphStyle.Size = new System.Drawing.Size(104, 27);
            this.lblGraphStyle.TabIndex = 5;
            this.lblGraphStyle.Text = "Graph Style:";
            this.lblGraphStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpValueText
            // 
            this.grpValueText.Controls.Add(this.tableLayoutPanel7);
            this.grpValueText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpValueText.Location = new System.Drawing.Point(3, 228);
            this.grpValueText.Name = "grpValueText";
            this.grpValueText.Size = new System.Drawing.Size(443, 88);
            this.grpValueText.TabIndex = 5;
            this.grpValueText.TabStop = false;
            this.grpValueText.Text = "Value as Text";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.overrideControlValueText, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(437, 69);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // overrideControlValueText
            // 
            this.overrideControlValueText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overrideControlValueText.Location = new System.Drawing.Point(3, 36);
            this.overrideControlValueText.Name = "overrideControlValueText";
            this.overrideControlValueText.OverrideColor = false;
            this.overrideControlValueText.OverrideFont = false;
            this.overrideControlValueText.OverridingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.overrideControlValueText.OverridingFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.overrideControlValueText.Size = new System.Drawing.Size(431, 30);
            this.overrideControlValueText.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel8.Controls.Add(this.lblValueTextPosition, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.cmbValueTextPosition, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblDecimals, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.numValueTextDecimals, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(431, 27);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // lblValueTextPosition
            // 
            this.lblValueTextPosition.AutoSize = true;
            this.lblValueTextPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValueTextPosition.Location = new System.Drawing.Point(3, 0);
            this.lblValueTextPosition.Name = "lblValueTextPosition";
            this.lblValueTextPosition.Size = new System.Drawing.Size(59, 27);
            this.lblValueTextPosition.TabIndex = 0;
            this.lblValueTextPosition.Text = "Position:";
            this.lblValueTextPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbValueTextPosition
            // 
            this.cmbValueTextPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbValueTextPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValueTextPosition.FormattingEnabled = true;
            this.cmbValueTextPosition.Location = new System.Drawing.Point(68, 3);
            this.cmbValueTextPosition.Name = "cmbValueTextPosition";
            this.cmbValueTextPosition.Size = new System.Drawing.Size(230, 21);
            this.cmbValueTextPosition.TabIndex = 1;
            // 
            // lblDecimals
            // 
            this.lblDecimals.AutoSize = true;
            this.lblDecimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDecimals.Location = new System.Drawing.Point(314, 0);
            this.lblDecimals.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.lblDecimals.Name = "lblDecimals";
            this.lblDecimals.Size = new System.Drawing.Size(54, 27);
            this.lblDecimals.TabIndex = 2;
            this.lblDecimals.Text = "Decimals:";
            this.lblDecimals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numValueTextDecimals
            // 
            this.numValueTextDecimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numValueTextDecimals.Location = new System.Drawing.Point(374, 3);
            this.numValueTextDecimals.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numValueTextDecimals.Name = "numValueTextDecimals";
            this.numValueTextDecimals.Size = new System.Drawing.Size(54, 20);
            this.numValueTextDecimals.TabIndex = 3;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(443, 83);
            this.tableLayoutPanel10.TabIndex = 6;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.lblGraphColor, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.btnGraphColor1, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.btnGraphColor2, 2, 1);
            this.tableLayoutPanel11.Controls.Add(this.cmbGraphGradientType, 3, 1);
            this.tableLayoutPanel11.Controls.Add(this.lblBackgroundColor, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.cmbBackgroundGradientType, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.btnBackgroundColor1, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.btnBackgroundColor2, 2, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(437, 49);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // lblGraphColor
            // 
            this.lblGraphColor.AutoSize = true;
            this.lblGraphColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGraphColor.Location = new System.Drawing.Point(3, 24);
            this.lblGraphColor.Name = "lblGraphColor";
            this.lblGraphColor.Size = new System.Drawing.Size(102, 25);
            this.lblGraphColor.TabIndex = 7;
            this.lblGraphColor.Text = "Graph Color:";
            this.lblGraphColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGraphColor1
            // 
            this.btnGraphColor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGraphColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphColor1.Location = new System.Drawing.Point(111, 27);
            this.btnGraphColor1.Name = "btnGraphColor1";
            this.btnGraphColor1.Size = new System.Drawing.Size(26, 19);
            this.btnGraphColor1.TabIndex = 6;
            this.btnGraphColor1.UseVisualStyleBackColor = false;
            this.btnGraphColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnGraphColor2
            // 
            this.btnGraphColor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGraphColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphColor2.Location = new System.Drawing.Point(143, 27);
            this.btnGraphColor2.Name = "btnGraphColor2";
            this.btnGraphColor2.Size = new System.Drawing.Size(24, 19);
            this.btnGraphColor2.TabIndex = 5;
            this.btnGraphColor2.UseVisualStyleBackColor = false;
            this.btnGraphColor2.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // cmbGraphGradientType
            // 
            this.cmbGraphGradientType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGraphGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGraphGradientType.FormattingEnabled = true;
            this.cmbGraphGradientType.Location = new System.Drawing.Point(173, 27);
            this.cmbGraphGradientType.Name = "cmbGraphGradientType";
            this.cmbGraphGradientType.Size = new System.Drawing.Size(261, 21);
            this.cmbGraphGradientType.TabIndex = 4;
            this.cmbGraphGradientType.SelectedValueChanged += new System.EventHandler(this.cmbGraphGradientType_SelectedValueChanged);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackgroundColor.Location = new System.Drawing.Point(3, 0);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(102, 24);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Background Color:";
            this.lblBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbBackgroundGradientType
            // 
            this.cmbBackgroundGradientType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBackgroundGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackgroundGradientType.FormattingEnabled = true;
            this.cmbBackgroundGradientType.Location = new System.Drawing.Point(173, 3);
            this.cmbBackgroundGradientType.Name = "cmbBackgroundGradientType";
            this.cmbBackgroundGradientType.Size = new System.Drawing.Size(261, 21);
            this.cmbBackgroundGradientType.TabIndex = 1;
            this.cmbBackgroundGradientType.SelectedValueChanged += new System.EventHandler(this.cmbBackgroundGradientType_SelectedValueChanged);
            // 
            // btnBackgroundColor1
            // 
            this.btnBackgroundColor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor1.Location = new System.Drawing.Point(111, 3);
            this.btnBackgroundColor1.Name = "btnBackgroundColor1";
            this.btnBackgroundColor1.Size = new System.Drawing.Size(26, 18);
            this.btnBackgroundColor1.TabIndex = 2;
            this.btnBackgroundColor1.UseVisualStyleBackColor = false;
            this.btnBackgroundColor1.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // btnBackgroundColor2
            // 
            this.btnBackgroundColor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackgroundColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor2.Location = new System.Drawing.Point(143, 3);
            this.btnBackgroundColor2.Name = "btnBackgroundColor2";
            this.btnBackgroundColor2.Size = new System.Drawing.Size(24, 18);
            this.btnBackgroundColor2.TabIndex = 3;
            this.btnBackgroundColor2.UseVisualStyleBackColor = false;
            this.btnBackgroundColor2.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorsCBSillyColors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 22);
            this.panel1.TabIndex = 3;
            // 
            // colorsCBSillyColors
            // 
            this.colorsCBSillyColors.AutoSize = true;
            this.colorsCBSillyColors.Location = new System.Drawing.Point(5, 2);
            this.colorsCBSillyColors.Name = "colorsCBSillyColors";
            this.colorsCBSillyColors.Size = new System.Drawing.Size(76, 17);
            this.colorsCBSillyColors.TabIndex = 0;
            this.colorsCBSillyColors.Text = "Silly Colors";
            this.colorsCBSillyColors.UseVisualStyleBackColor = true;
            this.colorsCBSillyColors.MouseHover += new System.EventHandler(this.colorsCBSillyColors_MouseHover);
            // 
            // grpDescriptiveText
            // 
            this.grpDescriptiveText.Controls.Add(this.tableLayoutPanel9);
            this.grpDescriptiveText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDescriptiveText.Location = new System.Drawing.Point(3, 502);
            this.grpDescriptiveText.Name = "grpDescriptiveText";
            this.grpDescriptiveText.Size = new System.Drawing.Size(455, 93);
            this.grpDescriptiveText.TabIndex = 2;
            this.grpDescriptiveText.TabStop = false;
            this.grpDescriptiveText.Text = "Descriptive Text";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.overrideControlDescriptiveText, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(449, 74);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // overrideControlDescriptiveText
            // 
            this.overrideControlDescriptiveText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overrideControlDescriptiveText.Location = new System.Drawing.Point(3, 36);
            this.overrideControlDescriptiveText.Name = "overrideControlDescriptiveText";
            this.overrideControlDescriptiveText.OverrideColor = false;
            this.overrideControlDescriptiveText.OverrideFont = false;
            this.overrideControlDescriptiveText.OverridingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.overrideControlDescriptiveText.OverridingFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.overrideControlDescriptiveText.Size = new System.Drawing.Size(443, 35);
            this.overrideControlDescriptiveText.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.txtDescriptiveText, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDescriptiveTextPosition, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbDescriptiveTextPosition, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(443, 27);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txtDescriptiveText
            // 
            this.txtDescriptiveText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescriptiveText.Location = new System.Drawing.Point(3, 3);
            this.txtDescriptiveText.Name = "txtDescriptiveText";
            this.txtDescriptiveText.Size = new System.Drawing.Size(217, 20);
            this.txtDescriptiveText.TabIndex = 2;
            // 
            // lblDescriptiveTextPosition
            // 
            this.lblDescriptiveTextPosition.AutoSize = true;
            this.lblDescriptiveTextPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescriptiveTextPosition.Location = new System.Drawing.Point(236, 0);
            this.lblDescriptiveTextPosition.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.lblDescriptiveTextPosition.Name = "lblDescriptiveTextPosition";
            this.lblDescriptiveTextPosition.Size = new System.Drawing.Size(54, 27);
            this.lblDescriptiveTextPosition.TabIndex = 0;
            this.lblDescriptiveTextPosition.Text = "Position:";
            this.lblDescriptiveTextPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDescriptiveTextPosition
            // 
            this.cmbDescriptiveTextPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDescriptiveTextPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescriptiveTextPosition.FormattingEnabled = true;
            this.cmbDescriptiveTextPosition.Location = new System.Drawing.Point(296, 3);
            this.cmbDescriptiveTextPosition.Name = "cmbDescriptiveTextPosition";
            this.cmbDescriptiveTextPosition.Size = new System.Drawing.Size(144, 21);
            this.cmbDescriptiveTextPosition.TabIndex = 1;
            // 
            // L_Requires
            // 
            this.L_Requires.AutoSize = true;
            this.L_Requires.Location = new System.Drawing.Point(6, 39);
            this.L_Requires.Name = "L_Requires";
            this.L_Requires.Size = new System.Drawing.Size(52, 13);
            this.L_Requires.TabIndex = 11;
            this.L_Requires.Text = "Requires:";
            // 
            // Settings
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(461, 601);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpPointerPath.ResumeLayout(false);
            this.grpPointerPath.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpGraph.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerticalMargins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontalMargins)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.grpValueText.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValueTextDecimals)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDescriptiveText.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblMaximumValue;
        private System.Windows.Forms.TextBox txtMaximumValue;
        private System.Windows.Forms.Label lblMinimumValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private TextStyleOverrideControl overrideControlDescriptiveText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private TextStyleOverrideControl overrideControlValueText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label lblGraphColor;
        private System.Windows.Forms.Button btnGraphColor1;
        private System.Windows.Forms.Button btnGraphColor2;
        private System.Windows.Forms.ComboBox cmbGraphGradientType;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.ComboBox cmbBackgroundGradientType;
        private System.Windows.Forms.Button btnBackgroundColor1;
        private System.Windows.Forms.Button btnBackgroundColor2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox colorsCBSillyColors;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.LinkLabel linkLabel_AdditionalFiles;
        private System.Windows.Forms.Label L_Requires;
    }
}
