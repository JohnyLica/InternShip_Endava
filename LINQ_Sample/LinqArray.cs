using System;
using System.Linq;

namespace LINQ_Sample
{
    public class LinqArray
    {
        public static readonly int[] Numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

        public static readonly string[] Digits =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            "nine"
        };

        private static readonly int[] NumbersA = {0, 2, 4, 5, 6, 8, 9};
        private static readonly int[] NumbersB = {1, 3, 5, 7, 8};

        private readonly string[] _words =
        {
            "aPPLE", "BlUeBeRrY", "cHeRry"
        };

        public void Linq01()
        {
            var resultNumbers = Numbers.Where(x => x < 5);
            foreach (var resultNumber in resultNumbers)
            {
                Console.WriteLine(resultNumber);
            }
        }

        public void Linq02()
        {
            var resultSequence = Numbers.Select(s => s + 1);
            foreach (var i in resultSequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq03()
        {
            var shortValue = Digits.Where((digit, index) => digit.Length < index);
            foreach (var sValue in shortValue)
            {
                Console.WriteLine("The word {0} is shorter than its value.", sValue);
            }
        }

        public void Linq04()
        {
            var upperLowerCase = _words.Select(s => new {Upper = s.ToUpper(), Lower = s.ToLower()});
            foreach (var word in upperLowerCase)
            {
                Console.WriteLine(word);
            }
        }

        public void Linq05()
        {
            var sample = from n in Numbers select Digits[n];
            foreach (var n in sample)
            {
                Console.WriteLine(n);
            }
        }

        public void Linq06()
        {
            var upAndLowerOriginal = _words.Select(s => new {Uppercase = s.ToUpper(), Lowercase = s.ToLower()});
            foreach (var word in upAndLowerOriginal)
            {
                Console.WriteLine(word);
            }
        }

        public void Linq07()
        {
            var evenOrOdd = from n in Numbers select new {Number = Digits[n], isEven = n%2};
            foreach (var nu in evenOrOdd)
            {
                Console.WriteLine("The digit {0} is {1}", nu.Number, nu.isEven == 1 ? "odd" : "even");
            }
        }

        public void Linq08()
        {
            var matchPosition = from n in Numbers select new {Number = n, isMatch = n == Numbers[n]};
            foreach (var numb in matchPosition)
            {
                Console.WriteLine("{0}:{1}", numb.Number, numb.isMatch);
            }
        }

        public void Linq09()
        {
            var biggerThanFive = from n in Numbers where n < 5 select Digits[n];
            foreach (var number in biggerThanFive)
            {
                Console.WriteLine(number);
            }
        }

        public void Linq10()
        {
            var joinArray = from a in NumbersA
                from b in NumbersB
                where a < b
                select new {Number1 = a, Number2 = b};

            foreach (var pair in joinArray)
            {
                Console.WriteLine("{0} is less than {1}", pair.Number1, pair.Number2);
            }
        }

        public void Linq11()
        {
            var sequence = Numbers.Take(3);
            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq12()
        {
            var sequence = Numbers.Skip(4).Take(4);
            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq13()
        {
            var sequence = Numbers.TakeWhile()
        }
    }
}