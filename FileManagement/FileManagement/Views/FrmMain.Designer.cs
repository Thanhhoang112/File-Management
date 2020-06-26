namespace FileManagement.Views
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolDeleteFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tittleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstFolder = new System.Windows.Forms.ListView();
            this.iconlist = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstFile = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtNote = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newfilebt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addfolderbt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Unreadbt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbSpace = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btSearch = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.homeToolStrip,
            this.viewToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolNew,
            this.ToolSave,
            this.ToolExit});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(46, 24);
            this.fileToolStrip.Text = "File";
            // 
            // ToolNew
            // 
            this.ToolNew.Image = global::FileManagement.Properties.Resources.picAddFile;
            this.ToolNew.Name = "ToolNew";
            this.ToolNew.Size = new System.Drawing.Size(126, 26);
            this.ToolNew.Text = "New ";
            this.ToolNew.Click += new System.EventHandler(this.ToolNew_Click);
            // 
            // ToolSave
            // 
            this.ToolSave.Image = global::FileManagement.Properties.Resources.saveicon;
            this.ToolSave.Name = "ToolSave";
            this.ToolSave.Size = new System.Drawing.Size(126, 26);
            this.ToolSave.Text = "Save";
            this.ToolSave.Click += new System.EventHandler(this.ToolSave_Click);
            // 
            // ToolExit
            // 
            this.ToolExit.Image = global::FileManagement.Properties.Resources.Exiticon;
            this.ToolExit.Name = "ToolExit";
            this.ToolExit.Size = new System.Drawing.Size(126, 26);
            this.ToolExit.Text = "Exit";
            this.ToolExit.Click += new System.EventHandler(this.ToolExit_Click);
            // 
            // homeToolStrip
            // 
            this.homeToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolNewFolder,
            this.ToolDelete});
            this.homeToolStrip.Name = "homeToolStrip";
            this.homeToolStrip.Size = new System.Drawing.Size(64, 24);
            this.homeToolStrip.Text = "Home";
            // 
            // ToolNewFolder
            // 
            this.ToolNewFolder.Image = global::FileManagement.Properties.Resources.NewFolderIcon;
            this.ToolNewFolder.Name = "ToolNewFolder";
            this.ToolNewFolder.Size = new System.Drawing.Size(168, 26);
            this.ToolNewFolder.Text = "New Folder";
            this.ToolNewFolder.Click += new System.EventHandler(this.ToolNewFolder_Click);
            // 
            // ToolDelete
            // 
            this.ToolDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolDeleteBook,
            this.ToolDeleteFolder});
            this.ToolDelete.Image = global::FileManagement.Properties.Resources.deleteicon;
            this.ToolDelete.Name = "ToolDelete";
            this.ToolDelete.Size = new System.Drawing.Size(168, 26);
            this.ToolDelete.Text = "Delete";
            // 
            // ToolDeleteBook
            // 
            this.ToolDeleteBook.Name = "ToolDeleteBook";
            this.ToolDeleteBook.Size = new System.Drawing.Size(182, 26);
            this.ToolDeleteBook.Text = "Delete Book";
            this.ToolDeleteBook.Click += new System.EventHandler(this.ToolDeleteBook_Click);
            // 
            // ToolDeleteFolder
            // 
            this.ToolDeleteFolder.Name = "ToolDeleteFolder";
            this.ToolDeleteFolder.Size = new System.Drawing.Size(182, 26);
            this.ToolDeleteFolder.Text = "Delete Folder";
            this.ToolDeleteFolder.Click += new System.EventHandler(this.ToolDeleteFolder_Click);
            // 
            // viewToolStrip
            // 
            this.viewToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.listToolStripMenuItem,
            this.tittleToolStripMenuItem});
            this.viewToolStrip.Name = "viewToolStrip";
            this.viewToolStrip.Size = new System.Drawing.Size(55, 24);
            this.viewToolStrip.Text = "View";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // tittleToolStripMenuItem
            // 
            this.tittleToolStripMenuItem.Name = "tittleToolStripMenuItem";
            this.tittleToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.tittleToolStripMenuItem.Text = "Tile";
            this.tittleToolStripMenuItem.Click += new System.EventHandler(this.tittleToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1264, 567);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1264, 594);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 567);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstFolder
            // 
            this.lstFolder.BackColor = System.Drawing.Color.Ivory;
            this.lstFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFolder.HideSelection = false;
            this.lstFolder.LargeImageList = this.iconlist;
            this.lstFolder.Location = new System.Drawing.Point(0, 0);
            this.lstFolder.Margin = new System.Windows.Forms.Padding(4);
            this.lstFolder.Name = "lstFolder";
            this.lstFolder.Size = new System.Drawing.Size(313, 567);
            this.lstFolder.SmallImageList = this.iconlist;
            this.lstFolder.TabIndex = 0;
            this.lstFolder.UseCompatibleStateImageBehavior = false;
            this.lstFolder.View = System.Windows.Forms.View.List;
            this.lstFolder.Click += new System.EventHandler(this.lstFolder_Click);
            this.lstFolder.DoubleClick += new System.EventHandler(this.lstFolder_DoubleClick);
            this.lstFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFolder_KeyDown);
            // 
            // iconlist
            // 
            this.iconlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconlist.ImageStream")));
            this.iconlist.TransparentColor = System.Drawing.Color.Transparent;
            this.iconlist.Images.SetKeyName(0, "folder.PNG");
            this.iconlist.Images.SetKeyName(1, "word.PNG");
            this.iconlist.Images.SetKeyName(2, "pdf.PNG");
            this.iconlist.Images.SetKeyName(3, "txt.PNG");
            this.iconlist.Images.SetKeyName(4, "AllBook icon.PNG");
            this.iconlist.Images.SetKeyName(5, "Recent icon.png");
            this.iconlist.Images.SetKeyName(6, "unread.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstFile);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(946, 567);
            this.splitContainer2.SplitterDistance = 329;
            this.splitContainer2.TabIndex = 0;
            // 
            // lstFile
            // 
            this.lstFile.BackColor = System.Drawing.Color.Ivory;
            this.lstFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFile.HideSelection = false;
            this.lstFile.LargeImageList = this.imageList1;
            this.lstFile.Location = new System.Drawing.Point(0, 0);
            this.lstFile.Margin = new System.Windows.Forms.Padding(4);
            this.lstFile.Name = "lstFile";
            this.lstFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstFile.Size = new System.Drawing.Size(946, 329);
            this.lstFile.SmallImageList = this.iconlist;
            this.lstFile.TabIndex = 0;
            this.lstFile.UseCompatibleStateImageBehavior = false;
            this.lstFile.Click += new System.EventHandler(this.lstFile_Click);
            this.lstFile.DoubleClick += new System.EventHandler(this.lstFile_DoubleClick);
            this.lstFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFile_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.PNG");
            this.imageList1.Images.SetKeyName(1, "word.PNG");
            this.imageList1.Images.SetKeyName(2, "pdf.PNG");
            this.imageList1.Images.SetKeyName(3, "txt.PNG");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtNote);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(946, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note:";
            // 
            // rtNote
            // 
            this.rtNote.BackColor = System.Drawing.Color.Ivory;
            this.rtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtNote.Location = new System.Drawing.Point(3, 17);
            this.rtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtNote.Name = "rtNote";
            this.rtNote.Size = new System.Drawing.Size(940, 215);
            this.rtNote.TabIndex = 0;
            this.rtNote.Text = "";
            this.rtNote.Enter += new System.EventHandler(this.RtNote_Enter);
            this.rtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtNote_KeyDown);
            this.rtNote.Leave += new System.EventHandler(this.RtNote_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newfilebt,
            this.toolStripSeparator1,
            this.addfolderbt,
            this.toolStripSeparator2,
            this.Unreadbt,
            this.toolStripSeparator3,
            this.lbSpace,
            this.txtSearch,
            this.btSearch});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // newfilebt
            // 
            this.newfilebt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newfilebt.Image = ((System.Drawing.Image)(resources.GetObject("newfilebt.Image")));
            this.newfilebt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newfilebt.Name = "newfilebt";
            this.newfilebt.Size = new System.Drawing.Size(29, 24);
            this.newfilebt.Text = "New File";
            this.newfilebt.Click += new System.EventHandler(this.newfilebt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // addfolderbt
            // 
            this.addfolderbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addfolderbt.Image = ((System.Drawing.Image)(resources.GetObject("addfolderbt.Image")));
            this.addfolderbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addfolderbt.Name = "addfolderbt";
            this.addfolderbt.Size = new System.Drawing.Size(29, 24);
            this.addfolderbt.Text = "Add New Folder";
            this.addfolderbt.Click += new System.EventHandler(this.addfolderbt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Unreadbt
            // 
            this.Unreadbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Unreadbt.Image = global::FileManagement.Properties.Resources.Unread_iconpng;
            this.Unreadbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Unreadbt.Name = "Unreadbt";
            this.Unreadbt.Size = new System.Drawing.Size(29, 24);
            this.Unreadbt.Text = "Unread";
            this.Unreadbt.Click += new System.EventHandler(this.unreadbt_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // lbSpace
            // 
            this.lbSpace.ActiveLinkColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbSpace.AutoSize = false;
            this.lbSpace.Name = "lbSpace";
            this.lbSpace.Size = new System.Drawing.Size(300, 22);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.Text = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btSearch
            // 
            this.btSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSearch.Image = ((System.Drawing.Image)(resources.GetObject("btSearch.Image")));
            this.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(29, 24);
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 622);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolNew;
        private System.Windows.Forms.ToolStripMenuItem homeToolStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newfilebt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstFolder;
        private System.Windows.Forms.ListView lstFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btSearch;
        private System.Windows.Forms.ToolStripLabel lbSpace;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtNote;
        private System.Windows.Forms.ImageList iconlist;
        private System.Windows.Forms.ToolStripButton addfolderbt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem ToolExit;
        private System.Windows.Forms.ToolStripMenuItem ToolDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem ToolDeleteFolder;
        private System.Windows.Forms.ToolStripMenuItem ToolSave;
        private System.Windows.Forms.ToolStripMenuItem ToolNewFolder;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tittleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Unreadbt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

