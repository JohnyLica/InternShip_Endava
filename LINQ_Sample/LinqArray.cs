using System;
using System.Linq;

namespace LINQ_Sample
{
    public class LinqArray
    {
        public static readonly int[] Numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        public static readonly int[] Numbers1 = {1, 11, 3, 19, 41, 65, 19};

        public static readonly string[] Digits =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            "nine"
        };

        private static readonly int[] NumbersA = {0, 2, 4, 5, 6, 8, 9};
        private static readonly int[] NumbersB = {1, 3, 5, 7, 8};

        private readonly string[] _anagrams = {"from   ", " salt", " earn ", "  last   ", " near ", " form  "};

        private readonly int[] _attemptedWithdrawals = {20, 10, 40, 50, 10, 70, 30};

        private readonly double[] _doubles = {1.7, 2.3, 1.9, 4.1, 2.9};

        private readonly int[] _factorsOf300 = {2, 2, 3, 5, 5};

        private readonly string[] _words =
        {
            "aPPLE", "BlUeBeRrY", "cHeRry"
        };

        private readonly string[] _words2 = {"cherry", "apple", "blueberry"};


        private readonly string[] _words3 = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

        private readonly string[] _words4 = {"blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese"};
        private readonly string[] _words5 = {"believe", "relief", "receipt", "field"};

