using System;
using System.Globalization;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Challenge 1 */
            string text = "this is a text";
            string newText = toTitleCase(text);
            Console.WriteLine(newText); // expect to see "This Is A Text"

            /* Challenge 2 */
            int[,] arrayA = { { 3, 5, 4, 6 }, { 3, 7, 8, 3 } };
            int[,] arrayB = { { 5, 1 }, { 8, 4 }, { 2, 9 }, { 2, 3 } };
            int[,] result = matrixMultiply(arrayA, arrayB);
            Console.WriteLine(result); //share your findings to Slack
        }
        static string toTitleCase(string input)
        {
            string[] justStringArr = input.Split(' ');
            //List<string> listStr = new List<string>();
            char[] upperCase = new char[30];
            int upperCaseCounter = default(int);
            int counter = default(int);
            var builder = new System.Text.StringBuilder();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                upperCase[upperCaseCounter] = i;
                upperCaseCounter = upperCaseCounter + 1;
            }
            foreach (string str in justStringArr)
            {
                char strFirstLetter = str[0];
                counter = 0;
                if (upperCase.Contains(strFirstLetter))
                {
                    builder.Append(str);
                    builder.Append(' ');
                    continue;
                }
                for (char i = 'a'; i <= 'z'; i++)
                {
                    if (strFirstLetter == i)
                    {
                        char newUpperChar = upperCase[counter];
                        string restString = str.Substring(1, str.Length - 1);
                        string newStr = string.Concat(str.Substring(0, 1).Replace(strFirstLetter, newUpperChar), restString);
                        builder.Append(newStr);
                        break;
                    }
                    counter = counter + 1;
                }
                builder.Append(' ');
            }
            return builder.ToString();
        }
        static int[,] matrixMultiply(int[,] array1, int[,] array2)
        {
            int[,] newArr = new int[2, 2];
            for (int z = 0; z < array1.GetLength(0); z++)
            {
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    int data = default(int);
                    for (int j = 0; j < array2.GetLength(0); j++)
                    {
                        data += array1[z, j] * array2[j, i];
                    }
                    Console.Write(data + " ");
                    Console.WriteLine();
                    newArr[z,i] = data;
                }    
            }
            return newArr;
        }
    }
}
