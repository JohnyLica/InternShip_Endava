using System;

namespace LINQ_Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                if (Console.ReadLine() == "exit") break;
                Console.WriteLine("Insert Task number: ");
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