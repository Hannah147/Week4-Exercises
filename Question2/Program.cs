using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Week4_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.6;

            Car c2 = new Car();
            c2.Make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            c1.DisplayCarInfo();

            WriteLine(c2.ToString());

            for (int counter = 0; counter < 10; counter++)
            {
                c1.Accelerate();
            }

            WriteLine(c1);
        }
    }

    class Car
    {
        private string make;
        private string model;
        private int currentSpeed;
        private double engineSize;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }

        public void DisplayCarInfo()
        {
            WriteLine($"\nCar Make \t: {Make}");
            WriteLine($"Car Model \t: {Model}");
            WriteLine($"Current Speed \t: {CurrentSpeed} km/h");
            WriteLine($"Engine Size \t: {EngineSize}\n");
        }

        public override string ToString()
        {
            return "\nCar Make \t: " + make + "\nCar Model \t: " + model + "\nCurrent Speed \t: " + currentSpeed + "\nEngine Size \t: " + engineSize + "\n";
        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
            WriteLine($"Current Speed is : {CurrentSpeed} km/h");
        }
    }
}
