namespace ATMSimulator
{
    partial class FormATM
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
            this.pictureBoxScreen = new System.Windows.Forms.PictureBox();
            this.buttonR1 = new System.Windows.Forms.Button();
            this.buttonR2 = new System.Windows.Forms.Button();
            this.buttonR3 = new System.Windows.Forms.Button();
            this.buttonR4 = new System.Windows.Forms.Button();
            this.buttonL4 = new System.Windows.Forms.Button();
            this.buttonL3 = new System.Windows.Forms.Button();
            this.buttonL2 = new System.Windows.Forms.Button();
            this.buttonL1 = new System.Windows.Forms.Button();
            this.buttonInsertCard = new System.Windows.Forms.Button();
            this.buttonGetCash = new System.Windows.Forms.Button();
            this.buttonGetCard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxScreen
            // 
            this.pictureBoxScreen.Image = global::ATMSimulator.Properties.Resources.Slide2;
            this.pictureBoxScreen.Location = new System.Drawing.Point(68, 12);
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.Size = new System.Drawing.Size(426, 240);
            this.pictureBoxScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScreen.TabIndex = 0;
            this.pictureBoxScreen.TabStop = false;
            // 
            // buttonR1
            // 
            this.buttonR1.Location = new System.Drawing.Point(500, 85);
            this.buttonR1.Name = "buttonR1";
            this.buttonR1.Size = new System.Drawing.Size(56, 33);
            this.buttonR1.TabIndex = 4;
            this.buttonR1.UseVisualStyleBackColor = true;
            // 
            // buttonR2
            // 
            this.buttonR2.Location = new System.Drawing.Point(500, 129);
            this.buttonR2.Name = "buttonR2";
            this.buttonR2.Size = new System.Drawing.Size(56, 33);
            this.buttonR2.TabIndex = 5;
            this.buttonR2.UseVisualStyleBackColor = true;
            // 
            // buttonR3
            // 
            this.buttonR3.Location = new System.Drawing.Point(500, 173);
            this.buttonR3.Name = "buttonR3";
            this.buttonR3.Size = new System.Drawing.Size(56, 33);
            this.buttonR3.TabIndex = 6;
            this.buttonR3.UseVisualStyleBackColor = true;
            // 
            // buttonR4
            // 
            this.buttonR4.Location = new System.Drawing.Point(500, 217);
            this.buttonR4.Name = "buttonR4";
            this.buttonR4.Size = new System.Drawing.Size(56, 33);
            this.buttonR4.TabIndex = 7;
            this.buttonR4.UseVisualStyleBackColor = true;
            this.buttonR4.Click += new System.EventHandler(this.buttonR4_Click);
            // 
            // buttonL4
            // 
            this.buttonL4.Location = new System.Drawing.Point(6, 217);
            this.buttonL4.Name = "buttonL4";
            this.buttonL4.Size = new System.Drawing.Size(56, 33);
            this.buttonL4.TabIndex = 11;
            this.buttonL4.UseVisualStyleBackColor = true;
            // 
            // buttonL3
            // 
            this.buttonL3.Location = new System.Drawing.Point(6, 173);
            this.buttonL3.Name = "buttonL3";
            this.buttonL3.Size = new System.Drawing.Size(56, 33);
            this.buttonL3.TabIndex = 10;
            this.buttonL3.UseVisualStyleBackColor = true;
            // 
            // buttonL2
            // 
            this.buttonL2.Location = new System.Drawing.Point(6, 129);
            this.buttonL2.Name = "buttonL2";
            this.buttonL2.Size = new System.Drawing.Size(56, 33);
            this.buttonL2.TabIndex = 9;
            this.buttonL2.UseVisualStyleBackColor = true;
            // 
            // buttonL1
            // 
            this.buttonL1.Location = new System.Drawing.Point(6, 85);
            this.buttonL1.Name = "buttonL1";
            this.buttonL1.Size = new System.Drawing.Size(56, 33);
            this.buttonL1.TabIndex = 8;
            this.buttonL1.UseVisualStyleBackColor = true;
            // 
            // buttonInsertCard
            // 
            this.buttonInsertCard.Location = new System.Drawing.Point(418, 258);
            this.buttonInsertCard.Name = "buttonInsertCard";
            this.buttonInsertCard.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertCard.TabIndex = 1;
            this.buttonInsertCard.Text = "ورود کارت";
            this.buttonInsertCard.UseVisualStyleBackColor = true;
            this.buttonInsertCard.Click += new System.EventHandler(this.buttonInsertCard_Click);
            // 
            // buttonGetCash
            // 
            this.buttonGetCash.Location = new System.Drawing.Point(243, 258);
            this.buttonGetCash.Name = "buttonGetCash";
            this.buttonGetCash.Size = new System.Drawing.Size(75, 23);
            this.buttonGetCash.TabIndex = 2;
            this.buttonGetCash.Text = "دریافت پول";
            this.buttonGetCash.UseVisualStyleBackColor = true;
            // 
            // buttonGetCard
            // 
            this.buttonGetCard.Location = new System.Drawing.Point(68, 258);
            this.buttonGetCard.Name = "buttonGetCard";
            this.buttonGetCard.Size = new System.Drawing.Size(75, 23);
            this.buttonGetCard.TabIndex = 3;
            this.buttonGetCard.Text = "دریافت کارت";
            this.buttonGetCard.UseVisualStyleBackColor = true;
            this.buttonGetCard.Click += new System.EventHandler(this.buttonGetCard_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.buttonEnter);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Location = new System.Drawing.Point(68, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 143);
            this.panel1.TabIndex = 28;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(289, 103);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 23);
            this.button21.TabIndex = 15;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(205, 103);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 23);
            this.button22.TabIndex = 27;
            this.button22.Text = "#";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(143, 103);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 23);
            this.button23.TabIndex = 26;
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(81, 103);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(56, 23);
            this.button24.TabIndex = 25;
            this.button24.Text = "*";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEnter.Location = new System.Drawing.Point(289, 74);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(56, 23);
            this.buttonEnter.TabIndex = 14;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(205, 74);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 23);
            this.button18.TabIndex = 24;
            this.button18.Text = "9";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(143, 74);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 23);
            this.button19.TabIndex = 23;
            this.button19.Text = "8";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(81, 74);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(56, 23);
            this.button20.TabIndex = 22;
            this.button20.Text = "7";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClear.Location = new System.Drawing.Point(289, 45);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(205, 45);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 23);
            this.button14.TabIndex = 21;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(143, 45);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 23);
            this.button15.TabIndex = 20;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(81, 45);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 23);
            this.button16.TabIndex = 19;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonCancel.Location = new System.Drawing.Point(289, 16);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(205, 16);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(143, 16);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(81, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(195, 138);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(171, 29);
            this.textBoxPassword.TabIndex = 29;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGetCard);
            this.Controls.Add(this.buttonGetCash);
            this.Controls.Add(this.buttonInsertCard);
            this.Controls.Add(this.buttonL4);
            this.Controls.Add(this.buttonL3);
            this.Controls.Add(this.buttonL2);
            this.Controls.Add(this.buttonL1);
            this.Controls.Add(this.buttonR4);
            this.Controls.Add(this.buttonR3);
            this.Controls.Add(this.buttonR2);
            this.Controls.Add(this.buttonR1);
            this.Controls.Add(this.pictureBoxScreen);
            this.Name = "FormATM";
            this.Text = "شبیه ساز خودپرداز";
            this.Load += new System.EventHandler(this.FormATM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScreen;
        private System.Windows.Forms.Button buttonR1;
        private System.Windows.Forms.Button buttonR2;
        private System.Windows.Forms.Button buttonR3;
        private System.Windows.Forms.Button buttonR4;
        private System.Windows.Forms.Button buttonL4;
        private System.Windows.Forms.Button buttonL3;
        private System.Windows.Forms.Button buttonL2;
        private System.Windows.Forms.Button buttonL1;
        private System.Windows.Forms.Button buttonInsertCard;
        private System.Windows.Forms.Button buttonGetCash;
        private System.Windows.Forms.Button buttonGetCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

