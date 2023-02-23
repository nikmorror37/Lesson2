using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

        class Reader : IBook
        {
            public void Read()
            {
                Console.WriteLine("Our reader is reading the book");
            }
            public void Record()
            {
                Console.WriteLine("Tom has recorded this lesson");
            }
    }
}
