using System;

namespace Attributes
{
    [DebugInfo(65, "JohnyLica", "22/03/2017", Message = "Class is working well")]
    [Serializable]
    public class Computer
    {
        private readonly int _cpu;
        private readonly double _frequency;
        private readonly string _name;
        private readonly int _threads;

        [DebugInfo(54, "JohnyLica", "27/03/2017", Message = "Need Constructor with 4 parameters")]
        public Computer(string n, int c, double f)
        {
            _name = n;
            _cpu = c;
            _frequency = f;
        }

        public Computer(string n, int c, double f, int t)
        {
            _name = n;
            _cpu = c;
            _frequency = f;
            _threads = t;
        }

        [Obsolete("This method is old", true)]
        public double CalculateOperation()
        {
            return _cpu*_frequency;
        }

        public double CalculateNewOperation()
        {
            return _cpu*_frequency*_threads;
        }

        [DebugInfo(22, "JohnyLica", "28/03/2017")]
        public void Display()
        {
            Console.WriteLine("Name of CPU : {0}", _name);
            Console.WriteLine("Number of cores : {0}", _cpu);
            Console.WriteLine("Frequency of CPU : {0}", _frequency);
            Console.WriteLine("Number of operation {0}", CalculateNewOperation());
        }
    }
}