using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Attributes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var computer = new Computer("Intel i7", 4, 4.0, 4);
            computer.Display();

            Stream stream = File.Open("data.xml", FileMode.Create);
            var formatter = new SoapFormatter();

            formatter.Serialize(stream, computer);
            stream.Close();

            Console.ReadLine();
        }
    }
}