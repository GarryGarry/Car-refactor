using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Mercedes(2017,"GLS 63 AMG"),
                new Toyota(2002,"Corolla GX"),
            };

            foreach (Car car in cars)
            {
                car.Accelerate();
                if (car.HasHeatedChairMassage)
                {
                    car.TurnOnHeatedChairMassage();
                }
               
            }
        }
    }
}
