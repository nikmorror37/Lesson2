using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Car
    {
        public string brand; //= "Renault";
        public int age; //= 2017;
        public int wheels; // = 4;
        public string driver;
        //public int height = 210;
        //public int width = 330;
        public const string typeCar = "Jeep"; //never changed
        public readonly string name = "undefined";

        public Car(string brandInit, int ageInit, int circleCountInit, string driverInit) //constructor
        { 
            brand = brandInit;
            age = ageInit;
            wheels = circleCountInit;
            driver = driverInit;
        }    

        public void Drive()
        {
            Console.WriteLine($"Name of car {brand}, year of produced {age}, have {wheels} wheels");
            Console.WriteLine($"{driver} is the driver of this car");
        }

        public int MultiCar(int height, int width)
        {
            Console.WriteLine($"height {brand}, width {wheels}");
            int result = height * width;
            return result;
        }


    }
}
