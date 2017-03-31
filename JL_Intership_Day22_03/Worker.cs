using System;

namespace JL_Intership_Day22_03
{
    public class Worker
    {
        public int Id;
        public string Name;

        public int FixedPayment { get; set; }

        public int HourPayment { get; set; }

        public double AverageSalary()
        {
            if (HourPayment != 0)
            {
                return 20.8*8*HourPayment;
            }
            return FixedPayment;
        }

        public static Worker InsertWorker()
        {
            Console.WriteLine("Enter ID");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Fixed Payment");
            var fixedPayment = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hour Payment");
            var hourPayment = int.Parse(Console.ReadLine());

            var worker = new Worker
            {
                Id = id,
                Name = name,
                FixedPayment = fixedPayment,
                HourPayment = hourPayment
            };
            return worker;
        }

        public static void ShowMenuWorker()
        {
            Console.WriteLine("1. Add Workers");
            Console.WriteLine("2. Sort DESC by the average monthly salary");
            Console.WriteLine("3. Show first 5 workers names");
            Console.WriteLine("4. Show last 3 workers ID");
        }
    }
}