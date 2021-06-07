using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Ram drives past. Vrroommvv!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {base.MainColor} Ram hauls {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Ram stops suddenly.");
        }
    }
}
