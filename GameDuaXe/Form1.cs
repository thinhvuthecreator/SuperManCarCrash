using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
    
namespace GameDuaXe
{
    public partial class fGameRunning : Form
    {
        
        int score = 0;
        int Carspeed = 8;
        SoundPlayer simpleSound1 = new SoundPlayer(@"C:\Users\admin\source\repos\GameDuaXe\GameDuaXe\bin\Debug\Resources\Contra-JungleTheme.wav");
        SoundPlayer simpleSound2 = new SoundPlayer(@"C:\Users\admin\source\repos\GameDuaXe\GameDuaXe\bin\Debug\Resources\wrong-buzzer-6268.wav");
        public fGameRunning()
        {
            InitializeComponent();
           
        }

        #region methods
        void midLineMove(int speed)
        {
            if (midLine1.Top > 500)
            {
                midLine1.Top = 0;
            }
            if (midLine2.Top > 500)
            {
                midLine2.Top = 0;
            }
            if (midLine2.Top > 500)
            {
                midLine2.Top = 0;
            }
            if (midLine3.Top > 500)
            {
                midLine3.Top = 0;
            }
            if (midLine4.Top > 500)
            {
                midLine4.Top = 0;
            }

            midLine1.Top += speed;
            midLine2.Top += speed;
            midLine3.Top += speed;
            midLine4.Top += speed;
            //midLine2.Top += speed;
            //midLine3.Top += speed;
            //midLine4.Top += speed;


        }
        void myCarMoveLeft(int speed)
        {
            myCar.Left += speed;
        }
        void myCarMoveRight(int speed)
        {
            myCar.Left -= speed;
        }
        void enermiesBornandMove(int Carspeed1,int Carspeed2,int Carspeed3)
        {
            #region enermies1
            Random rand = new Random();
            int random = rand.Next(9, 90);
            if (enermie.Top > 500)
            {
                score++;
                enermie.Top = 0;
                enermie.Left = random;
                enermie.Top = rand.Next(0, 40);
            }
            enermie.Top += Carspeed1;
            #endregion
            #region enermies2
            Random rand1 = new Random();
            int random1 = rand.Next(119, 250);
            if (enermie2.Top > 500)
            {
                score++;
                enermie2.Top = 0;
                enermie2.Left = random1;
                enermie2.Top = rand.Next(0, 40);
            }
            enermie2.Top += Carspeed2;
            #endregion
            #region enermies3
            Random rand2 = new Random();
            int random2 = rand.Next(265, 408);
            if (enermie3.Top > 500)
            {
                score++;
                enermie3.Top = 0;
                enermie3.Left = random2;
                enermie3.Top = rand.Next(0, 40);
            }
            enermie3.Top += Carspeed3;
            #endregion

            lbScoreCount.Text = score.ToString();



        } 

        void gameOver()
        {
            if(myCar.Bounds.IntersectsWith(enermie.Bounds) || myCar.Bounds.IntersectsWith(enermie2.Bounds) || myCar.Bounds.IntersectsWith(enermie3.Bounds))
            {
              
                timer1.Enabled = false;
                pbGameOver.Visible = true;
                simpleSound1.Stop();
                simpleSound2.Play();

                DialogResult choice = MessageBox.Show("RETRY ?", "", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    simpleSound1.Play();
                    timer1.Enabled = true;
                    score = 0;
                    pbGameOver.Visible = false;

                    Random rand = new Random(); 
                    int random = rand.Next(190, 400);

                    Random rand1 = new Random();
                    int random1 = rand.Next(100, 330);

                    Random rand2 = new Random();
                    int random2 = rand.Next(30, 99);
               
                    enermie.Top = 0;
                    enermie.Left = random;
                    enermie.Top = rand.Next(0, 40);

                    enermie2.Top = 0;
                    enermie2.Left = random1;
                    enermie2.Top = rand.Next(0, 40);

                    enermie3.Top = 0;
                    enermie3.Left = random2;
                    enermie3.Top = rand.Next(0, 40);
                    

                }
                else
                {
                    this.Close();
                }


            }
        }

        #endregion

        #region events
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            midLineMove(Carspeed);
            enermiesBornandMove(rand.Next(9,13), rand.Next(7, 13), rand.Next(6, 14));
            gameOver();
           
        }
        private void fGameRunning_Load(object sender, EventArgs e)
        {


            simpleSound1.PlayLooping();


        }
        private void fGameRunning_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==  Keys.Right && myCar.Left <409)
            {
                myCarMoveLeft(25);
            }
            if (e.KeyCode == Keys.Left && myCar.Left > 14)
            {
                myCarMoveRight(25);
            }
            if(e.KeyCode == Keys.Up)
            {
                if (Carspeed > 20)
                {
                    Carspeed = 20;
                }
                Carspeed += 1;
            }
            if (e.KeyCode == Keys.Down)
            {
                if(Carspeed < 2)
                {
                    Carspeed = 2;
                }
                Carspeed -= 1;
            }
        }
        #endregion

        private void btnYES_Click(object sender, EventArgs e)
        {
            //fGameRunning_Load(sender, e);
            //timer1.Enabled = true;
            //pbGameOver.Visible = false;
            //label1.Visible = false;
            //btnYES.Visible = false;
            //btnNO.Visible = false;
            //btnYES.Enabled = false;
            //btnNO.Enabled = false;
            //simpleSound2.Stop();
            //simpleSound1.Play();
        }

       
    }
}
