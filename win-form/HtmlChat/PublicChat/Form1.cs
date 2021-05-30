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
namespace PublicChat
{
    public partial class Form1 : Form
    {
        Label[] label = new Label[60];
        string myName = "مهمان";
        string sharedDir = @"\\SOROUSH-PC\Users\Soroush\Desktop\";
        string roomFile = @"room1.htm";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(sharedDir + roomFile))
                File.WriteAllText(sharedDir + roomFile, "<meta charset=\"UTF-8\"> \r\n<h2 dir=\"rtl\" align=\"right\">خوش آمدید</h2> \r\n");

            webBrowser1.Navigate(new Uri(sharedDir + roomFile));
            this.Text = roomFile;
            fileSystemWatcher.Filter = roomFile;
            fileSystemWatcher.Path = sharedDir;
            fileSystemWatcher.EnableRaisingEvents = true;
        }

        private void ToolStripMenuItemChangeName_Click(object sender, EventArgs e)
        {
            myName = txtPost.Text;
            MessageBox.Show("نام جدید شما" + " " + myName, "تغییر نام");
            txtPost.Clear();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Control)
                {
                    myName = txtPost.Text;
                    MessageBox.Show("نام جدید شما" + " " + myName, "تغییر نام");
                    txtPost.Clear();
                }
                else
                {
                    try
                    {
                        File.AppendAllText(sharedDir + roomFile,
                            "<h2 dir=\"rtl\" align=\"right\">" +
                            DateTime.Now.ToString("HH:mm:ss") + " " +
                            myName + " : " + txtPost.Text + "</h2>" + "\r\n");
                        txtPost.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("پیام ارسال نشد", "خطا");
                    }
                }
            }
        }

        private void ToolStripMenuItemChangeRoom_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.AppendAllText(sharedDir + roomFile,
                       "<h2 dir=\"rtl\" align=\"right\">" + DateTime.Now.ToString("HH:mm:ss") + " " + myName + " خارج شد " + "</h2>" + "\r\n");
                }
                catch
                {
                    MessageBox.Show("پیام ارسال نشد", "خطا");
                }
                roomFile = Path.GetFileName(openFileDialog.FileName);
                sharedDir = Path.GetDirectoryName(openFileDialog.FileName) + @"\";
                this.Text = roomFile;
                fileSystemWatcher.Filter = roomFile;
                fileSystemWatcher.Path = sharedDir;
                try
                {
                    File.AppendAllText(sharedDir + roomFile,
                        "<h2 dir=\"rtl\" align=\"right\">" + DateTime.Now.ToString("HH:mm:ss") + " " + myName + " وارد شد " + "</h2>" + "\r\n");
                }
                catch
                {
                    MessageBox.Show("پیام ارسال نشد", "خطا");
                }
            }
        }

        private void ToolStripMenuItemNewRoom_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.AppendAllText(sharedDir + roomFile,
                        "<h2 dir=\"rtl\" align=\"right\">" + DateTime.Now.ToString("HH:mm:ss") + " " + myName + " خارج شد " + "</h2>" + "\r\n");
                }
                catch
                {
                    MessageBox.Show("پیام ارسال نشد", "خطا");
                }
                roomFile = Path.GetFileName(saveFileDialog.FileName);
                sharedDir = Path.GetDirectoryName(saveFileDialog.FileName) + @"\";
                this.Text = roomFile;
                fileSystemWatcher.Filter = roomFile;
                fileSystemWatcher.Path = sharedDir;
                File.WriteAllText(sharedDir + roomFile, "<h2 dir=\"rtl\" align=\"right\">" + "اتاق ایجاد شد" + "</h2>" + "\r\n");
            }
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            webBrowser1.Navigate(new Uri(sharedDir + roomFile));
        }

        private void emojilabel_Click(object sender, EventArgs e)
        {
            try
            {
                string stickerPath = "emoji\\emoji (" +
                    ((Label)sender).ImageIndex.ToString() + ").png";

                File.AppendAllText(sharedDir + roomFile,
                    "<h2 dir=\"rtl\" align=\"right\">" +
                    DateTime.Now.ToString("HH:mm:ss") + " " +
                    myName + " : " + txtPost.Text + "<br><br><br>\r\n" +
                    "<img align=\"right\" src=\"" + stickerPath +
                    "\" height=\"50\" width=\"50\"><br><br><br></h2>\r\n");
                txtPost.Clear();
            }
            catch
            {
                MessageBox.Show("پیام ارسال نشد", "خطا");
            }
        }

private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
{
    webBrowser1.Document.Window.ScrollTo(0, webBrowser1.Document.Body.ScrollRectangle.Height);
}

    }
}
