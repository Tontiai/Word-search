using System;
using System.Collections.Generic;
using System.Text;

namespace Word_search
{
    class Grid
    {
        //FEILDS
        private int[] columns = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int numberOfColumns; 
        private int[] rows = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int numberOfRows;
        private int numberOfWords;
        private string[] words;
        private int[] cCoordinates;
        private int[] rCoordinates;
        private string[] directions; 

        //CONSTRUCTORS
        public Grid (int numberOfColumns, int numberOfRows, int numberOfWords, string[] words, int[] cCoordinates, int[] rCoordinates, string[] directions) //1st Constructor to create the grid
        {
            this.numberOfColumns = numberOfColumns;
            this.numberOfRows = numberOfRows;
            this.numberOfWords = numberOfWords;
            this.words = words;
            this.cCoordinates = cCoordinates;
            this.rCoordinates = rCoordinates;
            this.directions = directions;
        }

        public Grid (string[] words, int[] cCoordinates, int[] rCoordinates, string[] directions) //2nd Constructor to modify the grid
        {
            this.words = words;
            this.cCoordinates = cCoordinates;
            this.rCoordinates = rCoordinates;
            this.directions = directions;
        }

        //PROPERTIES
        
        
        //METHODS
        public void ViewGrid()//how the grid is shown in Program.cs
        {
            string[,] grid = new string[numberOfRows, numberOfColumns];




            List<string> test = new List<string>();
            List<int> rowsAndCol = new List<int>();
            for (int i = 0; i < numberOfColumns; i++)//changes the colour of the top results yellow and prints out how much is specified the constructor, it also adds the end result to a list
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0} ", columns[i]);
                rowsAndCol.Add(columns[i]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < numberOfRows; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;//changes the colour of the top results yellow and prints out how much is specified the constructor, it also adds the end result to a list
                int[] finalrow = new int[] { rows[i] };
                rowsAndCol.Add(rows[i]);
                test.Add(RandomString());//adds multiple methods into the list
                Console.WriteLine(rows[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            test.ForEach(Console.WriteLine);//the list is turned white and is printed for the user
            



            Console.WriteLine("Words to find: ");
            int wordNumber = 0;
            foreach (string word in words)
            {
                Console.WriteLine($"{wordNumber + 1}: {word}");//shows how many words the user has left to find
                wordNumber++;
            }


        }
        public string RandomString()//Method used to create the random characters in puzzle
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] charAlphabet = alphabet.ToCharArray();
            char[] stringChar = new char[numberOfColumns];
            Random randomCharGen = new Random();
            for (int i = 0; i < numberOfColumns; i++)
            {
                stringChar[i] = charAlphabet[randomCharGen.Next(alphabet.Length)];
            }
            string finalString = String.Join(" ", stringChar);
            return finalString;
        }

        /*public string NameRandomiser()//Method that was supposed to make the words into a method with the needed random characters added on at the end
        {
            string newWord = words;
            char[] charWord = newWord.ToCharArray();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] charAlphabet = alphabet.ToCharArray();
            char[] stringChar = new char[numberOfColumns];
            Random randomCharGen = new Random();
            for (int i = 0; i < numberOfColumns; i++)
            {
                stringChar[i] = charAlphabet[randomCharGen.Next(alphabet.Length)];
            }
            string randomString = String.Join(" ", stringChar);
            int newWordInt = charWord.Length;
            int randStrInt = randomString.Length;
            double sub = newWordInt - randStrInt;
            int intsub = Convert.ToInt32(sub);
            Console.WriteLine(intsub);

            if (intsub > 0)
            {
                intsub = randStrInt - newWordInt;
            }
            else

            if (newWordInt == numberOfColumns)
            {
                return newWord;
            }
            else if (newWordInt > numberOfColumns)
            {
                Console.WriteLine("Please check the text file as this word will not fit on the puzzle");
            }
            else
            {

            }
            return newWord;
           

        }*/

    }
}
