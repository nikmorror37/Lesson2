using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    struct IntroStruct
    {
        public void Intro()
        {
            Console.WriteLine("Добро пожаловать в наш интернет-банкинг");
        }

        public void Loading()
        {
            Console.WriteLine("Загрузка");
            for (int i = 0; i < 4; i++)
            {
                Console.Write('#');
                Thread.Sleep(375);
            }
        }







    }
}
