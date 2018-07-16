using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Car car = new Car();
            car.Make = "Chevy";
            car.Model = "Camaro";
            car.id = 637731;
            car.Year = DateTime.Now;

            SuperCar mySuperCar = new SuperCar();
            
            mySuperCar.nitrous = true;
            mySuperCar.priceTag = 100000;
            mySuperCar.topSpeed = 240;
            mySuperCar.Make = "Tesla";
            mySuperCar.Model = "model x";

            Console.WriteLine("the price of this car is " mySuperCar.priceTag);
            Console.WriteLine("the topspeed of this caris " mySuperCar.topSpeed);
            Console.WriteLine("The nitrous function being used on this car is " mySuperCar.nitrous);

        }
    }
}
