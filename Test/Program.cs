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
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine(str);
            a = a + 23;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            string json = JsonConvert.SerializeObject(str);

            Console.Write("Hello");
            Console.WriteLine("World!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine(":))");

        }
    
    }
        
}

