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

            decimal c = 18;
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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
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
        }
    
    }
        
}

