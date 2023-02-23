using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Triangle : Figure
    {
        public int Side { get; set; }
        public int Height { get; set; }

        public override string Color
        {
            get => "Жёлтый"; //стрелочная функция
        }

        public Triangle(int side, int height, string name) : base(name)
        {
            Side = side;
            Height = height;
        }

        public override void ShowSquare()
        {
            Console.WriteLine($"площадь {Color} {Name}:{Square(Side, Height)}");
        }
        //Те методы и свойства, которые мы хотим сделать доступными для переопределения, в базовом классе помечается модификатором virtual. Такие методы виртуальными.

        //А чтобы переопределить метод в классе-наследнике, этот метод определяется с модификатором override. Переопределенный метод в классе-наследнике должен иметь тот же набор параметров, что и виртуальный метод в базовом классе.

        private int Square(int x, int y)
        {
            return Side * Height / 2;
        }
    }
}
