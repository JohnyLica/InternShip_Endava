using System;
using System.Linq;

namespace JL_Intership_Day21_03
{
    public class ArrayProcesser
    {
        public bool CheckForOneOrFour()
        {
            Console.WriteLine("Input length of array");
            var readnumber = Console.ReadLine();
            var array = new int[int.Parse(readnumber)];
            Console.WriteLine("Input numbers");
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            return array.Any(t => t == 1 || t == 4);
        }

        public bool CheckForOneOrTwoAfterOne()
        {
            Console.WriteLine("Input length of array");
            var readnumber = Console.ReadLine();
            var array = new int[int.Parse(readnumber)];
            Console.WriteLine("Input numbers");
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                {
                    for (var j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] == 1 || array[j] == 2)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int EvenNumber()
        {
            Console.WriteLine("Input length of array");
            var readnumber = Console.ReadLine();
            var array = new int[int.Parse(readnumber)];
            Console.WriteLine("Input numbers");
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array.Count(t => t%2 == 0);
        }
    }
}