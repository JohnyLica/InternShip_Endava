using System;
using System.Text.RegularExpressions;

namespace JL_Intership_Day21_03
{
    public class ArrayTest
    {
        public void PrintArray()
        {
            var storage = new string[5];
            Console.WriteLine("Please insert the data");

            for (var i = 0; i < storage.Length; i++)
            {
                storage[i] = Console.ReadLine();
            }

            foreach (var s in storage)
            {
                Console.WriteLine(s);
            }
        }

        public bool IsPalindrome()
        {
            char[] palindrome = {};
            char[] sortedPalindrome = {};
            Console.WriteLine("Enter string:");

            var readLine = Console.ReadLine();
            if (readLine != null) palindrome = readLine.ToCharArray();
            if (Regex.IsMatch(palindrome.ToString(), @"^[a-zA-Z]+$"))
            {
                sortedPalindrome = palindrome;
            }
            
            palindrome = sortedPalindrome;
            for (var i = 0; i < palindrome.Length - 1; i++)
            {
                if (palindrome[i] == palindrome[palindrome.Length - i - 1])
                {
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public void SortArray()
        {
            Console.WriteLine("Input length of array");
            var readnumber = Console.ReadLine();
            var array = new int[int.Parse(readnumber)];
            Console.WriteLine("Input numbers");
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach (var i in array)
            {
                Console.Write("\t{0}", i);
            }

            for (var i = array.Length - 1; i > 0; i--)
            {
                for (var j = 0; j <= i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var highValue = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = highValue;
                    }
                }
            }

            Console.WriteLine("\n");
            foreach (var i in array)
            {
                Console.Write("\t{0}", i);
            }
        }

        public void MaxNumber()
        {
            Console.WriteLine("Input length of array");
            var readnumber = Console.ReadLine();
            var array = new int[int.Parse(readnumber)];
            Console.WriteLine("Input numbers");
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var maxnumber = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > maxnumber)
                {
                    maxnumber = array[i];
                }
            }
            Console.WriteLine("\nMax number is {0}", maxnumber);
        }

        public void PrintNumber()
        {
            Console.WriteLine("Input number: ");
            var number = int.Parse(Console.ReadLine());

            for (var i = 1; i <= number; i++)
            {
                var multiply10 = i*10;
                var multiply100 = i*100;
                Console.WriteLine("\nN" + " N*10" + " N*100");
                Console.WriteLine("{0} {1}   {2}", i, multiply10, multiply100);
            }
        }
    }
}