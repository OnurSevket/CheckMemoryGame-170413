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
    public partial class GameScore : Form
    {
        List<string> fullScore = new List<string>();

        public GameScore()
        {
            InitializeComponent();
        }

        public void AddtoList(int totalScore,int totalTime)
        {
            string fullName=txtFullName.Text;

            fullScore.Add(fullName + "***(" + totalScore + ")***(" + totalTime + ")");

            lstScoreList.DataSource = null;
            lstScoreList.DataSource = fullScore;
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            StartGame startGame = (StartGame)this.Owner;
            startGame.ScoreSum();
        }

       
    }
}
