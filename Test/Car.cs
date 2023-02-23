using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Car
    {
        public string brand; //= "Renault";
        public int age; //= 2017;
        public int wheels; // = 4;
        private int speed;
        private double timeFirst;
        private double timeSecond;
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

        //свойства
        //public int Age
        //{
        //    get { return age; }

        //    set
        //    {
        //        if (value < 1970 || value > 2023)
        //            Console.WriteLine("Year of production between 1970 & 2023");
        //        else
        //            age = value;
        //    }
        //}

        //автосвойства

        //[модификатор доступа] тип имя { get; set; }

        //public string Brand { get; set; }
        //public int Age { get; set; }

        //public Car(string brand, int age)
        //{
        //    Brand = brand;
        //    Age = age;
        //}



        //Иногда возникает необходимость создать один и тот же метод, но с разным набором параметров.Это называется перегрузкой методов.
        //Сигнатура метода складывается из следующего:
        //*Имя метода
        //*Количество параметров
        //*Типы параметров
        //*Порядок параметров
        //*Модификаторы параметров
        //Перегрузка метода это когда методы имеют разную сигнатуру, в которой совпадает только название метода.
        public void Distance(int speed)
        {
            Console.WriteLine($"Со средней скоростью {speed} км/ч водитель доедет до Бреста за 2 часа");
        }
        public void Distance (int speed, double timeFirst)
        {
            int dist = (int) (speed * timeFirst);
            Console.WriteLine(speed + " км/ч");
            Console.WriteLine($"{dist} км занял весь путь");
        }

        public void Distance (double timeFirst, int speed)
        {
            double dist = 500;
            double timeSecond = dist/speed;
            double timeOveral = timeFirst + timeSecond;
            Console.WriteLine($"Время в пути с перерывом {timeFirst} + {timeSecond} равно {timeOveral} часам");
        }

    }
}
