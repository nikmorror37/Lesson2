// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System;
using System.Text;
using System.Text.Json.Serialization;


namespace Test
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = Encoding.UTF8;

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

            /*
            //Lesson 4

            for (; ; )  //бесконечный цикл
            {
                Console.WriteLine($"Квадрат числа");
            }
            */

            //бесконечный цикл
            //do
            //{
            //    Console.WriteLine("test");
            //} while (true);

            /*
            Console.WriteLine("Введите сумму вклада: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());    
            Console.WriteLine("Введите период вклада: ");
            int period = Convert.ToInt32(Console.ReadLine());   

            for (int i = 1; i <= period; i++)
            {
                sum += sum * 0.12M;
            }
            Console.WriteLine($"После {period} месяцев сумма вклада составит {sum}");
            Console.ReadKey();
            */

            /* int i = 12;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > 0);
            */

            /*
            int i = 1;
            int n = 7;
            int result;

            do
            {
                result = n * i;
                Console.WriteLine($"{i} * {n} = {result}");
                i++;
            }
            while (i <= 100);
            */

            /*
            Console.WriteLine("Введите сумму вклада: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите срок вклада в месяцах: ");
            int period = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= period)
            {
                sum += sum * 0.12M;
                i++;
            }
            Console.WriteLine($"После {period} месяцев сумма вклада составит {sum}");
            Console.ReadKey();
            */

            // operator GOTO - возвращает в точку, что указано после него
            //link1:
            //        Console.Write("Privet");
            //        Console.Write("Nick");
            //        goto link1;


            //break завершает цикл полностью 
            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //сontinue прерывает одну итерацию (в цикле), если возникает указанное условие,
            //и продолжает следующую итерацию в цикле.
            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            //массивы
            /*
            string[] stringArrayTwo = new string[4];

            int[] nums1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] nums2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(nums2.Length);
            int[] nums3 = { 1, 2, 3, 4, 5 };
            int[] nums4 = { 1, 2, 3, 5, 6, 7, 8 };

            //Все перечисленные выше способы будут равноценны.

            double[] nums5 = new double[5] { 1, 3, 5, 7, 9 };
            nums5[0] = 3.3;
            nums5[1] = 4.3;
            nums5[2] = 5.3;

            var n = nums5[3];
            //Console.WriteLine(n);

            */
            //int[] numbers = { 1, 2, 3, 4, 5, 8 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = numbers[i] * 2;
            //    Console.WriteLine(numbers[i]);
            //}

            //            string[] substr = {"HellO","Boss","King" };
            //            foreach (string item in substr)
            //            {
            //                Console.WriteLine($"{item}");
            //            }
            //            foreach (int item in numbers)
            //            {
            //                Console.WriteLine($"{item}");
            //            }


            //Двумерные массивы

            //int[,] nums1;
            //int[,] nums2 = new int[2, 3];
            //int[,] nums3 = new int[2, 4] { { 1, 2, 3, 4 }, { 4, 5, 6, 7 } };

            //double[,] nums4 = new double [2, 5] { { 1.0, 2.0, 3.0, 4.0, 5.0 }, { 6.0, 7.0, 8.0, 9.0, 9.5 } };
            //Console.WriteLine(nums4[0, 3]);//4
            //Console.WriteLine(nums4[1, 3]);//9

            //int[,] numbers = { { 2, 3 }, { 4, 5 } };

            //// старый элемента
            //Console.WriteLine("Old element at index [0, 0] : " + numbers[1, 1]);

            //// присваивание нового значения
            //numbers[1, 1] = 50;

            //// новый элемент
            //Console.WriteLine("New element at index [0, 0] : " + numbers[1, 1]);


            //int[,] myArr = new int[4, 5];

            //Random ran = new Random();

            ////Инициализируем данный массив
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        myArr[i, j] = ran.Next(1, 15);
            //        Console.Write($"{myArr[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}


            //Трёхмерные массивы

            //int[,,] nums6 = new int[2, 3, 4];


            //Зубчатый массив 

            //int[][] numbers = new int[3][];
            //numbers[0] = new int[] { 1, 2 };
            //numbers[1] = new int[] { 1, 2, 3 };
            //numbers[2] = new int[] { 1, 2, 3, 4, 5 };
            //foreach (int[] row in numbers)
            //{
            //    foreach (int number in row)
            //    {
            //        Console.Write($"{number} \t");
            //    }
            //    Console.WriteLine();
            //}


        }

    }
        
}

