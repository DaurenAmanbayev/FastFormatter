namespace FastFormatter
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatternsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.tabControlOperations = new System.Windows.Forms.TabControl();
            this.tabPageExtractor = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPatterns = new System.Windows.Forms.ComboBox();
            this.checkBoxAdvPatterns = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchPattern = new System.Windows.Forms.TextBox();
            this.checkBoxUseCustom = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonCRLF = new System.Windows.Forms.RadioButton();
            this.radioButtonLF = new System.Windows.Forms.RadioButton();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.tabPageEditor = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBracketStart = new System.Windows.Forms.TextBox();
            this.textBoxBracketEnd = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonBrackets = new System.Windows.Forms.RadioButton();
            this.radioButtonReplace = new System.Windows.Forms.RadioButton();
            this.radioButtonRemove = new System.Windows.Forms.RadioButton();
            this.radioButtonTrim = new System.Windows.Forms.RadioButton();
            this.radioButtonFormat = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonEditorCRLF = new System.Windows.Forms.RadioButton();
            this.radioButtonEditorLF = new System.Windows.Forms.RadioButton();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlOperations.SuspendLayout();
            this.tabPageExtractor.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPageEditor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.Location = new System.Drawing.Point(0, 584);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(604, 22);
            this.statusStripInfo.TabIndex = 0;
            this.statusStripInfo.Text = "statusStrip";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(604, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveFileAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openToolStripMenuItem.Text = "Open File...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.saveFileAsToolStripMenuItem.Text = "Save File As...";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.saveFileAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePatternsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // managePatternsToolStripMenuItem
            // 
            this.managePatternsToolStripMenuItem.Name = "managePatternsToolStripMenuItem";
            this.managePatternsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.managePatternsToolStripMenuItem.Text = "Manage Patterns";
            this.managePatternsToolStripMenuItem.Click += new System.EventHandler(this.managePatternsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxContent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.tabControlOperations);
            this.splitContainer1.Size = new System.Drawing.Size(604, 560);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 2;
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxContent.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(364, 560);
            this.richTextBoxContent.TabIndex = 0;
            this.richTextBoxContent.Text = "";
            // 
            // tabControlOperations
            // 
            this.tabControlOperations.Controls.Add(this.tabPageExtractor);
            this.tabControlOperations.Controls.Add(this.tabPageEditor);
            this.tabControlOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOperations.Location = new System.Drawing.Point(0, 0);
            this.tabControlOperations.Name = "tabControlOperations";
            this.tabControlOperations.SelectedIndex = 0;
            this.tabControlOperations.Size = new System.Drawing.Size(236, 560);
            this.tabControlOperations.TabIndex = 0;
            // 
            // tabPageExtractor
            // 
            this.tabPageExtractor.Controls.Add(this.tableLayoutPanel1);
            this.tabPageExtractor.Location = new System.Drawing.Point(4, 22);
            this.tabPageExtractor.Name = "tabPageExtractor";
            this.tabPageExtractor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExtractor.Size = new System.Drawing.Size(228, 534);
            this.tabPageExtractor.TabIndex = 0;
            this.tabPageExtractor.Text = "Extractor";
            this.tabPageExtractor.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPatterns);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAdvPatterns);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(216, 64);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard Pattern";
            // 
            // comboBoxPatterns
            // 
            this.comboBoxPatterns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatterns.FormattingEnabled = true;
            this.comboBoxPatterns.Location = new System.Drawing.Point(3, 16);
            this.comboBoxPatterns.Name = "comboBoxPatterns";
            this.comboBoxPatterns.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPatterns.TabIndex = 1;
            // 
            // checkBoxAdvPatterns
            // 
            this.checkBoxAdvPatterns.AutoSize = true;
            this.checkBoxAdvPatterns.Location = new System.Drawing.Point(3, 43);
            this.checkBoxAdvPatterns.Name = "checkBoxAdvPatterns";
            this.checkBoxAdvPatterns.Size = new System.Drawing.Size(117, 17);
            this.checkBoxAdvPatterns.TabIndex = 2;
            this.checkBoxAdvPatterns.Text = "Advanced Patterns";
            this.checkBoxAdvPatterns.UseVisualStyleBackColor = true;
            this.checkBoxAdvPatterns.CheckedChanged += new System.EventHandler(this.checkBoxAdvPatterns_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.textBoxSearchPattern);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxUseCustom);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 73);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(216, 74);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Pattern";
            // 
            // textBoxSearchPattern
            // 
            this.textBoxSearchPattern.Location = new System.Drawing.Point(3, 16);
            this.textBoxSearchPattern.Name = "textBoxSearchPattern";
            this.textBoxSearchPattern.ReadOnly = true;
            this.textBoxSearchPattern.Size = new System.Drawing.Size(179, 20);
            this.textBoxSearchPattern.TabIndex = 1;
            // 
            // checkBoxUseCustom
            // 
            this.checkBoxUseCustom.AutoSize = true;
            this.checkBoxUseCustom.Location = new System.Drawing.Point(3, 42);
            this.checkBoxUseCustom.Name = "checkBoxUseCustom";
            this.checkBoxUseCustom.Size = new System.Drawing.Size(120, 17);
            this.checkBoxUseCustom.TabIndex = 2;
            this.checkBoxUseCustom.Text = "Use Custom Pattern";
            this.checkBoxUseCustom.UseVisualStyleBackColor = true;
            this.checkBoxUseCustom.CheckedChanged += new System.EventHandler(this.checkBoxUseCustom_CheckedChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.radioButtonCRLF);
            this.flowLayoutPanel3.Controls.Add(this.radioButtonLF);
            this.flowLayoutPanel3.Controls.Add(this.buttonExtract);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 153);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(216, 372);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // radioButtonCRLF
            // 
            this.radioButtonCRLF.AutoSize = true;
            this.radioButtonCRLF.Checked = true;
            this.radioButtonCRLF.Location = new System.Drawing.Point(3, 3);
            this.radioButtonCRLF.Name = "radioButtonCRLF";
            this.radioButtonCRLF.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCRLF.TabIndex = 0;
            this.radioButtonCRLF.TabStop = true;
            this.radioButtonCRLF.Text = "CRLF";
            this.radioButtonCRLF.UseVisualStyleBackColor = true;
            // 
            // radioButtonLF
            // 
            this.radioButtonLF.AutoSize = true;
            this.radioButtonLF.Location = new System.Drawing.Point(61, 3);
            this.radioButtonLF.Name = "radioButtonLF";
            this.radioButtonLF.Size = new System.Drawing.Size(37, 17);
            this.radioButtonLF.TabIndex = 1;
            this.radioButtonLF.Text = "LF";
            this.radioButtonLF.UseVisualStyleBackColor = true;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(3, 26);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(179, 39);
            this.buttonExtract.TabIndex = 3;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // tabPageEditor
            // 
            this.tabPageEditor.Controls.Add(this.tableLayoutPanel2);
            this.tabPageEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditor.Name = "tabPageEditor";
            this.tabPageEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditor.Size = new System.Drawing.Size(228, 534);
            this.tabPageEditor.TabIndex = 1;
            this.tabPageEditor.Text = "Editor";
            this.tabPageEditor.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel7, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 528);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.textBoxBracketStart);
            this.flowLayoutPanel4.Controls.Add(this.textBoxBracketEnd);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(216, 82);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Brackets";
            // 
            // textBoxBracketStart
            // 
            this.textBoxBracketStart.Location = new System.Drawing.Point(3, 16);
            this.textBoxBracketStart.Name = "textBoxBracketStart";
            this.textBoxBracketStart.Size = new System.Drawing.Size(161, 20);
            this.textBoxBracketStart.TabIndex = 1;
            // 
            // textBoxBracketEnd
            // 
            this.textBoxBracketEnd.Location = new System.Drawing.Point(3, 42);
            this.textBoxBracketEnd.Name = "textBoxBracketEnd";
            this.textBoxBracketEnd.Size = new System.Drawing.Size(161, 20);
            this.textBoxBracketEnd.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.textBoxPattern);
            this.flowLayoutPanel5.Controls.Add(this.textBoxReplace);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 91);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(216, 79);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(3, 16);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.ReadOnly = true;
            this.textBoxPattern.Size = new System.Drawing.Size(179, 20);
            this.textBoxPattern.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.radioButtonBrackets);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonReplace);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonRemove);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonTrim);
            this.flowLayoutPanel6.Controls.Add(this.radioButtonFormat);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 176);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(216, 74);
            this.flowLayoutPanel6.TabIndex = 4;
            // 
            // radioButtonBrackets
            // 
            this.radioButtonBrackets.AutoSize = true;
            this.radioButtonBrackets.Checked = true;
            this.radioButtonBrackets.Location = new System.Drawing.Point(3, 3);
            this.radioButtonBrackets.Name = "radioButtonBrackets";
            this.radioButtonBrackets.Size = new System.Drawing.Size(67, 17);
            this.radioButtonBrackets.TabIndex = 0;
            this.radioButtonBrackets.TabStop = true;
            this.radioButtonBrackets.Text = "Brackets";
            this.radioButtonBrackets.UseVisualStyleBackColor = true;
            this.radioButtonBrackets.CheckedChanged += new System.EventHandler(this.radioButtonBrackets_CheckedChanged);
            // 
            // radioButtonReplace
            // 
            this.radioButtonReplace.AutoSize = true;
            this.radioButtonReplace.Location = new System.Drawing.Point(76, 3);
            this.radioButtonReplace.Name = "radioButtonReplace";
            this.radioButtonReplace.Size = new System.Drawing.Size(65, 17);
            this.radioButtonReplace.TabIndex = 1;
            this.radioButtonReplace.Text = "Replace";
            this.radioButtonReplace.UseVisualStyleBackColor = true;
            this.radioButtonReplace.CheckedChanged += new System.EventHandler(this.radioButtonReplace_CheckedChanged);
            // 
            // radioButtonRemove
            // 
            this.radioButtonRemove.AutoSize = true;
            this.radioButtonRemove.Location = new System.Drawing.Point(147, 3);
            this.radioButtonRemove.Name = "radioButtonRemove";
            this.radioButtonRemove.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRemove.TabIndex = 2;
            this.radioButtonRemove.Text = "Remove";
            this.radioButtonRemove.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrim
            // 
            this.radioButtonTrim.AutoSize = true;
            this.radioButtonTrim.Location = new System.Drawing.Point(3, 26);
            this.radioButtonTrim.Name = "radioButtonTrim";
            this.radioButtonTrim.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTrim.TabIndex = 3;
            this.radioButtonTrim.Text = "Trim";
            this.radioButtonTrim.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormat
            // 
            this.radioButtonFormat.AutoSize = true;
            this.radioButtonFormat.Location = new System.Drawing.Point(54, 26);
            this.radioButtonFormat.Name = "radioButtonFormat";
            this.radioButtonFormat.Size = new System.Drawing.Size(57, 17);
            this.radioButtonFormat.TabIndex = 4;
            this.radioButtonFormat.TabStop = true;
            this.radioButtonFormat.Text = "Format";
            this.radioButtonFormat.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.radioButtonEditorCRLF);
            this.flowLayoutPanel7.Controls.Add(this.radioButtonEditorLF);
            this.flowLayoutPanel7.Controls.Add(this.buttonEdit);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 256);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(216, 286);
            this.flowLayoutPanel7.TabIndex = 5;
            // 
            // radioButtonEditorCRLF
            // 
            this.radioButtonEditorCRLF.AutoSize = true;
            this.radioButtonEditorCRLF.Checked = true;
            this.radioButtonEditorCRLF.Location = new System.Drawing.Point(3, 3);
            this.radioButtonEditorCRLF.Name = "radioButtonEditorCRLF";
            this.radioButtonEditorCRLF.Size = new System.Drawing.Size(52, 17);
            this.radioButtonEditorCRLF.TabIndex = 0;
            this.radioButtonEditorCRLF.TabStop = true;
            this.radioButtonEditorCRLF.Text = "CRLF";
            this.radioButtonEditorCRLF.UseVisualStyleBackColor = true;
            // 
            // radioButtonEditorLF
            // 
            this.radioButtonEditorLF.AutoSize = true;
            this.radioButtonEditorLF.Location = new System.Drawing.Point(61, 3);
            this.radioButtonEditorLF.Name = "radioButtonEditorLF";
            this.radioButtonEditorLF.Size = new System.Drawing.Size(37, 17);
            this.radioButtonEditorLF.TabIndex = 1;
            this.radioButtonEditorLF.Text = "LF";
            this.radioButtonEditorLF.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(3, 26);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(179, 39);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Format";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(3, 42);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.ReadOnly = true;
            this.textBoxReplace.Size = new System.Drawing.Size(179, 20);
            this.textBoxReplace.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pattern";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(604, 606);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStripInfo);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Fast Format Tool";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlOperations.ResumeLayout(false);
            this.tabPageExtractor.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tabPageEditor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePatternsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.TabControl tabControlOperations;
        private System.Windows.Forms.TabPage tabPageExtractor;
        private System.Windows.Forms.TabPage tabPageEditor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPatterns;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchPattern;
        private System.Windows.Forms.CheckBox checkBoxUseCustom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton radioButtonCRLF;
        private System.Windows.Forms.RadioButton radioButtonLF;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.RadioButton radioButtonEditorCRLF;
        private System.Windows.Forms.RadioButton radioButtonEditorLF;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBracketStart;
        private System.Windows.Forms.TextBox textBoxBracketEnd;
        private System.Windows.Forms.RadioButton radioButtonBrackets;
        private System.Windows.Forms.RadioButton radioButtonReplace;
        private System.Windows.Forms.RadioButton radioButtonRemove;
        private System.Windows.Forms.RadioButton radioButtonTrim;
        private System.Windows.Forms.CheckBox checkBoxAdvPatterns;
        private System.Windows.Forms.RadioButton radioButtonFormat;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label label5;
    }
}

