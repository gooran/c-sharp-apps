namespace FileAndFolderList
{
    partial class FormFileExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileExplorer));
            this.listBoxDirectory = new System.Windows.Forms.ListBox();
            this.comboBoxDrive = new System.Windows.Forms.ComboBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNewFolder = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxDirectory
            // 
            this.listBoxDirectory.FormattingEnabled = true;
            this.listBoxDirectory.ItemHeight = 16;
            this.listBoxDirectory.Location = new System.Drawing.Point(8, 99);
            this.listBoxDirectory.Name = "listBoxDirectory";
            this.listBoxDirectory.Size = new System.Drawing.Size(305, 292);
            this.listBoxDirectory.TabIndex = 0;
            this.listBoxDirectory.DoubleClick += new System.EventHandler(this.listBoxDirectory_DoubleClick);
            // 
            // comboBoxDrive
            // 
            this.comboBoxDrive.FormattingEnabled = true;
            this.comboBoxDrive.Location = new System.Drawing.Point(192, 37);
            this.comboBoxDrive.Name = "comboBoxDrive";
            this.comboBoxDrive.Size = new System.Drawing.Size(55, 24);
            this.comboBoxDrive.TabIndex = 5;
            this.comboBoxDrive.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrive_SelectedIndexChanged);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(8, 9);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(31, 22);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "▲";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "فهرست پوشه ها و پرونده ها";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "انتخاب درایو";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 14);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "آدرس";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(44, 9);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(226, 23);
            this.textBoxAddress.TabIndex = 7;
            // 
            // buttonPaste
            // 
            this.buttonPaste.Image = global::FileAndFolderList.Properties.Resources.Paste_24x24;
            this.buttonPaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPaste.Location = new System.Drawing.Point(244, 398);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(67, 40);
            this.buttonPaste.TabIndex = 15;
            this.buttonPaste.Text = "درج";
            this.buttonPaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.Image = global::FileAndFolderList.Properties.Resources.Cut_24x24;
            this.buttonCut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCut.Location = new System.Drawing.Point(165, 398);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(67, 40);
            this.buttonCut.TabIndex = 14;
            this.buttonCut.Text = "انتقال";
            this.buttonCut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Image = global::FileAndFolderList.Properties.Resources.Copy_24x24;
            this.buttonCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCopy.Location = new System.Drawing.Point(86, 398);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(67, 40);
            this.buttonCopy.TabIndex = 13;
            this.buttonCopy.Text = "کپی";
            this.buttonCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(7, 398);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(67, 40);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.Location = new System.Drawing.Point(192, 67);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(121, 26);
            this.buttonNewFolder.TabIndex = 16;
            this.buttonNewFolder.Text = "پوشه جدید";
            this.buttonNewFolder.UseVisualStyleBackColor = true;
            this.buttonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(105, 37);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(78, 26);
            this.buttonRename.TabIndex = 17;
            this.buttonRename.Text = "تغییر نام";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(7, 39);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(92, 23);
            this.textBoxNewName.TabIndex = 18;
            // 
            // FormFileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 447);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonNewFolder);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.comboBoxDrive);
            this.Controls.Add(this.listBoxDirectory);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFileExplorer";
            this.Text = "My File Explorer";
            this.Load += new System.EventHandler(this.FormFileExplorer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDirectory;
        private System.Windows.Forms.ComboBox comboBoxDrive;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonNewFolder;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.TextBox textBoxNewName;

    }
}

