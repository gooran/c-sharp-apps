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

namespace ATMSimulator
{
    enum PageName
    {
        Page1, Page2, Page3, Page4, Page5
    }

    public partial class FormATM : Form
    {
        PageName currentPage = PageName.Page1;
        string password = "4386";

        public FormATM()
        {
            InitializeComponent();
        }

        private void buttonInsertCard_Click(object sender, EventArgs e)
        {
            if (currentPage == PageName.Page1)
            {
                File.AppendAllText("ATM.LOG",
                    DateTime.Now.ToString("yyy/MM/dd HH:mm:ss") +
                    ":" + "ورود کارت" + "\r\n");

                pictureBoxScreen.Image = Properties.Resources.Slide2;
                currentPage = PageName.Page2;
                textBoxPassword.Visible = true;
                textBoxPassword.Focus();
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            switch (currentPage)
            {
                case PageName.Page2:
                    if (textBoxPassword.Text == password)
                    {
                        pictureBoxScreen.Image = Properties.Resources.Slide3;
                        textBoxPassword.Visible = false;
                        currentPage = PageName.Page3;
                    }
                    else
                    {
                        pictureBoxScreen.Image = Properties.Resources.Slide5;
                        textBoxPassword.Visible = true;
                        textBoxPassword.Clear();
                        textBoxPassword.Focus();
                        currentPage = PageName.Page5;
                    }
                    break;
                case PageName.Page5:
                    if (textBoxPassword.Text == password)
                    {
                        pictureBoxScreen.Image = Properties.Resources.Slide3;
                        textBoxPassword.Visible = false;
                        currentPage = PageName.Page3;
                    }
                    else
                    {
                        pictureBoxScreen.Image = Properties.Resources.Slide1;
                        textBoxPassword.Visible = false;
                        currentPage = PageName.Page1;
                    }
                    break;
            }
        }

        private void FormATM_Load(object sender, EventArgs e)
        {
            pictureBoxScreen.Image = Properties.Resources.Slide1;
            currentPage = PageName.Page1;
            textBoxPassword.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (currentPage != PageName.Page1)
            {
                pictureBoxScreen.Image = Properties.Resources.Slide4;
                currentPage = PageName.Page4;
                textBoxPassword.Visible = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPassword.Focus();
        }

        private void buttonGetCard_Click(object sender, EventArgs e)
        {
            if (currentPage == PageName.Page4)
            {
                pictureBoxScreen.Image = Properties.Resources.Slide1;
                currentPage = PageName.Page1;
            }
        }

        private void numericButton_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text += ((Button)sender).Text;
        }

        private void buttonR4_Click(object sender, EventArgs e)
        {
            if (currentPage != PageName.Page1)
            {
                pictureBoxScreen.Image = Properties.Resources.Slide4;
                currentPage = PageName.Page4;
                textBoxPassword.Visible = false;
            }
        }
    }
}
