using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Cessna flies by. Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {base.MainColor} Cessna banks over to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Cessna gracefully halts on the ground.");
        }
    }
}