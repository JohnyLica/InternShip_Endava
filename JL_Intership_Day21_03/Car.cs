using System;

namespace JL_Intership_Day21_03
{
    public class Car
    {
        public class Engine
        {
            public void Check()
            {
                var stateOil = new Oil();
                var statePetrol = new Petrol();
                if (statePetrol.Fuel <= 300 || stateOil.Oiltype == "Esen")
                {
                    Console.WriteLine("Car is good to drive");
                }
            }

            private class Oil
            {
                private readonly string _oiltype = "Esen";

                public string Oiltype
                {
                    get { return _oiltype; }
                }
            }

            private class Petrol
            {
                private readonly int _fuel = 300;

                public int Fuel
                {
                    get { return _fuel; }
                }
            }
        }

        public class Wheel
        {
            public void Check()
            {
                var wheelState = new State();
                var wheelPressure = new Pressure();
                if (Math.Abs(wheelPressure.Press - 2.1) < 0.0001 || wheelState.StateWheel)
                {
                    Console.WriteLine("Car is ready for offroad");
                }
            }

            private class State
            {
                private readonly bool _stateWheel = true;

                public bool StateWheel
                {
                    get { return _stateWheel; }
                }
            }

            private class Pressure
            {
                private readonly double _press = 2.2;

                public double Press
                {
                    get { return _press; }
                }
            }
        }
    }
}