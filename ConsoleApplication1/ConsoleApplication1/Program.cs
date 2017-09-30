using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRefactor
{
    class Program
    {
        /// <summary>
        /// This application violate the SOLID design principle, that's why it's got exception, use the best of your refactoring skill to refactor this code to comply SOLID design principle
        /// You're welcome to add as many as class you want to solve the problem
        /// </summary>
        /// <param name="args"></param>
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
                Console.ReadLine();
            }
        }
    }
}
