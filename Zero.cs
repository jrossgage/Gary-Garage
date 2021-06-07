using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Zero zips by. Ruuurrrrrrrnppptt!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {base.MainColor} Zero veers to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Zero slows to a halt");
        }
    }
}