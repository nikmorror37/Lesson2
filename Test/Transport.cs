using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class Transport
    {
        public abstract int Speed { get; set; }
        public abstract void Move();
        public abstract void Stop();

    }

    class Car1 : Transport
    {
        public override int Speed { get; set; } = 90;

        public override void Move()
        {
            Console.WriteLine("Car is driving");
        }
        public override void Stop()
        {
            Console.WriteLine("Stop for 30m");
        }

    }

    class Plane : Transport
    {
        public override int Speed { get; set; } = 800;

        public override void Move()
        {
            Console.WriteLine("Plane is flying");
        }
        public override void Stop()
        {
            Console.WriteLine("Stop on the land");
        }

    }

    class Train : Transport
    {
        public override int Speed { get; set; } = 120;

        public override void Move()
        {
            Console.WriteLine("Train is moving");
        }
        public override void Stop()
        {
            Console.WriteLine("Stop so long");
        }

    }
}
