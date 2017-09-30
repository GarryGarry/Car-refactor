using System;

namespace CarRefactor
{
    // Changed this class to abstract becuase it can be implemented in other classes
    public abstract class Car
    {    
        public bool HasHeatedChairMassage { get; protected set; }
        public int YearBuilt { get; protected set; }
        public string VehicleMake { get; protected set; }
        public int Odometer { get; protected set; }

        public abstract void TurnOnHeatedChairMassage();
        public abstract void Accelerate();
      
        // Moved this constructor to base class so it can be used by all the child classes inheriting from this class
        protected Car(int yearBuilt, string vehicleMake, string brandName)
        {
            YearBuilt = yearBuilt;
            VehicleMake = vehicleMake;

            // Only objects which has heated chair can turn on this functionality like mercedes.  
            HasHeatedChairMassage = false;
            Console.WriteLine(string.Format("===== {0} {1} - {2}", brandName, YearBuilt, VehicleMake));
        }

        // moved them to base class so they can be used by both toyota and Mercedes objects
        public virtual int GetYearBuilt()
        {
            Console.WriteLine(string.Format("Year built is {0} ******************working", YearBuilt));
            return YearBuilt;
        }

        public virtual string GetVehicleMake()
        {
            Console.WriteLine(string.Format("Car make is {0}", VehicleMake));
            return VehicleMake;
        }
    }
}
