using System;
using System.IO;
using System.Collections;

namespace Word_search
{
    class Program
    {
        struct GridData
        {
            public string[] userWords = new string[] { };
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ACW Wordsearch!\n\nPlease select an option to continue:\n1: Use defult Wordsearch\n2: Select a file from avilable documents\n\nPlease enter 1 or 2:");
            int userinput;
            int.TryParse(Console.ReadLine(), out userinput);
            if (userinput == 1)//creates the defult puzzle from File.01
            {
                string[] userWords = new string[] { "algorithm", "virus" };
                int[] firstCoOrd = new int[] { 0, 5 };
                int[] secondCoOrd = new int[] { 1, 4 };
                string[] userDirections = new string[] { "right", "left" };
                Grid def1 = new Grid(9, 5, 2, userWords, firstCoOrd, secondCoOrd, userDirections);
                def1.ViewGrid();
            }
            else if (userinput == 2)
            {
                Console.WriteLine($"Please select a file to open\n");//path is just a placeholder until i get my head around Directories
                foreach(string path in args)
                {
                    if (File.Exists(@"source/"))
                    {
                        ProcessFile(path);
                    }
                    else if (Directory.Exists(path))
                    {
                        AccessDirectory(path);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid file or directory.", path);
                    }
                }
            }
            else
            {
                while (userinput != 1 || userinput != 2)//disallows users from entering anything but 1 or 2
                {
                    Console.WriteLine("Please only enter 1 or 2 to select your option");
                    int.TryParse(Console.ReadLine(), out userinput);
                    if (userinput == 1)//creates the defult puzzle from File.01
                    {
                        string[] userWords = new string[] { "algorithm", "virus" };
                        int[] firstCoOrd = new int[] { 0, 5 };
                        int[] secondCoOrd = new int[] { 1, 4 };
                        string[] userDirections = new string[] { "right", "left" };
                        Grid def1 = new Grid(9, 5, 2, userWords, firstCoOrd, secondCoOrd, userDirections);
                        def1.ViewGrid();
                    }
                    else if (userinput == 2)
                    {
                        Console.WriteLine($"Please select a file to open\n");//path is just a placeholder until i get my head around Directories
                        foreach (string path in args)
                        {
                            if (File.Exists(@"source/"))
                            {
                                ProcessFile(path);
                            }
                            else if (Directory.Exists(path))
                            {
                                AccessDirectory(path);
                            }
                            else
                            {
                                Console.WriteLine("{0} is not a valid file or directory.", path);
                            }
                        }
                    }
                    continue;
                }
            }
            
        }

        public static void AccessDirectory(string targetDirectory)
        {
            string[] files = Directory.GetFiles(targetDirectory);
            foreach (string file in files)
                ProcessFile(file);
        }

        public static void ProcessFile(string path)
        {
            Console.WriteLine("'{0}'.", path);
        }
    }
}
