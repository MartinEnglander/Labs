using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en alfanumerisk teckensträng:");

            string inputString = "";

            //read string from user
            inputString = Console.ReadLine();

            //new line
            Console.WriteLine("-------------------------------------");

            //check the number of chars of the string
            int stringLength = inputString.Length;

            //declare a char array to hold each single letter of the input string and populate it
            char[] inputStringArray = new char[stringLength];
            inputStringArray = inputString.ToCharArray();

            //first char in the input string
            char firstChar;

            //current char of the iteration
            char currChar;

            //index for first char 
            int firstIndex = 0;

            //current index within the char loop
            int currIndex = 0;

            //total sum for all numeric input
            long totalSum = 0;

            //loop through all cells of the char array
            for (int i = 0; i < stringLength; i++)
            {
                //gets the first char of the current iteration and its index, but only if it´s a number
                firstChar = inputStringArray[i];
                firstIndex = i;

                //inner loop to test whether the next char is identical to the first of the sub string
                //start from the next letter, ie firtChar + 1
                for (int j = i + 1; j < stringLength; j++)
                {
                    //read current char
                    currChar = inputStringArray[j];

                    //check if the current char is a number. If not, break the inner loop to get rid of letters
                    if (Char.IsNumber(currChar) == false)
                    {
                        break;
                    }

                    //test if the current char is identical to the first letter of the substring
                    //a substring is found when the first and last char are identical
                    if (firstChar == currChar)
                    {
                        currIndex = j;

                        //string to hold the current number
                        string subTotal = "";

                        //the first and last index of the substring are known
                        //all that remains is to iterate through the entire input string from the beginning
                        //and highlight the chars between the first and last index of the substring in red
                        for (int k = 0; k < stringLength; k++)
                        {
                            //check if the current char is not within the span firstIndex to currIndex
                            //set the text colour to white, else set it to red
                            if (k < firstIndex || k > currIndex)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                //read char by char to a string
                                subTotal += inputStringArray[k].ToString();
                            }

                            //write the current char to the console
                            Console.Write(inputStringArray[k]);
                        }

                        //convert the subtotal to long and add the subtotal to the total sum
                        totalSum += Int64.Parse(subTotal);

                        //new line
                        Console.WriteLine("");

                        //empty subtotal
                        subTotal = "";

                        break;
                    }
                }
            }

            //change colour to white
            Console.ForegroundColor = ConsoleColor.White;

            //new line
            Console.WriteLine("-------------------------------------");

            //write the total sum of the entered numbers
            Console.WriteLine("Summan av de inmatade talen: " + totalSum.ToString());

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
