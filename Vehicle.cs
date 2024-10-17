using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_quiz_2
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public abstract void Accelerate();
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");

        }

        public override void Accelerate()
        {
            Console.WriteLine("Car is accelerating");
        }
    }

    public class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started");

        }

        public override void Accelerate()
        {
            Console.WriteLine("Bike is accelerating");
        }
    }
}
