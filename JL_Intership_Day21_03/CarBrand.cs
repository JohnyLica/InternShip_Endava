using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace JL_Intership_Day21_03
{
    public class CarBrand
    {
        public void ShowAll()
        {
            var values = Enum.GetValues(typeof (Cars));
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }

        public void PreviousElement()
        {
            Console.WriteLine("Input the car: ");
            var value = (Cars) Enum.Parse(typeof (Cars), Console.ReadLine());
            try
            {
                var previousvalue = Enum.GetValues(typeof (Cars)).Cast<Cars>().TakeWhile(x => x != value).Last();
                Console.WriteLine(previousvalue);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No such Element");
            }
        }

        public void NextElement()
        {
            Console.WriteLine("Input the car: ");
            var value = (Cars) Enum.Parse(typeof (Cars), Console.ReadLine());
            try
            {
                var nextValue = Enum.GetValues(typeof (Cars)).Cast<Cars>().SkipWhile(x => x != value).Skip(1).First();
                Console.WriteLine(nextValue);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No such Element");
            }
        }

        private enum Cars
        {
            Bmw,
            Mercedes,
            Nissan,
            Bugati
        }
    }
}