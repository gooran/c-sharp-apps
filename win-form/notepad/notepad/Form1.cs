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

namespace notepad
{
    public partial class mainForm : Form
    {
        string documentFilePath = "";
        bool saveStatus = true;
        public mainForm()
        {
            InitializeComponent();
        }

        private void SaveAsAction()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, mainDocument.Text);
                    documentFilePath = saveFileDialog.FileName;
                    saveStatus = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void SaveAction()
        {
            if (documentFilePath == "")
            {
                SaveAsAction();
            }
            else
            {
                File.WriteAllText(documentFilePath, mainDocument.Text);
                saveStatus = true;
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAction();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsAction();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saveStatus)
            {
                DialogResult result = MessageBox.Show(this,
                    "Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveAction();
                }

                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                documentFilePath = openFileDialog.FileName;
                mainDocument.Text = File.ReadAllText(documentFilePath);
                saveStatus = true;
            }
        }

        private void mainDocument_TextChanged(object sender, EventArgs e)
        {
            saveStatus = false;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saveStatus)
            {
                DialogResult result = MessageBox.Show(this, "Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveAction();
                        e.Cancel = !saveStatus;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDocument.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDocument.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDocument.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;

            fontDialog.Font = mainDocument.Font;
            fontDialog.Color = mainDocument.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                mainDocument.Font = fontDialog.Font;
                mainDocument.ForeColor = fontDialog.Color;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDocument.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDocument.Clear();
            documentFilePath = "";
        }
    }
}
