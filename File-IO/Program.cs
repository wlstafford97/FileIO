using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            int newNumber;
            string[] numbers = System.IO.File.ReadAllLines(@"C:\Users\Lucas\source\repos\File-IO\Numbers.txt");
            int[] newArray = new int[numbers.Length];
            string[] oddArray = new string[numbers.Length];
            string[] evenArray = new string[numbers.Length];
            List<string> oddList = new List<string>();
            List<string> evenList = new List<string>();

            for (int i=0; i < numbers.Length; i++)
            {
                newNumber = int.Parse(numbers[i]);
                newArray[i] = newNumber;
                if ((newArray[i] % 2) > 0)
                {
                    oddList.Add(newArray[i].ToString());
                    oddArray = oddList.ToArray();
                }
                else
                {
                    evenList.Add(newArray[i].ToString());
                    evenArray = evenList.ToArray();
                }
            }
            System.IO.File.WriteAllLines(@"C:\Users\Lucas\source\repos\File-IO\Odd.txt", oddArray);
            System.IO.File.WriteAllLines(@"C:\Users\Lucas\source\repos\File-IO\Even.txt", evenArray);
        }
    }
}
