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
            this.label20 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtPost = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label24);
            this.splitContainer1.Panel1.Controls.Add(this.label23);
            this.splitContainer1.Panel1.Controls.Add(this.label22);
            this.splitContainer1.Panel1.Controls.Add(this.label21);
            this.splitContainer1.Panel1.Controls.Add(this.label20);
            this.splitContainer1.Panel1.Controls.Add(this.label19);
            this.splitContainer1.Panel1.Controls.Add(this.label18);
            this.splitContainer1.Panel1.Controls.Add(this.label17);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.txtPost);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(852, 282);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.ImageIndex = 19;
            this.label20.ImageList = this.imageList1;
            this.label20.Location = new System.Drawing.Point(192, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 40);
            this.label20.TabIndex = 19;
            this.label20.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "emoji (0).png");
            this.imageList1.Images.SetKeyName(1, "emoji (1).png");
            this.imageList1.Images.SetKeyName(2, "emoji (2).png");
            this.imageList1.Images.SetKeyName(3, "emoji (3).png");
            this.imageList1.Images.SetKeyName(4, "emoji (4).png");
            this.imageList1.Images.SetKeyName(5, "emoji (5).png");
            this.imageList1.Images.SetKeyName(6, "emoji (6).png");
            this.imageList1.Images.SetKeyName(7, "emoji (7).png");
            this.imageList1.Images.SetKeyName(8, "emoji (8).png");
            this.imageList1.Images.SetKeyName(9, "emoji (9).png");
            this.imageList1.Images.SetKeyName(10, "emoji (10).png");
            this.imageList1.Images.SetKeyName(11, "emoji (11).png");
            this.imageList1.Images.SetKeyName(12, "emoji (12).png");
            this.imageList1.Images.SetKeyName(13, "emoji (13).png");
            this.imageList1.Images.SetKeyName(14, "emoji (14).png");
            this.imageList1.Images.SetKeyName(15, "emoji (15).png");
            this.imageList1.Images.SetKeyName(16, "emoji (16).png");
            this.imageList1.Images.SetKeyName(17, "emoji (17).png");
            this.imageList1.Images.SetKeyName(18, "emoji (18).png");
            this.imageList1.Images.SetKeyName(19, "emoji (19).png");
            this.imageList1.Images.SetKeyName(20, "emoji (20).png");
            this.imageList1.Images.SetKeyName(21, "emoji (21).png");
            this.imageList1.Images.SetKeyName(22, "emoji (22).png");
            this.imageList1.Images.SetKeyName(23, "emoji (23).png");
            // 
            // label19
            // 
            this.label19.ImageIndex = 18;
            this.label19.ImageList = this.imageList1;
            this.label19.Location = new System.Drawing.Point(146, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 40);
            this.label19.TabIndex = 18;
            this.label19.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label18
            // 
            this.label18.ImageIndex = 17;
            this.label18.ImageList = this.imageList1;
            this.label18.Location = new System.Drawing.Point(100, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 40);
            this.label18.TabIndex = 17;
            this.label18.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label17
            // 
            this.label17.ImageIndex = 16;
            this.label17.ImageList = this.imageList1;
            this.label17.Location = new System.Drawing.Point(54, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 40);
            this.label17.TabIndex = 16;
            this.label17.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label16
            // 
            this.label16.ImageIndex = 15;
            this.label16.ImageList = this.imageList1;
            this.label16.Location = new System.Drawing.Point(192, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 40);
            this.label16.TabIndex = 15;
            this.label16.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label15
            // 
            this.label15.ImageIndex = 14;
            this.label15.ImageList = this.imageList1;
            this.label15.Location = new System.Drawing.Point(146, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 40);
            this.label15.TabIndex = 14;
            this.label15.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label14
            // 
            this.label14.ImageIndex = 13;
            this.label14.ImageList = this.imageList1;
            this.label14.Location = new System.Drawing.Point(100, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 40);
            this.label14.TabIndex = 13;
            this.label14.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label13
            // 
            this.label13.ImageIndex = 12;
            this.label13.ImageList = this.imageList1;
            this.label13.Location = new System.Drawing.Point(54, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 40);
            this.label13.TabIndex = 12;
            this.label13.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label12
            // 
            this.label12.ImageIndex = 11;
            this.label12.ImageList = this.imageList1;
            this.label12.Location = new System.Drawing.Point(192, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 40);
            this.label12.TabIndex = 11;
            this.label12.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label11
            // 
            this.label11.ImageIndex = 10;
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(146, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 40);
            this.label11.TabIndex = 10;
            this.label11.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label10
            // 
            this.label10.ImageIndex = 9;
            this.label10.ImageList = this.imageList1;
            this.label10.Location = new System.Drawing.Point(100, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 40);
            this.label10.TabIndex = 9;
            this.label10.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label9
            // 
            this.label9.ImageIndex = 8;
            this.label9.ImageList = this.imageList1;
            this.label9.Location = new System.Drawing.Point(54, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 40);
            this.label9.TabIndex = 8;
            this.label9.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label5
            // 
            this.label5.ImageIndex = 4;
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(54, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 40);
            this.label5.TabIndex = 7;
            this.label5.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label6
            // 
            this.label6.ImageIndex = 5;
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new System.Drawing.Point(100, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 40);
            this.label6.TabIndex = 6;
            this.label6.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label7
            // 
            this.label7.ImageIndex = 6;
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(146, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 40);
            this.label7.TabIndex = 5;
            this.label7.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label8
            // 
            this.label8.ImageIndex = 7;
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(192, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 40);
            this.label8.TabIndex = 4;
            this.label8.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label3
            // 
            this.label3.ImageIndex = 2;
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(146, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 40);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label4
            // 
            this.label4.ImageIndex = 3;
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(192, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 40);
            this.label4.TabIndex = 2;
            this.label4.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label2
            // 
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(100, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label1
            // 
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 40);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(563, 232);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtPost
            // 
            this.txtPost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPost.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPost.Location = new System.Drawing.Point(0, 232);
            this.txtPost.Multiline = false;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(563, 50);
            this.txtPost.TabIndex = 5;
            this.txtPost.Text = "";
            this.txtPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // label21
            // 
            this.label21.ImageIndex = 20;
            this.label21.ImageList = this.imageList1;
            this.label21.Location = new System.Drawing.Point(54, 222);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 40);
            this.label21.TabIndex = 20;
            this.label21.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label22
            // 
            this.label22.ImageIndex = 21;
            this.label22.ImageList = this.imageList1;
            this.label22.Location = new System.Drawing.Point(100, 222);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 40);
            this.label22.TabIndex = 21;
            this.label22.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label23
            // 
            this.label23.ImageIndex = 22;
            this.label23.ImageList = this.imageList1;
            this.label23.Location = new System.Drawing.Point(146, 222);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 40);
            this.label23.TabIndex = 22;
            this.label23.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // label24
            // 
            this.label24.ImageIndex = 23;
            this.label24.ImageList = this.imageList1;
            this.label24.Location = new System.Drawing.Point(192, 222);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 40);
            this.label24.TabIndex = 23;
            this.label24.Click += new System.EventHandler(this.emojilabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 282);
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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
    }
}

