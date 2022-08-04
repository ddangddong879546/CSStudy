using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int carSpeed = 0; //자동차 스피드
        int collectedcoin = 0;

        void coinsCollection()
        {
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_money1.Bounds))
            {
                collectedcoin++;
                label_coins.Text = "Coins" + collectedcoin.ToString();

                x = r.Next(0, 200); // 돈을 먹으면 다시 돈이 새로운 랜덤한 지점에서 생기게 한다
                pictureBox_money1.Location = new Point(x, 0);
            }

            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_money2.Bounds))
            {
                collectedcoin++;
                label_coins.Text = "Coins" + collectedcoin.ToString();

                x = r.Next(100, 300);
                pictureBox_money2.Location = new Point(x, 0);
            }

            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_money3.Bounds))
            {
                collectedcoin++;
                label_coins.Text = "Coins" + collectedcoin.ToString();

                x = r.Next(200, 400);
                pictureBox_money3.Location = new Point(x, 0);
            }
        }

        void gameover()
        {
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_redcar.Bounds))
            {
                timer1.Enabled = false;
                label_gameOver.Visible = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carSpeed);
            redCar(carSpeed);
            gameover();
            coins(carSpeed);
            coinsCollection();

            
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_redcar.Bounds))
            {
                timer1.Stop();

                DialogResult result = MessageBox.Show("Game Over! 다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    carSpeed = 0;
                    pictureBox_Car.Location = new Point(38, 293);
                    pictureBox_redcar.Location = new Point(15, 40);
                    label_gameOver.Visible = false;
                    pictureBox_money1.Location = new Point(255, 88);
                    pictureBox_money2.Location = new Point(98, 135);
                    pictureBox_money3.Location = new Point(173, 291);
                    collectedcoin = 0;
                    label_coins.Text = "Coins" + collectedcoin.ToString(); // 두 개 다 바꿔야 바뀜

                    timer1.Start();
                }
                else
                {
                    this.Close();
                }
            }
        }


        void coins(int speed)
        {
            if(pictureBox_money1.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_money1.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money1.Top += speed;
            }

            if (pictureBox_money2.Top >= 500)
            {
                x = r.Next(100, 300);
                pictureBox_money2.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money2.Top += speed;
            }

            if (pictureBox_money3.Top >= 500)
            {
                x = r.Next(200, 400);
                pictureBox_money3.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_money3.Top += speed;
            }
        }

        Random r = new Random();
        int x;

        void redCar(int speed)
        {
            if(pictureBox_redcar.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_redcar.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_redcar.Top += speed;
            }

        }

        void moveline(int speed)
        {
            if(pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(pictureBox_Car.Left > 0)
                pictureBox_Car.Left += -10;
            }

            if(e.KeyCode == Keys.Right)
            {
                if(pictureBox_Car.Right < 400 - pictureBox_Car.Width/2)
                pictureBox_Car.Left += 10;
            }
            
            if(e.KeyCode == Keys.Up)
            {
                if(carSpeed < 15)
                {
                    carSpeed++;
                }
            }

            if(e.KeyCode == Keys.Down)
            {
                if(carSpeed > 0)
                {
                    carSpeed--;
                }
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
