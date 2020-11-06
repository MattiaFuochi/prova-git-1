using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistica_bar_Isii
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        int RadioButton = 0;
        int Nvoti = 100;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnV.Text = "VOTA";
        }

        private void btnV_Click(object sender, EventArgs e)
        {   
            if (Nvoti == 0)
            {
                RadioButton = 0;
            }
            else Nvoti--;
            
            switch (RadioButton)
            {
                case 1: PBS.Value += 1; Display.Text = "Abbiamo preso nota";
                    break;
                case 2: PBD.Value += 1; Display.Text = "Abbiamo preso nota";
                    break;
                case 3: PBO.Value += 1; Display.Text = "Abbiamo preso nota";
                    break;
                default:Display.Text = "Votazioni chiuse Alla prossima " ;
                    break;
            }
            
           
        }
        
        private void RBS_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton = 1;
        }

        private void RBD_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton = 2;
        }

        private void RBO_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton = 3;
        }

        private void PBS_Click(object sender, EventArgs e)
        {

        }

        private void PBD_Click(object sender, EventArgs e)
        {

        }

        private void PBO_Click(object sender, EventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
