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
    public partial class frmGuideLines : Form//inheritance of form
    {
        public frmGuideLines()//constructor
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {//bring user back to application
            frmWelcome openWelcomeForm = new frmWelcome();//initilise new form
            openWelcomeForm.Show();//launch new form
            Visible = false;//remove frmGuideLines Screen
        }
    }//end of class
}//end of namespace
