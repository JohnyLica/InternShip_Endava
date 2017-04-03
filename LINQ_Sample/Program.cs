using System;

namespace LINQ_Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press Enter to continue or Type Exit to close the app...");
                if (Console.ReadLine() == "Exit") break;
                Console.WriteLine("Insert Method Name: ");
                var type = typeof (LinqArray);
                var method = type.GetMethod(Console.ReadLine());
                var task = new LinqArray();
                method.Invoke(task, null);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}