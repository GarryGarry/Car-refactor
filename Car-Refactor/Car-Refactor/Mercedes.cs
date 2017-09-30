using System;

namespace CarRefactor
{
    public class Mercedes : Car
    {
        private const string brandName = "Mercedes";

        public Mercedes(int yearBuilt, string vehicleMake) : base(yearBuilt, vehicleMake, brandName)
        {
            HasHeatedChairMassage = true;
        }

        public override void TurnOnHeatedChairMassage()
        {

            Console.WriteLine("Massage Chair is warming up...");
            Console.WriteLine("Chair position checking ...");
            Console.WriteLine("Setting massage mode...");
            Console.WriteLine("Start massaging...");
        }

        public override void Accelerate()
        {

            Console.WriteLine("Check vehicle surround via 360 degree camera...");
            Console.WriteLine("Check speed zone");
            Console.WriteLine("Safe to accelerate");
            Console.WriteLine("Accelerating.....");
        }
    }
}
