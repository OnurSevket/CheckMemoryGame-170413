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
    public partial class MainForm : Form
    {
        StartGame startgame = new StartGame();

        int[] userInfoarray = new int[2];

        public MainForm()
        {
            InitializeComponent();
        }

        public int AssignBoxNumber()
        {

            if (userInfoarray[0] == 0)
            {
               return  5;
            }
            else if (userInfoarray[0] == 1)
            {
                return 10;
            }
            else 
            {
                return 20;
            }

        }

        public int AssignLevelNumber()
        {
            if (userInfoarray[1] == 0)
            {
                return 10;
            }
            else if (userInfoarray[1] == 1)
            {
                return 5;
            }
            else
            {
                return 3;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BrainStormToolStrip.Enabled = false;
            GameSelection gameSelect = new GameSelection(userInfoarray);
            gameSelect.MdiParent = this;
            gameSelect.Show();
        }

        private void oyunaBaşlaMenuItem_Click(object sender, EventArgs e)
        {

            startgame.MdiParent = this;
            startgame.Text = "Zeka Oyunu";
            startgame.Show();
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SendEnableMenuStrip()
        {
            BrainStormToolStrip.Enabled = true;
        }
    }
}
