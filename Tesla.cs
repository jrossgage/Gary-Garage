using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {base.MainColor} Tesla sccots across. EEEeeep!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {base.MainColor} Tesla skids off to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Tesla is drained and stops.");
        }
    }
}
