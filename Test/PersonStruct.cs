using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    struct WarriorStruct
    {
        public string sword;
        public string shield;
        public int armor;

        public WarriorStruct(string sword, string shield, int armor)
        {
            this.sword = sword;
            this.shield = shield;
            this.armor = armor;
        }

        public WarriorStruct()
        {
            sword = "МЕЧ";
            shield = "ЩИТ";
            armor = 86;
        }
        public void Print()
        {
            Console.WriteLine($"Воин использует {sword} & {shield} в битве, начальная броня составляет {armor} %");
        }

    }
}
