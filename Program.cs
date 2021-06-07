using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram dodge = new Ram();
            fxs.MainColor = "blue";
            modelS.MainColor = "red";
            mx410.MainColor = "yellow";
            dodge.MainColor = "black";

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            dodge.Drive();

            fxs.Turn("Right");
            modelS.Turn("Right");
            mx410.Turn("Left");
            dodge.Turn("Left");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            dodge.Stop();


        }
    }
}
