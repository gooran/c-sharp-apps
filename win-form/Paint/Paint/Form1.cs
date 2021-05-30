using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    enum Shapes { Line, Rectangle, Ellipse };

    public partial class Form1 : Form
    {
        private bool drawing = false;
        private Point startPoint;
        private Point endPoint;
        private Pen pen;
        private Shapes shape;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            toolStripComboBox1.SelectedIndex = 2;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = true;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;
            shape = Shapes.Line;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = true;
            toolStripButton3.Checked = false;
            shape = Shapes.Rectangle;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = true;
            shape = Shapes.Ellipse;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            startPoint = e.Location;
            endPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                endPoint = e.Location;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            Graphics g = Graphics.FromImage(bmp);

            switch (shape)
            {
                case Shapes.Line:
                    g.DrawLine(pen, startPoint, endPoint);
                    break;
                case Shapes.Rectangle:
                    g.DrawRectangle(pen, startPoint.X, startPoint.Y,
                        (endPoint.X - startPoint.X), (endPoint.Y - startPoint.Y));
                    break;
                case Shapes.Ellipse:
                    g.DrawEllipse(pen, startPoint.X, startPoint.Y,
                            (endPoint.X - startPoint.X), (endPoint.Y - startPoint.Y));
                    break;
            }

            g.Dispose();

            pictureBox1.Image = bmp;

            drawing = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (drawing)
            {
                switch (shape)
                {
                    case Shapes.Line:
                        e.Graphics.DrawLine(pen, startPoint, endPoint);
                        break;
                    case Shapes.Rectangle:
                        e.Graphics.DrawRectangle(pen, startPoint.X, startPoint.Y,
                            (endPoint.X - startPoint.X), (endPoint.Y - startPoint.Y));
                        break;
                    case Shapes.Ellipse:
                        e.Graphics.DrawEllipse(pen, startPoint.X, startPoint.Y,
                            (endPoint.X - startPoint.X), (endPoint.Y - startPoint.Y));
                        break;
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                toolStripTextBox1.BackColor = colorDialog1.Color;
                pen = new Pen(toolStripTextBox1.BackColor, toolStripComboBox1.SelectedIndex + 1);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = new Pen(toolStripTextBox1.BackColor, toolStripComboBox1.SelectedIndex + 1);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                Bitmap newBmp = new Bitmap(openFileDialog1.FileName);

                Graphics g = Graphics.FromImage(bmp);

                g.DrawImage(newBmp, 0, 0, newBmp.Width, newBmp.Height);

                pictureBox1.Image = bmp;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
        }

    }
}
