using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLatexEditor
{
    enum LeftOrRight
    {
        Left, Right
    }
    public partial class Form1 : Form
    {
        string documentFilePathLeft = "";
        string documentFilePathRight = "";
        bool saveStatusLeft = true;
        bool saveStatusRight = true;

        public Form1()
        {
            InitializeComponent();
            this.richTextBoxLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.richTextBoxLeft_DragDrop);
            this.richTextBoxRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.richTextBoxRight_DragDrop);
        }

        private void SaveAsActionLeft()
        {
            saveFileDialog1.Title = "Save As - Left Panel";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                documentFilePathLeft = saveFileDialog1.FileName;
                File.WriteAllText(documentFilePathLeft, richTextBoxLeft.Text);
                statusStripLeft.Items[1].Text = "File Path: " + documentFilePathLeft;
                saveStatusLeft = true;
            }
        }
        private void SaveActionLeft()
        {
            if (documentFilePathLeft == "")
            {
                SaveAsActionLeft();
            }
            else
            {
                File.WriteAllText(documentFilePathLeft, richTextBoxLeft.Text);
                saveStatusLeft = true;
            }
        }
        private void OpenActionLeft()
        {
            if (!saveStatusLeft)
            {
                DialogResult result = MessageBox.Show(this,
                    "Do you want to save changes?", "Left Panel", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveActionLeft();
                }

                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                documentFilePathLeft = openFileDialog1.FileName;
                richTextBoxLeft.Text = File.ReadAllText(documentFilePathLeft);
                statusStripLeft.Items[1].Text = "File Path: " + documentFilePathLeft;
                saveStatusLeft = true;
            }
        }

        private void SaveAsActionRight()
        {
            saveFileDialog1.Title = "Save As - Right Panel";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                documentFilePathRight = saveFileDialog1.FileName;
                File.WriteAllText(documentFilePathRight, richTextBoxRight.Text);
                statusStripRight.Items[1].Text = "File Path: " + documentFilePathRight;
                saveStatusRight = true;
            }
        }
        private void SaveActionRight()
        {
            if (documentFilePathRight == "")
            {
                SaveAsActionRight();
            }
            else
            {
                File.WriteAllText(documentFilePathRight, richTextBoxRight.Text);
                saveStatusRight = true;
            }
        }
        private void OpenActionRight()
        {
            if (!saveStatusRight)
            {
                DialogResult result = MessageBox.Show(this,
                    "Do you want to save changes?", "Right Panel", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveActionRight();
                }

                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                documentFilePathRight = openFileDialog1.FileName;
                richTextBoxRight.Text = File.ReadAllText(documentFilePathRight);
                statusStripRight.Items[1].Text = "File Path: " + documentFilePathRight;
                saveStatusRight = true;
            }
        }
        private void openToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            OpenActionLeft();
        }

        private void saveToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            SaveActionLeft();
        }

        private void openToolStripButtonRight_Click(object sender, EventArgs e)
        {
            OpenActionRight();
        }

        private void saveToolStripButtonRight_Click(object sender, EventArgs e)
        {
            SaveActionRight();
        }

        private void cutToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Cut();
        }

        private void copyToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Copy();
        }

        private void pasteToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Paste(DataFormats.GetFormat("Text"));
        }

        private void cutToolStripButtonRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Cut();
        }

        private void copyToolStripButtonRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Copy();
        }

        private void pasteToolStripButtonRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Paste(DataFormats.GetFormat("Text"));
        }

        private void FindToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Find(FindoolStripTextBoxLeft.Text,
                richTextBoxLeft.SelectionStart + richTextBoxLeft.SelectionLength,
                RichTextBoxFinds.MatchCase);
        }

        private void FindToolStripButtonRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Find(FindoolStripTextBoxRight.Text,
               richTextBoxRight.SelectionStart + richTextBoxRight.SelectionLength,
               RichTextBoxFinds.MatchCase);
        }
        private void cutToolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Cut();
        }

        private void copyToolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Copy();
        }

        private void pasteToolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Paste(DataFormats.GetFormat("Text"));
        }

        private void undoToolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Undo();
        }

        private void redoToolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Redo();
        }

        private void cutToolStripMenuItemRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Cut();
        }

        private void copyToolStripMenuItemRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Copy();
        }

        private void pasteToolStripMenuItemRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Paste(DataFormats.GetFormat("Text"));
        }

        private void undoToolStripMenuItemRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Undo();
        }

        private void redoToolStripMenuItemRight_Click(object sender, EventArgs e)
        {
            richTextBoxRight.Redo();
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.WordWrap = wordwrapToolStripMenuItem.Checked;
            richTextBoxRight.WordWrap = wordwrapToolStripMenuItem.Checked;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxLeft.Font = fontDialog1.Font;
                richTextBoxRight.Font = fontDialog1.Font;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool saveStatus = saveStatusLeft & saveStatusRight;
            if (!saveStatus)
            {
                DialogResult result = MessageBox.Show(this,
                    "Do you want to save changes?", "My LaTex Editor", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        if (!saveStatusLeft)
                            SaveActionLeft();
                        if (!saveStatusRight)
                            SaveActionRight();
                        saveStatus = saveStatusLeft & saveStatusRight;
                        if (!saveStatus)
                            MessageBox.Show(this, "Not saved!", "My LaTex Editor",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = !saveStatus;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void richTextBoxLeft_TextChanged(object sender, EventArgs e)
        {
            saveStatusLeft = false;
        }

        private void richTextBoxRight_TextChanged(object sender, EventArgs e)
        {
            saveStatusRight = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenActionLeft();
        }

        private void saveLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveActionLeft();
        }

        private void openRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveActionRight();
        }

        private void saveRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveActionRight();
        }

        private void nextFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = -1, b = -1;

            a = richTextBoxRight.Find("$",
               richTextBoxRight.SelectionStart + richTextBoxRight.SelectionLength,
               RichTextBoxFinds.NoHighlight);

            if (a != -1)
                b = richTextBoxRight.Find("$", a + 1, RichTextBoxFinds.NoHighlight);

            if (a != -1 && b != -1)
                richTextBoxRight.Select(a, b - a + 1);
        }

        private void previosFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = -1, b = -1;

            a = richTextBoxRight.Find("$", 0,
               richTextBoxRight.SelectionStart,
               RichTextBoxFinds.NoHighlight | RichTextBoxFinds.Reverse);

            if (a > 0)
                b = richTextBoxRight.Find("$", 0, a - 1, RichTextBoxFinds.NoHighlight | RichTextBoxFinds.Reverse);

            if (a != -1 && b != -1)
                richTextBoxRight.Select(b, a - b + 1);
        }

        private void FindoolStripTextBoxRight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBoxRight.Find(FindoolStripTextBoxRight.Text,
                    richTextBoxRight.SelectionStart +
                    richTextBoxRight.SelectionLength, RichTextBoxFinds.MatchCase);
            }
        }

        private void FindoolStripTextBoxLeft_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBoxLeft.Find(FindoolStripTextBoxLeft.Text,
                    richTextBoxLeft.SelectionStart +
                    richTextBoxLeft.SelectionLength, RichTextBoxFinds.MatchCase);
            }
        }

        private void moveToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.SelectedText = richTextBoxRight.SelectedText;
        }

        private void moveToolStripButtonRight_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.SelectedText = richTextBoxRight.SelectedText;
        }

        private void nextFormulaToolStripButtonRight_Click(object sender, EventArgs e)
        {
            int a = -1, b = -1;

            a = richTextBoxRight.Find("$",
               richTextBoxRight.SelectionStart + richTextBoxRight.SelectionLength,
               RichTextBoxFinds.NoHighlight);

            if (a != -1)
                b = richTextBoxRight.Find("$", a + 1, RichTextBoxFinds.NoHighlight);

            if (a != -1 && b != -1)
                richTextBoxRight.Select(a, b - a + 1);
        }

        private void previousFormulaToolStripButtonRight_Click(object sender, EventArgs e)
        {
            int a = -1, b = -1;

            a = richTextBoxRight.Find("$", 0,
               richTextBoxRight.SelectionStart,
               RichTextBoxFinds.NoHighlight | RichTextBoxFinds.Reverse);

            if (a > 0)
                b = richTextBoxRight.Find("$", 0, a - 1, RichTextBoxFinds.NoHighlight | RichTextBoxFinds.Reverse);

            if (a != -1 && b != -1)
                richTextBoxRight.Select(b, a - b + 1);
        }

        private void findNextToolStripMenuItemLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Find(FindoolStripTextBoxLeft.Text,
                richTextBoxLeft.SelectionStart + richTextBoxLeft.SelectionLength,
                RichTextBoxFinds.MatchCase);
        }

        private void undoToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Undo();
        }

        private void redoToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.Redo();
        }

        private void moveGoNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.SelectedText = richTextBoxRight.SelectedText;
            richTextBoxLeft.Find(FindoolStripTextBoxLeft.Text,
                richTextBoxLeft.SelectionStart + richTextBoxLeft.SelectionLength,
                RichTextBoxFinds.MatchCase);
            int a = -1, b = -1;

            a = richTextBoxRight.Find("$",
               richTextBoxRight.SelectionStart + richTextBoxRight.SelectionLength,
               RichTextBoxFinds.NoHighlight);

            if (a != -1)
                b = richTextBoxRight.Find("$", a + 1, RichTextBoxFinds.NoHighlight);

            if (a != -1 && b != -1)
                richTextBoxRight.Select(a, b - a + 1);
        }

        private void moveAndNextToolStripButtonLeft_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.SelectedText = richTextBoxRight.SelectedText;
            richTextBoxLeft.Find(FindoolStripTextBoxLeft.Text,
                richTextBoxLeft.SelectionStart + richTextBoxLeft.SelectionLength,
                RichTextBoxFinds.MatchCase);
            int a = -1, b = -1;

            a = richTextBoxRight.Find("$",
               richTextBoxRight.SelectionStart + richTextBoxRight.SelectionLength,
               RichTextBoxFinds.NoHighlight);

            if (a != -1)
                b = richTextBoxRight.Find("$", a + 1, RichTextBoxFinds.NoHighlight);

            if (a != -1 && b != -1)
                richTextBoxRight.Select(a, b - a + 1);
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxLeft.ZoomFactor < 4)
            {
                richTextBoxLeft.ZoomFactor += 0.1f;
                richTextBoxRight.ZoomFactor += 0.1f;
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxLeft.ZoomFactor > 0.4)
            {
                richTextBoxLeft.ZoomFactor -= 0.1f;
                richTextBoxRight.ZoomFactor -= 0.1f;
            }
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxLeft.ZoomFactor = 1.0f;
            richTextBoxRight.ZoomFactor = 1.0f;
        }

        private void richTextBoxLeft_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (!saveStatusLeft)
                {
                    DialogResult result = MessageBox.Show(this,
                        "Do you want to save changes?", "Left Panel", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SaveActionLeft();
                    }

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                documentFilePathLeft = docPath[0];
                richTextBoxLeft.Text = File.ReadAllText(documentFilePathLeft);
                statusStripLeft.Items[1].Text = "File Path: " + documentFilePathLeft;
                saveStatusLeft = true;
                e.Effect = DragDropEffects.None;
            }
        }
        private void richTextBoxRight_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (!saveStatusRight)
                {
                    DialogResult result = MessageBox.Show(this,
                        "Do you want to save changes?", "Right Panel", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SaveActionRight();
                    }

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                documentFilePathRight = docPath[0];
                richTextBoxRight.Text = File.ReadAllText(documentFilePathRight);
                statusStripRight.Items[1].Text = "File Path: " + documentFilePathRight;
                saveStatusRight = true;
                e.Effect = DragDropEffects.None;
            }
        }

        private void richTextBoxLeft_SelectionChanged(object sender, EventArgs e)
        {
            // Get the line.
            int index = richTextBoxLeft.SelectionStart;
            int line = richTextBoxLeft.GetLineFromCharIndex(index) + 1;

            statusStripLeft.Items[0].Text = "Line: " + line;
        }

        private void richTextBoxRight_SelectionChanged(object sender, EventArgs e)
        {
            // Get the line.
            int index = richTextBoxRight.SelectionStart;
            int line = richTextBoxRight.GetLineFromCharIndex(index) + 1;

            statusStripRight.Items[0].Text = "Line: " + line;
        }

        private void richTextBoxLeft_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
            }
        }
    }
}
