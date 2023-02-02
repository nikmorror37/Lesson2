// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace Test
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            int a = 23;
            string str = "Slovo";
            bool b = true;

            double c = 18;
            int d = 5;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine(str);
            a = a + 23;
            Console.WriteLine(a);
            //Console.WriteLine("Hello, World!(1)");//
            Console.WriteLine("Hello, World!(2)");

            string json = JsonConvert.SerializeObject(str);

            Console.Write("Multiply of numbers:");
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);
            Console.Write("Hello");
            Console.WriteLine(" World!(3)");
           
            /*
              Example of comments
             */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();  // вводим имя
            if (name == "")
            {
                Console.WriteLine("Empty name");
            }
            else if (name == " ")
            {
                Console.WriteLine("Empty name");
            }
            else
            {
                Console.Write("Learn and practise, ");
                Console.Write(name);
                Console.WriteLine(" ;)");
            }

            Console.Write("Enter your weight : ");
            int weight = Convert.ToInt32(Console.ReadLine());

            string nickname = "Tomas";

            switch (nickname)
            {
                case "Nikita":
                    Console.WriteLine("Your name is Nikita");
                    break;
                case "Tomas":
                    Console.WriteLine("Your name is Tomas");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

           
            Console.WriteLine(Math.Pow(5, 2));
            

        }
    
    }
        
}

