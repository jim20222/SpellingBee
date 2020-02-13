using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellingBeeFruitAndVeg
{//Manages choosing a random word for playing Spelling-Bee
    class randomWordManager
    {
        private Random RandomPick;//variable for random
        private string[] Rwords = new string[]//array of Random-Words
    {
        "apple",
        "carrot",
        "banana",
    };//end of array
        string newWord = "";//Pick Method; new Random word to be displayed
        int index; //index for picking random word

        public randomWordManager()
        {
            DateTime aTime = new DateTime(1000);
            aTime = DateTime.Now;
            int nSeed = (int)(aTime.Millisecond);
            RandomPick = new Random(nSeed);
            // 
            // TODO: Add Constructor Logic here
            //
        }

        public string Pick()
        {
            index = (int)(RandomPick.NextDouble() * Rwords.GetUpperBound(0));
            newWord = Rwords[index];
            newWord = newWord.ToUpper();
            return newWord;
        }
    }
}
