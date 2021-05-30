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

namespace EventEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day;
            int month;
            string text;
            day = cmbDay.SelectedIndex + 1;
            month = cmbMonth.SelectedIndex + 1;
            text = String.Format("[month]{0}\r\n[day]{1}\r\n[event]{2}\r\n",
                month, day, txtEvent.Text);
            File.AppendAllText("events.txt", text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
