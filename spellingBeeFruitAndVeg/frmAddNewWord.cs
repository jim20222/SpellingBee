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
    public partial class frmAddWord : Form
    {
        protected string newWord;
        protected int newDiscription;

        public frmAddWord()
        {
            InitializeComponent();
        }
        List<string> words;//creation of list 'words'

        private void frmAddWord_Load(object sender, EventArgs e)
        {
            words = new List<string>() { "Monday", "Tuesday", "Wednesday" };//compulsary words
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> words;//
            txtAddWord.Clear();//clear text-box after submission
            Display();
        }
        public void Display()
        {
            string message = "";
            foreach (frmAddNewWord spellingBee1 in words)
                message += spellingBee1.ToString() + "\n";
            MessageBox.Show(message);
        }
    }
}
