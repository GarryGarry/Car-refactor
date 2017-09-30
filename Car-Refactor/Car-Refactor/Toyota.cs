using System;

namespace CarRefactor
{
    public class Toyota : Car
    {
        // created a constant String property 

        private const string brandName = "Toyota";

        public Toyota(int yearBuilt, string vehicleMake) : base(yearBuilt, vehicleMake, brandName)
        {
        }

        public override void TurnOnHeatedChairMassage()
        {
            throw new Exception("This feature is not available");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Accelerating.....");
        }

    }
}
