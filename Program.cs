using System;
using System.Globalization;
using System.Text;

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
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine(result); //share your findings to Slack
        }
        static string toTitleCase(string input)
        {
            string[] justStringArr = input.Split(' ');
            var builder = new StringBuilder();
            foreach (string str in justStringArr)
            {
                string remainingLetters = str[1..];
                string newStr = string.Concat(str.ToUpper()[..1], remainingLetters);
                builder.Append(newStr);
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
                    for (int j = 0; j < array2.GetLength(0); j++)
                    {
                        newArr[z, i] += array1[z, j] * array2[j, i];
                    }
                }
            }
            return newArr;
        }
    }
}
