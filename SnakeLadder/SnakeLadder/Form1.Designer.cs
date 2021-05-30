namespace SnakeLadder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.listBoxGameLog = new System.Windows.Forms.ListBox();
            this.buttonThrowDice = new System.Windows.Forms.Button();
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDice = new System.Windows.Forms.Label();
            this.pictureBoxPlayground = new System.Windows.Forms.PictureBox();
            this.checkBoxAutoPlay = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayground)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxPlayground);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBoxAutoPlay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelDice);
            this.panel2.Controls.Add(this.listBoxGameLog);
            this.panel2.Controls.Add(this.buttonThrowDice);
            this.panel2.Location = new System.Drawing.Point(727, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 700);
            this.panel2.TabIndex = 1;
            // 
            // imageListDice
            // 
            this.imageListDice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDice.ImageStream")));
            this.imageListDice.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDice.Images.SetKeyName(0, "dice-1.png");
            this.imageListDice.Images.SetKeyName(1, "dice-2.png");
            this.imageListDice.Images.SetKeyName(2, "dice-3.png");
            this.imageListDice.Images.SetKeyName(3, "dice-4.png");
            this.imageListDice.Images.SetKeyName(4, "dice-5.png");
            this.imageListDice.Images.SetKeyName(5, "dice-6.png");
            // 
            // listBoxGameLog
            // 
            this.listBoxGameLog.FormattingEnabled = true;
            this.listBoxGameLog.ItemHeight = 16;
            this.listBoxGameLog.Location = new System.Drawing.Point(26, 428);
            this.listBoxGameLog.Name = "listBoxGameLog";
            this.listBoxGameLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxGameLog.Size = new System.Drawing.Size(191, 244);
            this.listBoxGameLog.TabIndex = 3;
            // 
            // buttonThrowDice
            // 
            this.buttonThrowDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThrowDice.ImageIndex = 0;
            this.buttonThrowDice.Location = new System.Drawing.Point(23, 171);
            this.buttonThrowDice.Name = "buttonThrowDice";
            this.buttonThrowDice.Size = new System.Drawing.Size(191, 43);
            this.buttonThrowDice.TabIndex = 2;
            this.buttonThrowDice.Text = "بازیکن 1";
            this.buttonThrowDice.UseVisualStyleBackColor = true;
            this.buttonThrowDice.Click += new System.EventHandler(this.buttonThrowDice_Click);
            // 
            // timerAnimate
            // 
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Image = global::SnakeLadder.Properties.Resources.mohre_Yellow_copy;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(191, 63);
            this.label2.TabIndex = 7;
            this.label2.Text = "بازیکن 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::SnakeLadder.Properties.Resources.mohre_Green_copy;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(191, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "بازیکن 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDice
            // 
            this.labelDice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDice.Location = new System.Drawing.Point(23, 256);
            this.labelDice.Name = "labelDice";
            this.labelDice.Size = new System.Drawing.Size(191, 153);
            this.labelDice.TabIndex = 5;
            // 
            // pictureBoxPlayground
            // 
            this.pictureBoxPlayground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPlayground.Image = global::SnakeLadder.Properties.Resources.snakes_and_ladders;
            this.pictureBoxPlayground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPlayground.Name = "pictureBoxPlayground";
            this.pictureBoxPlayground.Size = new System.Drawing.Size(698, 698);
            this.pictureBoxPlayground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayground.TabIndex = 0;
            this.pictureBoxPlayground.TabStop = false;
            // 
            // checkBoxAutoPlay
            // 
            this.checkBoxAutoPlay.Location = new System.Drawing.Point(26, 221);
            this.checkBoxAutoPlay.Name = "checkBoxAutoPlay";
            this.checkBoxAutoPlay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAutoPlay.Size = new System.Drawing.Size(185, 24);
            this.checkBoxAutoPlay.TabIndex = 8;
            this.checkBoxAutoPlay.Text = "بازی خودکار";
            this.checkBoxAutoPlay.UseVisualStyleBackColor = true;
            this.checkBoxAutoPlay.CheckedChanged += new System.EventHandler(this.checkBoxAutoPlay_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مار و پله";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxPlayground;
        private System.Windows.Forms.ListBox listBoxGameLog;
        private System.Windows.Forms.Button buttonThrowDice;
        private System.Windows.Forms.ImageList imageListDice;
        private System.Windows.Forms.Label labelDice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerAnimate;
        private System.Windows.Forms.CheckBox checkBoxAutoPlay;
    }
}

