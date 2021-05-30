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

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        string filePath = @"ContactList.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            string newContact = textBoxName.Text + "\t|" +
                                textBoxLastName.Text + "\t|" +
                                textBoxPhone.Text + "\t|" + textBoxAddress.Text;
            try
            {
                File.AppendAllText(filePath, newContact + "\r\n");
                listBoxContact.Items.Add(newContact);
            }
            catch
            {
                MessageBox.Show("اجرای عملیات امکان پذیر نیست. لطفا یک بار دیگر سعی کنید", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    listBoxContact.Items.AddRange(File.ReadAllLines(filePath));
                }
                catch
                {
                    MessageBox.Show("امکان خواندن داده ها از پرونده وجود ندارد", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
