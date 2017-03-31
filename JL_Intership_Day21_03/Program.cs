using System;

namespace JL_Intership_Day21_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new ArrayTest();
            array.PrintArray();
            var verify = array.IsPalindrome();
            Console.WriteLine(verify);
            array.SortArray();
            array.MaxNumber();
            array.PrintNumber();

            var saver1 = new SavingsAccount { SavingsBalance = 2000 };
            var saver2 = new SavingsAccount { SavingsBalance = 3000 };
            SavingsAccount.AnnualInterestRate = 4;
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();

            Console.WriteLine("Saver1 balance is {0}", saver1.SavingsBalance);
            Console.WriteLine("Saver2 balance is {0}", saver2.SavingsBalance);

            SavingsAccount.AnnualInterestRate = 5;
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();

            Console.WriteLine("Saver1 balance is {0}", saver1.SavingsBalance);
            Console.WriteLine("Saver2 balance is {0}", saver2.SavingsBalance);

            var cars = new CarBrand();
            cars.NextElement();
            cars.PreviousElement();
            cars.ShowAll();

            var arrayProcesser = new ArrayProcesser();
            var state = arrayProcesser.CheckForOneOrFour();
            Console.WriteLine(state);

            var state1 = arrayProcesser.CheckForOneOrTwoAfterOne();
            Console.WriteLine(state1);
            var evenNumber = arrayProcesser.EvenNumber();
            Console.WriteLine("The total of even numbers are {0}", evenNumber);

            var checkEngine = new Car.Engine();
            checkEngine.Check();
            var checkWheel = new Car.Wheel();
            checkWheel.Check();

            Console.ReadKey();
        }
    }
}