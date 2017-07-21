using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class StartGame : Form
    {
        Random rnd = new Random();

        List<int> ScoreUserPositive = new List<int>();
        List<int> ScoreUserNegative = new List<int>();
        List<int> FiveRandom = new List<int>();
        


        public StartGame()
        {
            InitializeComponent();

        }


        private void StartGame_Load(object sender, EventArgs e)
        {

            CreateButton();

        }

        public void FiveUniqueNumber()
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            int boxTrueNumber = mainForm.AssignBoxNumber();

            for (int i = 0; i < 5;)
            {
                int randomNumber = rnd.Next(1,boxTrueNumber * boxTrueNumber+1);
                if (!FiveRandom.Contains(randomNumber))
                {
                    FiveRandom.Add(randomNumber);
                    i++;
                }
            }
        }

        public void CreateButton()
        {
            FiveUniqueNumber();
            MainForm mainForm = (MainForm)this.MdiParent;
            int boxTrueNumber = mainForm.AssignBoxNumber();
            int id = 1;
            int randomNumber = FiveRandom[0];
            int randomNumber1 = FiveRandom[1];
            int randomNumber2 = FiveRandom[2];
            int randomNumber3 = FiveRandom[3];
            int randomNumber4 = FiveRandom[4];
            for (int i = 0; i < boxTrueNumber; i++)
            {
                for (int j = 0; j < boxTrueNumber; j++)
                {
                    Button button = new Button();
                    button.Name = (id).ToString();
                    button.Size = new Size(40, 40);
                    button.Location = new Point(20 + (50 * i), 20 + (50 * j));

                    if (id == randomNumber || id == randomNumber1 || id == randomNumber2 || id == randomNumber3 || id == randomNumber4)
                    {
                        button.Tag = "icidolu";
                    }
                    else
                    {
                        button.Tag = "icibos";
                    }

                    this.Controls.Add(button);
                    button.Click += Button_Click;
                    id++;
                }
            }
            timer1.Interval = 1000;
            timer1.Start();
          
        

        }

        public void Button_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (senderButton.Tag.ToString() == "icidolu")
            {
                ScoreUserPositive.Add(100);
                senderButton.BackgroundImage = Image.FromFile("..\\..\\Pictures\\icidolu.jpg");
                senderButton.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                ScoreUserNegative.Add(-20);
                senderButton.BackgroundImage = Image.FromFile("..\\..\\Pictures\\icibos.jpg");
                senderButton.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }


        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            int timeLevel = mainForm.AssignLevelNumber();

            if (counter < timeLevel)
            {
                foreach (Button button in this.Controls)
                {
                    int deneme = int.Parse(button.Name);
                    if (FiveRandom.Contains(deneme))
                    {
                        button.BackgroundImage = Image.FromFile("..\\..\\Pictures\\icidolu.jpg");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        button.BackgroundImage = Image.FromFile("..\\..\\Pictures\\icibos.jpg");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
            else if (counter > timeLevel)
            {
                
                foreach (Button button in this.Controls)
                {
                    button.BackgroundImage = null;
                }
                timer1.Stop();
                timer2.Interval = 1000;
                timer2.Start();
            }
            counter++;
           
        }

        int counter1 = 0;
        string successTime;
        GameScore gameSore = new GameScore();
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (-1<counter1)
            {

                if (ScoreUserPositive.Sum()==500)
                {
                    successTime=counter1.ToString();
                    timer2.Stop();
                   
                    gameSore.Owner = this;
                    gameSore.Show();
                }
             
            }
            counter1++;
        }

        public void ScoreSum()
        {
            int totalScore=ScoreUserPositive.Sum() + ScoreUserNegative.Sum();
            int successTimer = int.Parse(successTime);
            gameSore.AddtoList(totalScore,successTimer);

        }

        
    }
}
