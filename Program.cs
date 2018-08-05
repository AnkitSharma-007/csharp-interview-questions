using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            MultiToSingle(arr);
            Console.ReadLine();
        }

        // Q.1: How to reverse a string?
        internal static void ReverseString(string str)
        {
            /* input:- hello ; output:- olleh
             * input:- hello world ; output:- dlrow olleh
             * 
             * */
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }

        // Q.2: How to find if the given string is a palindrome or not?
        internal static void chkPalindrome(string str)
        {
            /* input:- madam ; output:- Palindrome
             * input:- step on no pets ; output:- Palindrome
             * input:- book ; output:- Not Palindrome
             * 
             * */

            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }

        // Q.3: How to reverse the order of words in a given string?
        internal static void ReverseWordOrder(string str)
        {
            /* input:- Welcome to Csharp corner ; output:- corner Csharp to Welcome
            * 
            * */

            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }

        // Q.4: How to reverse each word in a given string?
        internal static void ReverseWords(string str)
        {
            /* input:- Welcome to Csharp corner ; output:- emocleW ot prahsC renroc
             * 
             * */

            StringBuilder output = new StringBuilder();
            List<char> charlist = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output.Append(charlist[j]);

                    output.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }
            Console.WriteLine(output.ToString());
        }

        // Q.5: How to count the occurrence of each character in a string?
        internal static void Countcharacter(string str)
        {
            /* input:- hello world ; 
             * output:- h - 1
                        e - 1
                        l - 3
                        o - 2
                        w - 1
                        r - 1
                        d - 1
             * 
             * */

            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        // Q.6: How to remove duplicate characters from a string?
        internal static void removeduplicate(string str)
        {
            /* input:- csharpcorner ; output:- csharpone
             * 
             */
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }

        // Q.7: How to find all possible substring of a given string?
        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }

        // Q.8: How to perform Left circular rotation of an array?
        internal static void RotateLeft(int[] array)
        {
            /* input :- 1 2 3 4 5 output :- 2 3 4 5 1 
             * */

            //Logic :- Iterate loop from  size-1 to 0 and swap each elements with last element 

            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        // Q.9: How to perform Right circular rotation of an array?
        internal static void RotateRight(int[] array)
        {
            /* input :- 1 2 3 4 5 output :- 5 1 2 3 4 
             * */

            //Logic 1 :- Iterate loop from 0 to size-1 and swap each elements with first element 

            int size = array.Length;
            int temp;
            for (int j = 0; j < size - 1; j++)
            {
                temp = array[0];
                array[0] = array[j + 1];
                array[j + 1] = temp;
            }
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        // Q.10: How to find if a positive integer is a prime number or not?
        internal static bool FindPrime(int number)
        {
            /* input :- 20 output :- Not Prime
             * input :- 17 output :- Prime
             * 
             * */
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        // Q.11: How to find the sum of digits of a positive integer?
        internal static void SumOfDigits(int num)
        {
            /* input:- 168 ; output:- 15
            * 
            * */

            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }

        // Q.12: How to find second largest integer in an array using only one loop?
        internal static void FindSecondLargeInArray(int[] arr)
        {
            /* input :- 1 2 3 4 5 output :- 4 
            * */

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2)
                {
                    max2 = i;
                }
            }
            Console.WriteLine(max2); ;
        }

        // Q.13: How to find Third largest integer in an array using only one loop?
        internal static void FindthirdLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2)
                {
                    max3 = max2;
                    max2 = i;
                }
                else if (i > max3)
                {
                    max3 = i;
                }
            }
            Console.WriteLine(max3); ;
        }

        // Q.14: How to convert a two-dimensional array to a one-dimensional array?
        internal static void MultiToSingle(int[,] array)
        {
            //Convert 2-D array to 1-D array

            /*Input: { { 1, 2, 3 }, { 4, 5, 6 } }, output: 1 4 2 5 3 6 
             * 
             * */

            int index = 0;
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            int[] single = new int[width * height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    single[index] = array[x, y];
                    Console.Write(single[index] + " ");
                    index++;
                }
            }
        }

        // Q.15: How to convert a one-dimensional array to a two-dimensional array?
        internal static void SingleToMulti(int[] array, int row, int column)
        {
            //convert 1-D array to 2-D array

            /* input: 1, 2, 3, 4, 5, 6
             * output: 1 2 3
             *         4 5 6
             * 
             * */

            int index = 0;
            int[,] multi = new int[row, column];

            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    multi[y, x] = array[index];
                    index++;
                    Console.Write(multi[y, x] + " ");
                }
                Console.WriteLine();
            }
        }

        // Q.16: How to find the angle between hour and minute hands of a clock at any given time?

        internal static void FindAngleinTime(int hours, int mins)
        {
            /* input :- 9 30 output :- The angle between hour hand and minute hand is 105 degrees
             * input :- 13 30 output :- The angle between hour hand and minute hand is 135 degrees
             * 
             */

            double hourDegrees = (hours * 30) + (mins * 30.0 / 60);
            double minuteDegrees = mins * 6;

            double diff = Math.Abs(hourDegrees - minuteDegrees);

            if (diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine("The angle between hour hand and minute hand is {0} degrees", diff);
        }
    }
}
