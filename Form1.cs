using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*
 * MSKAssignment-1
 * Assignment-1
 * Due date : 3rd October, 2021
 * 
 *      Mohammad Sadeq Khandakar, 2021.09.25: Started
 *      Mohammad Sadeq Khandakar, 2021.10.01: Completed with comments 
 */



namespace MSKhandakarAssignment1
{
    /// <summary>
    /// This form class defines the form which contains the game.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// This is the default constructor for the Mainform class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        // theses are the variables for the pictures from Resources.
        public Bitmap pic1 = MSKhandakarAssignment1.Properties.Resources.X;
        public Bitmap pic2 = MSKhandakarAssignment1.Properties.Resources.O;

        // the counter variable keeps track of the game.
        public int counter = 0;

        //the Bitmap-type array stores the positions of the players.
        public Bitmap[] picTiles = new Bitmap[9];

        //this constant is the limiting scope of the game, that is there are 9 spots for the players. 
        public const int WINNING_COMBO = 9;

       
        /// <summary>
        /// This method alternates between the cross and circle 
        /// </summary>
        /// <param name="count">Takes in the counter integer</param>
        /// <returns>A cross or circle picture, depending on the parameter</returns>
        public Bitmap PicsByTurn (int count)
        {
            if (count % 2 == 0)
            {
                return pic2;
            }

            else
            {
                return pic1;
            }
        }

        /// <summary>
        /// This method has a built-in record of the winning combinations, and a 
        /// conditional statement for determining the winner.
        /// </summary>
        public void WinLose()
        {
            
            Bitmap combo1 = null;
            Bitmap combo2 = null;
            Bitmap combo3 = null;

            for (int i = 0; i < WINNING_COMBO; i++)
            {
                switch (i)
                {
                    case 0:
                        combo1 = picTiles[0];
                        combo2 = picTiles[4];
                        combo3 = picTiles[8];
                        break;
                    case 1:
                        combo1 = picTiles[2];
                        combo2 = picTiles[4];
                        combo3 = picTiles[6];
                        break;
                    case 2:
                        combo1 = picTiles[0];
                        combo2 = picTiles[1];
                        combo3 = picTiles[2];
                        break;
                    case 3:
                        combo1 = picTiles[3];
                        combo2 = picTiles[4];
                        combo3 = picTiles[5];
                        break;
                    case 4:
                        combo1 = picTiles[6];
                        combo2 = picTiles[7];
                        combo3 = picTiles[8];
                        break;
                    case 5:
                        combo1 = picTiles[0];
                        combo2 = picTiles[3];
                        combo3 = picTiles[6];
                        break;
                    case 6:
                        combo1 = picTiles[1];
                        combo2 = picTiles[4];
                        combo3 = picTiles[7];
                        break;
                    case 7:
                        combo1 = picTiles[2];
                        combo2 = picTiles[5];
                        combo3 = picTiles[8];
                        break;

                    default:
                        break;
                }

               
                if (combo1 == pic1 && combo2 == pic1 && combo3 == pic1 | counter == WINNING_COMBO)
                {
                    MessageBox.Show("X won !", "Victory !");
                    Reset();
                }

                else if (combo1 == pic2 && combo2 == pic2 && combo3 == pic2 | counter == WINNING_COMBO)
                {
                    MessageBox.Show("O won !", "Victory !");
                    Reset();
                }

                else if (counter == WINNING_COMBO)
                {
                    MessageBox.Show("It's a tie !", "Better luck next time !");
                    Reset();
                }
                

            }

        }

        /// <summary>
        /// This method will remove the pictures, reset the counter to 0, and reinitialize the array
        /// </summary>
        public void Reset()
        {
            pictureBox1.Image = null; 
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox10.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            picTiles = new Bitmap[9];
            counter = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[0] = PicsByTurn(counter);
            pictureBox1.Image = picTiles[0];
            WinLose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[1] = PicsByTurn(counter);
            pictureBox2.Image = picTiles[1];
            WinLose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[2] = PicsByTurn(counter);
            pictureBox3.Image = picTiles[2];
            WinLose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[3] = PicsByTurn(counter);
            pictureBox4.Image = picTiles[3];
            WinLose();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[4] = PicsByTurn(counter);
            pictureBox5.Image = picTiles[4];
            WinLose();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[5] = PicsByTurn(counter);
            pictureBox6.Image = picTiles[5];
            WinLose();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[6] = PicsByTurn(counter);
            pictureBox10.Image = picTiles[6];
            WinLose();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[7] = PicsByTurn(counter);
            pictureBox8.Image = picTiles[7];
            WinLose();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            counter++;
            picTiles[8] = PicsByTurn(counter);
            pictureBox9.Image = picTiles[8];
            WinLose();
        }

      
    }


    

       
    
}
