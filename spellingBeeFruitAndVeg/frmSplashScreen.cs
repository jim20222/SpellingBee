using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spellingBeeFruitAndVeg
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);//increment each-time by One
            if (progressBar.Value == 100)//if the progressBar reaches 100% do:
                timerProgressBar.Stop();//stopping the timer due to progressBar reaching 100%
        }  
    }//end of class
}//end of namespace
