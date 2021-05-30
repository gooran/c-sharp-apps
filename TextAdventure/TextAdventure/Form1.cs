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

namespace TextAdventure
{
    public partial class Form1 : Form
    {
        string fileName = ".\\story\\0.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStory.Text = File.ReadAllText(fileName);
        }

        private void txtSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSelect.Text != "")
            {
                fileName = string.Format(".\\story\\{0}.txt", txtSelect.Text);

                if (File.Exists(fileName))
                {
                    txtStory.Text = File.ReadAllText(fileName);
                    this.Text = txtSelect.Text;
                    txtSelect.Clear();
                }
                else
                {
                    txtStory.Text = "این قسمت از داستان هنوز نوشته نشده است و " +
                    "شما می توانید ادامه داستان را خودتان بنویسید.";
                }
            }
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            txtStory.ReadOnly = !chkEdit.Checked;
            File.WriteAllText(fileName, txtStory.Text);
            this.Text = txtSelect.Text;
            txtSelect.Clear();
        }

    }
}
