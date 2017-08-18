namespace C_Sharp_Tool
{
    partial class Map_Creation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_Creation));
            this.gbItemList = new System.Windows.Forms.GroupBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMap = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcItemList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbItemList.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.tcItemList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbItemList
            // 
            this.gbItemList.Controls.Add(this.tcItemList);
            this.gbItemList.Location = new System.Drawing.Point(3, 28);
            this.gbItemList.Name = "gbItemList";
            this.gbItemList.Size = new System.Drawing.Size(330, 500);
            this.gbItemList.TabIndex = 0;
            this.gbItemList.TabStop = false;
            this.gbItemList.Text = "Item List";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsMap,
            this.tsHelp});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1560, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.tsFile.Image = ((System.Drawing.Image)(resources.GetObject("tsFile.Image")));
            this.tsFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(38, 22);
            this.tsFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tsMap
            // 
            this.tsMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.breakdownToolStripMenuItem});
            this.tsMap.Image = ((System.Drawing.Image)(resources.GetObject("tsMap.Image")));
            this.tsMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMap.Name = "tsMap";
            this.tsMap.Size = new System.Drawing.Size(44, 22);
            this.tsMap.Text = "Map";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // breakdownToolStripMenuItem
            // 
            this.breakdownToolStripMenuItem.Name = "breakdownToolStripMenuItem";
            this.breakdownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.breakdownToolStripMenuItem.Text = "Breakdown";
            // 
            // tsHelp
            // 
            this.tsHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpInformationToolStripMenuItem});
            this.tsHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsHelp.Image")));
            this.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(45, 22);
            this.tsHelp.Text = "Help";
            // 
            // helpInformationToolStripMenuItem
            // 
            this.helpInformationToolStripMenuItem.Name = "helpInformationToolStripMenuItem";
            this.helpInformationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.helpInformationToolStripMenuItem.Text = "Help Information";
            // 
            // tcItemList
            // 
            this.tcItemList.Controls.Add(this.tabPage1);
            this.tcItemList.Controls.Add(this.tabPage2);
            this.tcItemList.Location = new System.Drawing.Point(6, 19);
            this.tcItemList.Name = "tcItemList";
            this.tcItemList.SelectedIndex = 0;
            this.tcItemList.Size = new System.Drawing.Size(318, 475);
            this.tcItemList.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Map_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.gbItemList);
            this.Name = "Map_Creation";
            this.Size = new System.Drawing.Size(1560, 800);
            this.Load += new System.EventHandler(this.Map_Creation_Load);
            this.gbItemList.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tcItemList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItemList;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsMap;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsHelp;
        private System.Windows.Forms.ToolStripMenuItem helpInformationToolStripMenuItem;
        private System.Windows.Forms.TabControl tcItemList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
