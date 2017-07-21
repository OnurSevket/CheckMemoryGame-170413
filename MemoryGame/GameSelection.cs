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
    public partial class GameSelection : Form
    {


        private int[] userInfoarray;

        public GameSelection(int[] userInfoarray)
        {
            InitializeComponent();
            this.userInfoarray = userInfoarray;
        }

        public GameSelection()
        {
            InitializeComponent();
     
        }
   
        private void btnSaveSelection_Click(object sender, EventArgs e)
        {

            userInfoarray[0]=cmbBoxNumberSelect.SelectedIndex;
            userInfoarray[1] = cmbDifficultyLevelSelect.SelectedIndex;

            MainForm mainform = (MainForm)this.MdiParent;
            mainform.SendEnableMenuStrip();

            this.Close();

        
          
            
        }

        

        
    }
}