        private readonly string[] _wordsA = {"cherry", "apple", "blueberry"};
        private readonly string[] _wordsB = {"cherry", "apple", "blueberry"};

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
            Console.Write("Insert the number: ");
            var number = int.Parse(Console.ReadLine());
            var sequence = Numbers.TakeWhile(x => x < number);
            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq14()
        {
            var sequence = Numbers.TakeWhile((n, index) => n >= index);
            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq15()
        {
            var sequence = Numbers.SkipWhile(x => x%3 != 0);
            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq16()
        {
            var sequence = Numbers.SkipWhile((n, index) => n >= index);
            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq17()
        {
            var sequence = _words2.OrderBy(x => x);
            foreach (var i in sequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq18()
        {
            var sequence = _words2.OrderBy(x => x.Length);
            foreach (var u in sequence)
            {
                Console.WriteLine(u);
            }
        }

        public void Linq19()
        {
            var sequnce = _words3.OrderBy(x => x);
            foreach (var u in sequnce)
            {
                Console.WriteLine(u);
            }
        }

        public void Linq20()
        {
            var sequence = _doubles.OrderByDescending(x => x);
            foreach (var d in sequence)
            {
                Console.WriteLine(d);
            }
        }

        public void Linq21()
        {
            var sequence = _words3.OrderByDescending(a => a).ThenByDescending(a => a, new SortString());
            foreach (var w in sequence)
            {
                Console.WriteLine(w);
            }
        }

        public void Linq22()
        {
            var digitalSequence = Digits.OrderBy(a => a.Length).ThenBy(a => a);
            foreach (var digit in digitalSequence)
            {
                Console.WriteLine(digit);
            }
        }

        public void Linq23()
        {
            var sequence = _words3.OrderBy(a => a.Length).ThenBy(a => a, new SortString());
            for (var i = 0; i < 2; i++)
            {
                foreach (var w in sequence)
                {
                    Console.WriteLine(w);
                }
            }
        }

        public void Linq24()
        {
            var reversedDigits = (from d in Digits where d[1] == 'i' select d).Reverse();
            Console.WriteLine("A backwards list  of the digits with the a second character of 'i': ");
            foreach (var reversedDigit in reversedDigits)
            {
                Console.WriteLine(reversedDigit);
            }
        }

        public void Linq25()
        {
            var sequenceNumber = from n in Numbers
                group n by n%5
                into g
                select new {Remainder = g.Key, Number = g};
            foreach (var g in sequenceNumber)
            {
                Console.WriteLine("Numbers  with a remainder of {0} when divided by 5:", g.Remainder);
                foreach (var i in g.Number)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Linq26()
        {
            var wordSequence = from n in _words4
                group n by n[0]
                into w
                select new {FirstLetter = w.Key, WordGroup = w};

            foreach (var w in wordSequence)
            {
                Console.WriteLine("Words that start with the letter {0} :", w.FirstLetter);
                foreach (var wd in w.WordGroup)
                {
                    Console.WriteLine(wd);
                }
            }
        }

        public void Linq27()
        {
            var orderGroups = _anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());
            foreach (var g in orderGroups)
            {
                Console.WriteLine("...");
                foreach (var w in g)
                {
                    Console.WriteLine("\t" + w);
                }
            }
        }

        public void Linq28()
        {
            var upperOrderGroups = _anagrams.GroupBy(w => w.Trim(), a => a.ToUpper(), new AnagramEqualityComparer());
            foreach (var upperOrderGroup in upperOrderGroups)
            {
                Console.WriteLine("...");
                foreach (var w in upperOrderGroup)
                {
                    Console.WriteLine("\t" + w);
                }
            }
        }

        public void Linq29()
        {
            var uniqueValues = _factorsOf300.Distinct();
            Console.WriteLine("Prime numbers of 300:");
            foreach (var uniqueValue in uniqueValues)
            {
                Console.WriteLine(uniqueValue);
            }
        }

        public void Linq30()
        {
            var uniqueUnionArray = NumbersA.Union(NumbersB).Distinct();
            Console.WriteLine("Unique numbers from both arrays:");

            foreach (var i in uniqueUnionArray)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq31()
        {
            var intersectArrays = NumbersA.Intersect(NumbersB).Distinct();
            Console.WriteLine("Common numbers shared by both arrays: ");
            foreach (var intersectArray in intersectArrays)
            {
                Console.WriteLine(intersectArray);
            }
        }

        public void Linq32()
        {
            var expectSequence = NumbersA.Except(NumbersB);
            Console.WriteLine("Numbers in first array but not second array: ");
            foreach (var i in expectSequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq33()
        {
            var firstElement = Digits.First(x => x[0] == 'o');
            Console.WriteLine("A string starting with 'o' {0} :", firstElement);
        }

        public void Linq34()
        {
            var contains = _words5.Any(o => o.Contains("ei"));
            Console.WriteLine("There is a word in the list that contains 'ei': {0}", contains);
        }

        public void Linq35()
        {
            var onlyOdd = Numbers1.All(x => x%2 == 1);
            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
        }

        public void Linq36()
        {
            var uniqueFactors = _factorsOf300.Distinct().Count();
            Console.WriteLine("There are {0} unique prime factors of 300", uniqueFactors);
        }

        public void Linq37()
        {
            var oddNumbers = Numbers.Where(x => x%2 == 1).Count();
            Console.WriteLine("There are {0} odd numbers in the list", oddNumbers);
        }

        public void Linq38()
        {
            var sumNumbers = Numbers.Sum();
            Console.WriteLine("The sum of the numbers is {0}", sumNumbers);
        }

        public void Linq39()
        {
            var charNumbers = _words2.Sum(s => s.Length);
            Console.WriteLine("There are a total of {0} characters in the words", charNumbers);
        }

        public void Linq40()
        {
            var minNumber = Numbers.Min();
            Console.WriteLine("The minimum number is {0}", minNumber);
        }

        public void Linq41()
        {
            var shortLength = _words2.Min(l => l.Length);
            Console.WriteLine("The shortest word is {0} characters long", shortLength);
        }

        public void Linq42()
        {
            var maxNumber = Numbers.Max();
            Console.WriteLine("The maximum number is {0}", maxNumber);
        }

        public void Linq43()
        {
            var maxlength = _words2.Max(l => l.Length);
            Console.WriteLine("The longest word is {0} characters long", maxlength);
        }

        public void Linq44()
        {
            var average = Numbers.Average();
            Console.WriteLine("The average number is {0}", average);
        }

        public void Linq45()
        {
            var averageLength = _words2.Average(l => l.Length);
            Console.WriteLine("The average word length is {0} characters", averageLength);
        }

        public void Linq46()
        {
            const double startBalance = 100.0;
            var endBalance =
                _attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawl) => nextWithdrawl <= balance ? balance - nextWithdrawl : balance);

            Console.WriteLine("Ending balance:{0}", endBalance);
        }

        public void Linq47()
        {
            var concatSequence = NumbersA.Concat(NumbersB);
            foreach (var i in concatSequence)
            {
                Console.WriteLine(i);
            }
        }

        public void Linq48()
        {
            var matchSequence = _wordsA.SequenceEqual(_wordsB);
            Console.WriteLine("The sequences match: {0}", matchSequence);
        }

        public void Linq49()
        {
            var wordsB = new[] {"apple", "blueberry", "cherry"};
            var equalSequence = _wordsA.SequenceEqual(wordsB);
            Console.WriteLine("The sequences match: {0}", equalSequence);
        }
    }
}