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

            /*      //задание ДЗ №5
            
            Console.Write("Enter the color's number of rainbow: ");

            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Red");
                    break;
                case 2:
                    Console.WriteLine("Orange");
                    break;
                case 3:
                    Console.WriteLine("Yellow");
                    break;
                case 4:
                    Console.WriteLine("Green");
                    break;
                case 5:
                    Console.WriteLine("Light Blue");
                    break;
                case 6:
                    Console.WriteLine("Blue");
                    break;
                case 7:
                    Console.WriteLine("Violet");
                    break;
                default:
                    Console.WriteLine("Write 1-7");
                    break;
            }

            */


            /*      //задание ДЗ №4
            
            Console.Write("Enter the temperature: ");

            int t = Convert.ToInt32(Console.ReadLine());

            if (t > -5)
            {
                Console.WriteLine("Warm");
            }
            else if (t <= -5 && t > -20)
            {
                Console.WriteLine("Normal");
            }
            else if (t <= -20)
            {
                Console.WriteLine("Cold");
            }
            
            */


            /*      //задание ДЗ №3
            
            Console.Write("Enter the number: ");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a %2 == 0)
            {
                Console.WriteLine("This number is EVEN");
            }
            else
            {
                Console.WriteLine("This number is ODD");
            }

            */


            /*      //задание ДЗ №2
            
            Console.Write("Enter the number of month: ");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1 || a == 2 || a == 12)
            {
                Console.WriteLine("Winter");
            }
            else if (a == 3 || a == 4 || a == 5) 
            {
                Console.WriteLine("Spring");
            }
            else if (a == 6 || a == 7 || a == 8)
            {
                Console.WriteLine("Spring");
            }
            else if (a == 9 || a == 10 || a == 11)
            {
                Console.WriteLine("Spring");
            }
            else 
            {
                Console.WriteLine("Wrong number of month");
            }

            */


            /*              //задание ДЗ №1
            switch (a) 
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("Write 1-12");
                    break;
            }
            */


            /*    int a = 23;
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
            */


        }

    }
        
}

