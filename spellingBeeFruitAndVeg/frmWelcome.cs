using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//extending limitations
using System.Threading;//ability to thread component of process aka SplashScreen

namespace spellingBeeFruitAndVeg
{//start of namespace
    public partial class frmWelcome : Form //inheritence 
    {//start of class
        List<string> secretWord = new List<string>() { "apple", "tomato", "orange","carrot","lettuce","strawberry","pear","pea", "berry","cabbage" };//list of secret-words to be Spelt// apple, orange...
        List<string> wordDescription = new List<string>() { "A sweet or sour fruit Containing Seeds", "soft red vegtable", "citrus fruit belonging to the Rutaceae family", "long orange root of a plant that is eaten as a vegetable", "a common garden vegetable whose succulent leaves are used especially in salads ", "the juicy edible usually red fruit", "typically rounded but elongated and growing smaller toward the stem", " most commonly the small spherical seed or the seed-pod of the pod fruit Pisum sativum. Each pod contains several ****, which can be green or yellow", "A small, juicy, fleshy fruit, such as a blackberry or raspberry, regardless of its botanical structure", "a garden plant related to the turnips that has a round firm head of leaves used as a vegetable. Keep scrolling for more" };//list of word-description to be displayed
        Random Rword = new Random();//random generator
        Random Rdescription = new Random();//random generator 
        string guessWord = string.Empty;
        Random number = new Random();//random generator for letters
        StringBuilder HiddenWordBuilder = new StringBuilder();//subsituting leters
        int index;//for display secretWord
        public frmWelcome()//constructor
        {
            Thread t = new Thread(new ThreadStart(SplashStart));//creation of thread 't' SplashStart
            t.Start();//to start thread
            Thread.Sleep(5000);//5 seconds
            t.Abort();//remove Splash when load is complete

            InitializeComponent();
            ///now for finding if letter
            guessWord = secretWord[number.Next(0, secretWord.Count)];//updating varible 
            HiddenWordBuilder.Append(string.Empty.PadLeft(guessWord.Length, '-'));//produce character
            lblWordOutput.Text = HiddenWordBuilder.ToString();//output display
        }
        public void SplashStart()//function for starting Timer & ProgressBar
        {
            Application.Run(new frmSplashScreen());//start splash screen from here
        }
        private void frmWelcome_Load(object sender, EventArgs e)
        {
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All Progress Made Will be Lost!", "Are You Sure You Want To Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);//pop-up box
            if (result == DialogResult.Yes)//conditional statement
            {
                Application.Exit();//Close game
            }
            else if (result == DialogResult.No)//resulting action
            {
                Show();//return to game
            }
        }
         private void btnSubmit_Click(object sender, EventArgs e)
        {
            //add secret word input
            secretWord.Add(txtAddWord.Text);//String added to List object
            //now for description
            wordDescription.Add(txtAddDescription.Text);//String added to List object

            txtAddWord.Clear();//clears the textBox after btnSubmit has been clicked
            txtAddDescription.Clear();//clears the textBox after btnSubmit has been clicked
        }
        private void btnDisplaySecretWord_Click(object sender, EventArgs e)
        {//display secret word

            index = Rdescription.Next(wordDescription.Count);//outputting random description
            lblDescriptionOutput.Text = wordDescription[index].ToString();//outputting random description
        }
        private void btnClearFields_Click(object sender, EventArgs e)
        {//clear feilds
            txtAddWord.Clear();//clear Add-word textbox
            txtAddDescription.Clear();//clear Add-description textbox
        }
         private void btnGuideLines_Click(object sender, EventArgs e)
        {//displaying guide-lines for game
            frmGuideLines openGuideLinesForm = new frmGuideLines();//initilise new form
            openGuideLinesForm.Show();//launch new form
            Visible = false;//remove frmWelcome Screen
        }

         private void btnCheckLetters_Click(object sender, EventArgs e)
        {//Checking input
            string s = txtUserInputGuess.Text;//setting s as input variable

            HiddenWordBuilder.Remove(0, guessWord.Length).Append(string.Empty.PadLeft(guessWord.Length, '-'));//remove character when guessed

            if (guessWord.Contains(s))//conditional if statement
            {

                List<int> foundIndexes = new List<int>();//creating list for index's of string
                for (int i = guessWord.IndexOf(s); i > -1; i = guessWord.IndexOf(s, i + 1))
                {
                    foundIndexes.Add(i);//showing letter as display
                }
                foreach (int i in foundIndexes)//for correct letters in string do...
                {
                    HiddenWordBuilder.Remove(i, s.Length).Insert(i, s);//replace charater symbol with letter
                }
            }
            lblWordOutput.Text = HiddenWordBuilder.ToString();//Output display

            if (txtUserInputGuess.Text == guessWord)
            {//when user guessed the word correctly 

                DialogResult result = MessageBox.Show("Perfect Spelling!", "Do You Wish To Continue?  Another Word Will Be Displayed From A Random Bank Of Words", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//pop-up message
                if (result == DialogResult.Yes)
                {//Yes, option choosen
                    frmWelcome openWelcomeForm = new frmWelcome();//initilise new form
                    openWelcomeForm.Show();//launch new form
                    Visible = false;//remove dialog and refresh Screen
                }
                else if (result == DialogResult.No)
                {//No, option choosen
                    Application.Exit();//Close game
                }
            }
        }//end of method
 }//end of class
}//end of namespace
