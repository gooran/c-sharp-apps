namespace PublicChat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemChangeName = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangeRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtPost = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemChangeName,
            this.ToolStripMenuItemChangeRoom,
            this.ToolStripMenuItemNewRoom});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 76);
            // 
            // ToolStripMenuItemChangeName
            // 
            this.ToolStripMenuItemChangeName.Name = "ToolStripMenuItemChangeName";
            this.ToolStripMenuItemChangeName.Size = new System.Drawing.Size(136, 24);
            this.ToolStripMenuItemChangeName.Text = "تغییر نام";
            this.ToolStripMenuItemChangeName.Click += new System.EventHandler(this.ToolStripMenuItemChangeName_Click);
            // 
            // ToolStripMenuItemChangeRoom
            // 
            this.ToolStripMenuItemChangeRoom.Name = "ToolStripMenuItemChangeRoom";
            this.ToolStripMenuItemChangeRoom.Size = new System.Drawing.Size(136, 24);
            this.ToolStripMenuItemChangeRoom.Text = "تغییر اتاق";
            this.ToolStripMenuItemChangeRoom.Click += new System.EventHandler(this.ToolStripMenuItemChangeRoom_Click);
            // 
            // ToolStripMenuItemNewRoom
            // 
            this.ToolStripMenuItemNewRoom.Name = "ToolStripMenuItemNewRoom";
            this.ToolStripMenuItemNewRoom.Size = new System.Drawing.Size(136, 24);
            this.ToolStripMenuItemNewRoom.Text = "اتاق جدید";
            this.ToolStripMenuItemNewRoom.Click += new System.EventHandler(this.ToolStripMenuItemNewRoom_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "PublicChat.txt";
            this.openFileDialog.Filter = "Text Documents|*.txt|All Files|*.*";
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.txtPost);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(852, 555);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 549);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(563, 505);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtPost
            // 
            this.txtPost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPost.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPost.Location = new System.Drawing.Point(0, 505);
            this.txtPost.Multiline = false;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(563, 50);
            this.txtPost.TabIndex = 5;
            this.txtPost.Text = "";
            this.txtPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "D83DDE00.png");
            this.imageList1.Images.SetKeyName(1, "D83DDE0A.png");
            this.imageList1.Images.SetKeyName(2, "D83DDE0B.png");
            this.imageList1.Images.SetKeyName(3, "D83DDE0C.png");
            this.imageList1.Images.SetKeyName(4, "D83DDE0D.png");
            this.imageList1.Images.SetKeyName(5, "D83DDE0E.png");
            this.imageList1.Images.SetKeyName(6, "D83DDE0F.png");
            this.imageList1.Images.SetKeyName(7, "D83DDE01.png");
            this.imageList1.Images.SetKeyName(8, "D83DDE1A.png");
            this.imageList1.Images.SetKeyName(9, "D83DDE1B.png");
            this.imageList1.Images.SetKeyName(10, "D83DDE1C.png");
            this.imageList1.Images.SetKeyName(11, "D83DDE1D.png");
            this.imageList1.Images.SetKeyName(12, "D83DDE1E.png");
            this.imageList1.Images.SetKeyName(13, "D83DDE1F.png");
            this.imageList1.Images.SetKeyName(14, "D83DDE02.png");
            this.imageList1.Images.SetKeyName(15, "D83DDE2A.png");
            this.imageList1.Images.SetKeyName(16, "D83DDE2B.png");
            this.imageList1.Images.SetKeyName(17, "D83DDE2C.png");
            this.imageList1.Images.SetKeyName(18, "D83DDE2D.png");
            this.imageList1.Images.SetKeyName(19, "D83DDE2E.png");
            this.imageList1.Images.SetKeyName(20, "D83DDE2F.png");
            this.imageList1.Images.SetKeyName(21, "D83DDE03.png");
            this.imageList1.Images.SetKeyName(22, "D83DDE04.png");
            this.imageList1.Images.SetKeyName(23, "D83DDE05.png");
            this.imageList1.Images.SetKeyName(24, "D83DDE06.png");
            this.imageList1.Images.SetKeyName(25, "D83DDE07.png");
            this.imageList1.Images.SetKeyName(26, "D83DDE09.png");
            this.imageList1.Images.SetKeyName(27, "D83DDE10.png");
            this.imageList1.Images.SetKeyName(28, "D83DDE11.png");
            this.imageList1.Images.SetKeyName(29, "D83DDE12.png");
            this.imageList1.Images.SetKeyName(30, "D83DDE13.png");
            this.imageList1.Images.SetKeyName(31, "D83DDE14.png");
            this.imageList1.Images.SetKeyName(32, "D83DDE15.png");
            this.imageList1.Images.SetKeyName(33, "D83DDE16.png");
            this.imageList1.Images.SetKeyName(34, "D83DDE17.png");
            this.imageList1.Images.SetKeyName(35, "D83DDE18.png");
            this.imageList1.Images.SetKeyName(36, "D83DDE19.png");
            this.imageList1.Images.SetKeyName(37, "D83DDE20.png");
            this.imageList1.Images.SetKeyName(38, "D83DDE21.png");
            this.imageList1.Images.SetKeyName(39, "D83DDE22.png");
            this.imageList1.Images.SetKeyName(40, "D83DDE23.png");
            this.imageList1.Images.SetKeyName(41, "D83DDE24.png");
            this.imageList1.Images.SetKeyName(42, "D83DDE25.png");
            this.imageList1.Images.SetKeyName(43, "D83DDE26.png");
            this.imageList1.Images.SetKeyName(44, "D83DDE27.png");
            this.imageList1.Images.SetKeyName(45, "D83DDE28.png");
            this.imageList1.Images.SetKeyName(46, "D83DDE29.png");
            this.imageList1.Images.SetKeyName(47, "D83DDE30.png");
            this.imageList1.Images.SetKeyName(48, "D83DDE31.png");
            this.imageList1.Images.SetKeyName(49, "D83DDE32.png");
            this.imageList1.Images.SetKeyName(50, "D83DDE33.png");
            this.imageList1.Images.SetKeyName(51, "D83DDE34.png");
            this.imageList1.Images.SetKeyName(52, "D83DDE35.png");
            this.imageList1.Images.SetKeyName(53, "D83DDE36.png");
            this.imageList1.Images.SetKeyName(54, "D83DDE37.png");
            this.imageList1.Images.SetKeyName(55, "D83CDF3A.png");
            this.imageList1.Images.SetKeyName(56, "D83CDF3B.png");
            this.imageList1.Images.SetKeyName(57, "D83CDF3C.png");
            this.imageList1.Images.SetKeyName(58, "D83CDF37.png");
            this.imageList1.Images.SetKeyName(59, "D83CDF38.png");
            this.imageList1.Images.SetKeyName(60, "D83CDF39.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 555);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اتاق گفتگو";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeName;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeRoom;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewRoom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox txtPost;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

