using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileAndFolderList
{
    enum OperationType
    {
        Cancel, Copy, Cut
    }
    public partial class FormFileExplorer : Form
    {
        string currentDir = "";
        string sourcePath;
        OperationType operation = OperationType.Cancel;

        public FormFileExplorer()
        {
            InitializeComponent();
        }

        private void FormFileExplorer_Load(object sender, EventArgs e)
        {
            comboBoxDrive.Items.AddRange(Directory.GetLogicalDrives());
            comboBoxDrive.SelectedIndex = 0;
        }

        private void comboBoxDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDirectory(comboBoxDrive.Text);
        }

        private void showDirectory(string directory)
        {
            try
            {
                string[] dires = Directory.GetDirectories(directory);
                string[] files = Directory.GetFiles(directory);
                currentDir = textBoxAddress.Text = directory;
                listBoxDirectory.Items.Clear();
                foreach (string dir in dires)
                {
                    listBoxDirectory.Items.Add(Path.GetFileName(dir));
                }
                foreach (string file in files)
                {
                    listBoxDirectory.Items.Add(Path.GetFileName(file));
                }
            }
            catch
            {
            }
        }

        private void listBoxDirectory_DoubleClick(object sender, EventArgs e)
        {
            string newPath = Path.Combine(textBoxAddress.Text, listBoxDirectory.Text);
            if (Directory.Exists(newPath))
                showDirectory(newPath);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            try
            {
                string newPath = Directory.GetParent(textBoxAddress.Text).FullName;
                showDirectory(newPath);
            }
            catch
            {
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید؟", listBoxDirectory.Text + " حذف ", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string newPath = Path.Combine(textBoxAddress.Text, listBoxDirectory.Text);
                if (Directory.Exists(newPath))
                    Directory.Delete(newPath, true);
                if (File.Exists(newPath))
                    File.Delete(newPath);
                showDirectory(currentDir);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            sourcePath = Path.Combine(textBoxAddress.Text, listBoxDirectory.Text) + "\\";
            operation = OperationType.Copy;
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            sourcePath = Path.Combine(textBoxAddress.Text, listBoxDirectory.Text) + "\\";
            operation = OperationType.Cut;
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            string destPath = textBoxAddress.Text + "\\";
            switch (operation)
            {
                case OperationType.Cut:
                    try
                    {
                        if (Directory.Exists(sourcePath))
                            Directory.Move(sourcePath, destPath);
                        if (File.Exists(sourcePath))
                            File.Move(sourcePath, destPath);
                    }
                    catch
                    {
                        MessageBox.Show("انتقال امکان پذیر نیست", "خطا",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                case OperationType.Copy:
                    try
                    {
                        if (Directory.Exists(sourcePath))
                        {
                            //ایجاد تمام پوشه ها و زیر پوشه ها
                            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                                SearchOption.AllDirectories))
                                Directory.CreateDirectory(dirPath.Replace(sourcePath, destPath));

                            //نسخه برداری از تمام پرونده ها و بازنویسی پرونده های هم نام
                            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                                SearchOption.AllDirectories))
                                File.Copy(newPath, newPath.Replace(sourcePath, destPath), true);
                        }
                        if (File.Exists(sourcePath))
                            File.Copy(sourcePath, destPath);
                    }
                    catch
                    {
                        MessageBox.Show("کپی امکان پذیر نیست", "خطا",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
            }
            showDirectory(currentDir);
        }

        private void buttonNewFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(currentDir, "New folder"));
            showDirectory(currentDir);
        }

private void buttonRename_Click(object sender, EventArgs e)
{
    try
    {
        string name = Path.Combine(textBoxAddress.Text, listBoxDirectory.Text);
        string newName = Path.Combine(textBoxAddress.Text, textBoxNewName.Text);
        if (Directory.Exists(name))
            Directory.Move(name, newName);
        if (File.Exists(name))
            File.Move(name, newName);
        showDirectory(currentDir);
    }
    catch
    {
        MessageBox.Show("تغییر نام امکان پذیر نیست", "خطا",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }
}
    }
}
