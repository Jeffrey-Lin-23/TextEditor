namespace Ass02
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TBtnNew = new System.Windows.Forms.ToolStripButton();
            this.TBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.TBtnSave = new System.Windows.Forms.ToolStripButton();
            this.SaveAsTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBtnBold = new System.Windows.Forms.ToolStripButton();
            this.TBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.TBtnUnderLine = new System.Windows.Forms.ToolStripButton();
            this.FontSizeBox = new System.Windows.Forms.ToolStripComboBox();
            this.TBtnAbout = new System.Windows.Forms.ToolStripButton();
            this.UserLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.LBtnCut = new System.Windows.Forms.ToolStripButton();
            this.LBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.LBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.MenuItemOpen,
            this.MenuItemSave,
            this.MenuItemSaveAs,
            this.logOutToolStripMenuItem,
            this.StripMenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.MenuItemNew_Click);
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemOpen.Image")));
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemOpen.Size = new System.Drawing.Size(184, 26);
            this.MenuItemOpen.Text = "Open";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemSave.Image")));
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemSave.Size = new System.Drawing.Size(184, 26);
            this.MenuItemSave.Text = "Save";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // MenuItemSaveAs
            // 
            this.MenuItemSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemSaveAs.Image")));
            this.MenuItemSaveAs.Name = "MenuItemSaveAs";
            this.MenuItemSaveAs.Size = new System.Drawing.Size(184, 26);
            this.MenuItemSaveAs.Text = "Save as";
            this.MenuItemSaveAs.Click += new System.EventHandler(this.MenuItemSaveAs_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.MenuItemLogOut_Click);
            // 
            // StripMenuItemExit
            // 
            this.StripMenuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("StripMenuItemExit.Image")));
            this.StripMenuItemExit.Name = "StripMenuItemExit";
            this.StripMenuItemExit.Size = new System.Drawing.Size(184, 26);
            this.StripMenuItemExit.Text = "Exit";
            this.StripMenuItemExit.Click += new System.EventHandler(this.StripMenuItemExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCut,
            this.MenuItemCopy,
            this.MenuItemPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // MenuItemCut
            // 
            this.MenuItemCut.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemCut.Image")));
            this.MenuItemCut.Name = "MenuItemCut";
            this.MenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuItemCut.Size = new System.Drawing.Size(184, 26);
            this.MenuItemCut.Text = "Cut";
            this.MenuItemCut.Click += new System.EventHandler(this.MenuItemCut_Click);
            // 
            // MenuItemCopy
            // 
            this.MenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemCopy.Image")));
            this.MenuItemCopy.Name = "MenuItemCopy";
            this.MenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuItemCopy.Size = new System.Drawing.Size(184, 26);
            this.MenuItemCopy.Text = "Copy";
            this.MenuItemCopy.Click += new System.EventHandler(this.MenuItemCopy_Click);
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemPaste.Image")));
            this.MenuItemPaste.Name = "MenuItemPaste";
            this.MenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuItemPaste.Size = new System.Drawing.Size(184, 26);
            this.MenuItemPaste.Text = "Paste";
            this.MenuItemPaste.Click += new System.EventHandler(this.MenuItemPaste_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemAbout.Image")));
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(111, 26);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBtnNew,
            this.TBtnOpen,
            this.TBtnSave,
            this.SaveAsTSBtn,
            this.toolStripSeparator1,
            this.TBtnBold,
            this.TBtnItalic,
            this.TBtnUnderLine,
            this.FontSizeBox,
            this.TBtnAbout,
            this.UserLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TBtnNew
            // 
            this.TBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("TBtnNew.Image")));
            this.TBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnNew.Name = "TBtnNew";
            this.TBtnNew.Size = new System.Drawing.Size(23, 22);
            this.TBtnNew.Text = "toolStripButton1";
            this.TBtnNew.ToolTipText = "New";
            this.TBtnNew.Click += new System.EventHandler(this.TBtnNew_Click);
            // 
            // TBtnOpen
            // 
            this.TBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("TBtnOpen.Image")));
            this.TBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnOpen.Name = "TBtnOpen";
            this.TBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.TBtnOpen.Text = "toolStripButton2";
            this.TBtnOpen.ToolTipText = "Open";
            this.TBtnOpen.Click += new System.EventHandler(this.TBtnOpen_Click);
            // 
            // TBtnSave
            // 
            this.TBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("TBtnSave.Image")));
            this.TBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnSave.Name = "TBtnSave";
            this.TBtnSave.Size = new System.Drawing.Size(23, 22);
            this.TBtnSave.ToolTipText = "Save";
            this.TBtnSave.Click += new System.EventHandler(this.TBtnSave_Click);
            // 
            // SaveAsTSBtn
            // 
            this.SaveAsTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsTSBtn.Image")));
            this.SaveAsTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsTSBtn.Name = "SaveAsTSBtn";
            this.SaveAsTSBtn.Size = new System.Drawing.Size(23, 22);
            this.SaveAsTSBtn.Text = "toolStripButton1";
            this.SaveAsTSBtn.ToolTipText = "SaveAs";
            this.SaveAsTSBtn.Click += new System.EventHandler(this.TBtnSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TBtnBold
            // 
            this.TBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnBold.Image = ((System.Drawing.Image)(resources.GetObject("TBtnBold.Image")));
            this.TBtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnBold.Name = "TBtnBold";
            this.TBtnBold.Size = new System.Drawing.Size(23, 22);
            this.TBtnBold.Text = "toolStripButton1";
            this.TBtnBold.ToolTipText = "Bold";
            this.TBtnBold.Click += new System.EventHandler(this.TBtnBold_Click);
            // 
            // TBtnItalic
            // 
            this.TBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("TBtnItalic.Image")));
            this.TBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnItalic.Name = "TBtnItalic";
            this.TBtnItalic.Size = new System.Drawing.Size(23, 22);
            this.TBtnItalic.Text = "toolStripButton2";
            this.TBtnItalic.ToolTipText = "Italic";
            this.TBtnItalic.Click += new System.EventHandler(this.TBtnItalic_Click);
            // 
            // TBtnUnderLine
            // 
            this.TBtnUnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnUnderLine.Image = ((System.Drawing.Image)(resources.GetObject("TBtnUnderLine.Image")));
            this.TBtnUnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnUnderLine.Name = "TBtnUnderLine";
            this.TBtnUnderLine.Size = new System.Drawing.Size(23, 22);
            this.TBtnUnderLine.Text = "toolStripButton1";
            this.TBtnUnderLine.ToolTipText = "Under Line";
            this.TBtnUnderLine.Click += new System.EventHandler(this.TBtnUnderLine_Click);
            // 
            // FontSizeBox
            // 
            this.FontSizeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.FontSizeBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FontSizeBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.FontSizeBox.Name = "FontSizeBox";
            this.FontSizeBox.Size = new System.Drawing.Size(92, 25);
            this.FontSizeBox.Text = "8";
            this.FontSizeBox.ToolTipText = "Fontsize";
            this.FontSizeBox.SelectedIndexChanged += new System.EventHandler(this.FontSizeBox_SelectedIndexChanged);
            // 
            // TBtnAbout
            // 
            this.TBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("TBtnAbout.Image")));
            this.TBtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBtnAbout.Name = "TBtnAbout";
            this.TBtnAbout.Size = new System.Drawing.Size(23, 22);
            this.TBtnAbout.Text = "toolStripButton1";
            this.TBtnAbout.ToolTipText = "About";
            this.TBtnAbout.Click += new System.EventHandler(this.TBtnAbout_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(68, 22);
            this.UserLabel.Text = "User Name:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBtnCut,
            this.LBtnCopy,
            this.LBtnPaste});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(25, 445);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip2_ItemClicked);
            // 
            // LBtnCut
            // 
            this.LBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LBtnCut.Image = ((System.Drawing.Image)(resources.GetObject("LBtnCut.Image")));
            this.LBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LBtnCut.Name = "LBtnCut";
            this.LBtnCut.Size = new System.Drawing.Size(22, 24);
            this.LBtnCut.Text = "toolStripButton1";
            this.LBtnCut.ToolTipText = "Cut";
            this.LBtnCut.Click += new System.EventHandler(this.LBtnCut_Click);
            // 
            // LBtnCopy
            // 
            this.LBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("LBtnCopy.Image")));
            this.LBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LBtnCopy.Name = "LBtnCopy";
            this.LBtnCopy.Size = new System.Drawing.Size(22, 24);
            this.LBtnCopy.Text = "toolStripButton2";
            this.LBtnCopy.ToolTipText = "Copy";
            this.LBtnCopy.Click += new System.EventHandler(this.LBtnCopy_Click);
            // 
            // LBtnPaste
            // 
            this.LBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LBtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("LBtnPaste.Image")));
            this.LBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LBtnPaste.Name = "LBtnPaste";
            this.LBtnPaste.Size = new System.Drawing.Size(22, 24);
            this.LBtnPaste.Text = "toolStripButton3";
            this.LBtnPaste.ToolTipText = "Paste";
            this.LBtnPaste.Click += new System.EventHandler(this.LBtnPaste_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(24, 51);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(620, 444);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 494);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TBtnNew;
        private System.Windows.Forms.ToolStripButton TBtnOpen;
        private System.Windows.Forms.ToolStripButton TBtnSave;
        private System.Windows.Forms.ToolStripButton SaveAsTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TBtnBold;
        private System.Windows.Forms.ToolStripButton TBtnItalic;
        private System.Windows.Forms.ToolStripButton TBtnUnderLine;
        private System.Windows.Forms.ToolStripComboBox FontSizeBox;
        private System.Windows.Forms.ToolStripButton TBtnAbout;
        private System.Windows.Forms.ToolStripLabel UserLabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton LBtnCut;
        private System.Windows.Forms.ToolStripButton LBtnCopy;
        private System.Windows.Forms.ToolStripButton LBtnPaste;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemExit;
    }
}