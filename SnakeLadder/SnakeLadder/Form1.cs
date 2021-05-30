using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeLadder
{
    public partial class Form1 : Form
    {
        int diceNumber;
        int turnNumber = 1;
        int player1Cell = 0;
        int player2Cell = 0;
        Label labelPlayer1, labelPlayer2;
        int currentPos, endPos;
        int[] cellLinkIn = { 4, 9, 17, 20, 28, 40, 51, 52, 62, 63, 64, 71, 87, 93, 95, 99 };
        int[] cellLinkOut = { 14, 31, 7, 38, 84, 59, 67, 32, 19, 81, 60, 91, 24, 72, 75, 78 };

        public Form1()
        {
            InitializeComponent();

            labelPlayer1 = new Label();
            labelPlayer2 = new Label();
            panel1.Controls.Add(labelPlayer1);
            panel1.Controls.Add(labelPlayer2);
            labelPlayer1.Parent = pictureBoxPlayground;
            labelPlayer2.Parent = pictureBoxPlayground;
            labelPlayer1.BackColor = Color.Transparent;
            labelPlayer2.BackColor = Color.Transparent;
            labelPlayer1.Size = new Size(50, 50);
            labelPlayer2.Size = new Size(50, 50);
            labelPlayer1.Image = Properties.Resources.mohre_Green_copy;
            labelPlayer2.Image = Properties.Resources.mohre_Yellow_copy;
            gotoCell(1, 1);
            gotoCell(2, 1);
            labelDice.Image = Properties.Resources.animated_dice;
        }
        private void gotoCell(int player, int cellNumber)
        {
            float w = pictureBoxPlayground.Width / 10f;
            float h = pictureBoxPlayground.Height / 10f;
            int i = 100 - cellNumber;
            int row = i / 10;
            int col = (row % 2 == 0) ? (i % 10) : 9 - (i % 10);
            if (player == 1)
            {
                labelPlayer1.Location = new Point((int)(5 + col * w), (int)(5 + row * h));
                player1Cell = cellNumber;
            }
            else
            {
                labelPlayer2.Location = new Point((int)(5 + col * w), (int)(5 + row * h));
                player2Cell = cellNumber;
            }
        }

        private void buttonThrowDice_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            diceNumber = rand.Next(1, 7);
            labelDice.ImageList = imageListDice;
            labelDice.ImageIndex = diceNumber - 1;
            currentPos = (turnNumber == 1) ? player1Cell : player2Cell;
            endPos = currentPos + diceNumber;
            listBoxGameLog.Items.Add("بازیکن " + turnNumber + " خانه " + currentPos + " تاس " + diceNumber);
            timerAnimate.Enabled = true;
            buttonThrowDice.Enabled = false;
        }

        private void timerAnimate_Tick(object sender, EventArgs e)
        {
            currentPos = (currentPos < endPos) ? ++currentPos : --currentPos;
            gotoCell(turnNumber, currentPos);
            if (currentPos == 100)
            {
                timerAnimate.Enabled = false;
                buttonThrowDice.Enabled = true;
                MessageBox.Show("بازیکن " + turnNumber + " برنده شد! ");
                labelDice.Image = Properties.Resources.animated_dice;
                turnNumber = 1;
                gotoCell(1, 1);
                gotoCell(2, 1);
                buttonThrowDice.Text = "بازیکن " + turnNumber;
                listBoxGameLog.Items.Clear();
                return;
            }
            if (currentPos == endPos)
            {
                int link = Array.IndexOf(cellLinkIn, endPos);
                if (link >= 0)
                {
                    endPos = cellLinkOut[link];
                    timerAnimate.Interval = 10;
                }
                else
                {
                    timerAnimate.Interval = 100;
                    turnNumber = turnNumber % 2 + 1;
                    buttonThrowDice.Text = "بازیکن " + turnNumber;
                    labelDice.ImageList = null;
                    labelDice.Image = Properties.Resources.animated_dice;
                    if (checkBoxAutoPlay.Checked)
                        buttonThrowDice_Click(sender, e);
                    else
                        timerAnimate.Enabled = false;
                    buttonThrowDice.Enabled = true;
                }
            }
        }

        private void checkBoxAutoPlay_CheckedChanged(object sender, EventArgs e)
        {
            buttonThrowDice_Click(sender, e);            
        }
    }
}
