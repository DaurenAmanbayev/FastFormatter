namespace FastFormatter
{
    partial class PatternsManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternsManager));
            this.listViewPatterns = new System.Windows.Forms.ListView();
            this.contextMenuStripPatterns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripPatterns.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPatterns
            // 
            this.listViewPatterns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderValue});
            this.listViewPatterns.ContextMenuStrip = this.contextMenuStripPatterns;
            this.listViewPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPatterns.Location = new System.Drawing.Point(0, 0);
            this.listViewPatterns.Name = "listViewPatterns";
            this.listViewPatterns.Size = new System.Drawing.Size(338, 420);
            this.listViewPatterns.TabIndex = 0;
            this.listViewPatterns.UseCompatibleStateImageBehavior = false;
            this.listViewPatterns.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStripPatterns
            // 
            this.contextMenuStripPatterns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatternToolStripMenuItem,
            this.deletePatternToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStripPatterns.Name = "contextMenuStripPatterns";
            this.contextMenuStripPatterns.Size = new System.Drawing.Size(149, 76);
            // 
            // addPatternToolStripMenuItem
            // 
            this.addPatternToolStripMenuItem.Name = "addPatternToolStripMenuItem";
            this.addPatternToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addPatternToolStripMenuItem.Text = "Add Pattern";
            this.addPatternToolStripMenuItem.Click += new System.EventHandler(this.addPatternToolStripMenuItem_Click);
            // 
            // deletePatternToolStripMenuItem
            // 
            this.deletePatternToolStripMenuItem.Name = "deletePatternToolStripMenuItem";
            this.deletePatternToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deletePatternToolStripMenuItem.Text = "Delete Pattern";
            this.deletePatternToolStripMenuItem.Click += new System.EventHandler(this.deletePatternToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 50;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 80;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Pattern";
            this.columnHeaderValue.Width = 150;
            // 
            // PatternsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 420);
            this.Controls.Add(this.listViewPatterns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatternsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patterns Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatternsFrm_FormClosing);
            this.contextMenuStripPatterns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPatterns;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPatterns;
        private System.Windows.Forms.ToolStripMenuItem addPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
    }
}