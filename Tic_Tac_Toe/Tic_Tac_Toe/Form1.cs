using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool IsX = true;
        int Placed = 0;


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color color = Color.White;
            Pen pen = new Pen(color);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // verticall line
            e.Graphics.DrawLine(pen, 350, 100, 350, 500);
            e.Graphics.DrawLine(pen, 500, 100, 500, 500);

            // Horizontal line
            e.Graphics.DrawLine(pen, 250, 200, 600, 200);
            e.Graphics.DrawLine(pen, 250, 350, 600, 350);
        }

        public void Player_Screen()
        {
            if (IsX)
                Player_Turn_label.Text = "Player X";
            else
                Player_Turn_label.Text = "Player O";
                
        }
        public void Change_Player_Turn()
        {
            IsX = !IsX;
            Player_Screen();

        }

        public string Check_Winner()
        {
            // check horizontal 

            if (pBox1.Tag.ToString() == pBox2.Tag.ToString() && pBox2.Tag.ToString() == pBox3.Tag.ToString())
                return pBox1.Tag.ToString();

            if (pBox4.Tag.ToString() == pBox5.Tag.ToString() && pBox5.Tag.ToString() == pBox6.Tag.ToString())
                return pBox4.Tag.ToString();
            
            if (pBox7.Tag.ToString() == pBox8.Tag.ToString() && pBox8.Tag.ToString() == pBox9.Tag.ToString())
                return pBox7.Tag.ToString();

            // check Vertical 

            if (pBox1.Tag.ToString() == pBox4.Tag.ToString() && pBox4.Tag.ToString() == pBox7.Tag.ToString())
                return pBox1.Tag.ToString();

            if (pBox2.Tag.ToString() == pBox5.Tag.ToString() && pBox5.Tag.ToString() == pBox8.Tag.ToString())
                return pBox2.Tag.ToString();

            if (pBox3.Tag.ToString() == pBox6.Tag.ToString() && pBox6.Tag.ToString() == pBox9.Tag.ToString())
                return pBox3.Tag.ToString();

            //check Diagnal

            if (pBox1.Tag.ToString() == pBox5.Tag.ToString() && pBox5.Tag.ToString() == pBox9.Tag.ToString())
                return pBox1.Tag.ToString();

            if (pBox3.Tag.ToString() == pBox5.Tag.ToString() && pBox5.Tag.ToString() == pBox7.Tag.ToString())
                return pBox3.Tag.ToString();

            
            return "None";
        }


       
        
        public void Draw()
        {
            Winner_Statue_Label.Text = "Draw";
            MessageBox.Show("Draw", "Game Over");
        }

        public void XWon()
        {
            Winner_Statue_Label.Text = "X Player Won";

            MessageBox.Show("X Player Won", "Game Over");
        }


        public void OWon()
        {
            Winner_Statue_Label.Text = "O Player Won";
            MessageBox.Show("O Player Won", "Game Over");
        }

        private void pBox1_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if(IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();
                
                if(GameOver =="None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled","Wrong");
        }

        private void pBox2_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if (IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();

                if (GameOver == "None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled", "Wrong");
        }

        private void pBox3_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if (IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();

                if (GameOver == "None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled", "Wrong");
        }

        private void pBox4_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if (IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();

                if (GameOver == "None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled", "Wrong");
        }

        private void pBox5_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if (IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();

                if (GameOver == "None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled", "Wrong");
        }

        private void pBox6_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if (IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();

                if (GameOver == "None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled", "Wrong");
        }

        private void pBox7_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if (IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();

                if (GameOver == "None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled", "Wrong");
        }

        private void pBox8_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if (IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();

                if (GameOver == "None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled", "Wrong");
        }

        private void pBox9_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            if ((pb.Tag as string) == "0")
            {
                if (IsX)
                {
                    pb.Image = Resources.X;
                    pb.Tag = "1";
                }

                if (!IsX)
                {
                    pb.Image = Resources.O;
                    pb.Tag = "2";
                }

                Placed++;
                // check winner
                string GameOver = Check_Winner();

                if (GameOver == "None" && Placed == 9)
                {
                    Draw();
                    return;
                }


                if (GameOver == "1")
                {
                    XWon();
                    return;
                }

                if (GameOver == "2")
                {
                    OWon();
                    return;
                }

                // change Player trun
                Change_Player_Turn();
            }
            // else message box allready filled
            else
                MessageBox.Show("All Ready Filled", "Wrong");
        }
    }
}
