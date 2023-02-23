// See https://aka.ms/new-console-template for more information
using Lesson6;
using Newtonsoft.Json;
using System;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json.Serialization;


namespace Test
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //задание ДЗ №5

            //Console.Write("Enter the color's number of rainbow: ");

            //int a = Convert.ToInt32(Console.ReadLine());

            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("Red");
            //        break;
            //    case 2:
            //        Console.WriteLine("Orange");
            //        break;
            //    case 3:
            //        Console.WriteLine("Yellow");
            //        break;
            //    case 4:
            //        Console.WriteLine("Green");
            //        break;
            //    case 5:
            //        Console.WriteLine("Light Blue");
            //        break;
            //    case 6:
            //        Console.WriteLine("Blue");
            //        break;
            //    case 7:
            //        Console.WriteLine("Violet");
            //        break;
            //    default:
            //        Console.WriteLine("Write 1-7");
            //        break;
            //}




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
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item + " До");
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = numbers[i] * 2;
            //    Console.WriteLine(numbers[i] + " После");
            //}

            //string[] substr = { "HellO", "Boss", "King" };
            //foreach (string item in substr)
            //{
            //    Console.Write(item + " ");
            //}




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


            //int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
            //// сортировка
            //int temp;
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //}

            //// вывод
            //Console.WriteLine("Вывод отсортированного массива");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            //LESSON 5

            //Console.WriteLine(char.Parse("h"));

            //char[] letters = { 'A', 'B', 'C' };
            //string alphabet = new string(letters);
            //Console.WriteLine(alphabet);
            //Console.WriteLine(alphabet.GetType());

            //string s1 = "abcdefghigklmn";
            //char ch1 = s1[4];
            //Console.WriteLine(ch1);
            //Console.WriteLine(s1.Length);
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    if (s1[i] == 'a' || s1[i] == 'd' || s1[i] == 'k')
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(s1[i]);
            //}

            //через тернарную функцию
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    Console.Write(s1[i] != 'a' && s1[i] != 'k' && s1[i] != 'd' ? s1[i].ToString() : "");
            //}


            //int number = 23;
            //string result1 = string.Format("{0:d}", number);
            //Console.WriteLine(result1); //23
            //string result2 = string.Format("{0:d6}", number);
            //Console.WriteLine(result2); //000023

            //double number3 = 23.05;
            //string result3 = string.Format("{0:f}", number3);
            //Console.WriteLine(result3);//23.05
            //double number4 = 25.1356;
            //string result4 = string.Format("{0:f3}", number4);
            //Console.WriteLine(result4); //25.136

            //decimal number = 0.15345m;
            //Console.WriteLine("{0:P2}", number); //15.35%

            //long number = 37529123456789;
            //string result = string.Format("{0:+### (##) ###-###-###}", number);
            //Console.WriteLine(result);


            //string s1 = "Hello";
            //string s2 = "World";
            //string s3 = s1 + " " + s2;
            //string s4 = string.Concat(s1, "+", s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);

            //int height = 185;
            //int weight = 78;
            //Console.WriteLine($"Вес спортсмена составил {weight} кг при росте {height} см");

            //string s1 = "Hakuna";
            //string s2 = "MATATA";
            //string s3 = (s1 + " " + s2);
            //Console.WriteLine(s3);

            //string s4 = "Cool";
            //string s5 = "Place";
            //string[] words = { s1, s2, s4, s5 };
            //string smblBtwnWrds = "&&&";

            //string s6 = string.Join(smblBtwnWrds, words);
            //Console.WriteLine(s6);

            //string stringMulti = @"abrakadabra;my
            //nameisTomShelby;mynameis;
            //        Gustavo;yaSabininaMama;HEHHEHEHE;
            //    LolKek";
            //Console.WriteLine(stringMulti);

            //string s1 = "Call";
            //string s2 = "Call";
            //string s3 = "Duty";
            //var result = s1.Equals(s2);//True 
            //var result2 = s2.Equals(s3);//False 
            //Console.WriteLine(result);
            //Console.WriteLine(result2);

            //string s1 = "hello world";
            //char ch = 'w';
            //int indexOfChar = s1.IndexOf(ch);
            //Console.WriteLine(indexOfChar);//6

            //string subString = "rld";
            //int indexOfSubstring = s1.IndexOf(subString);
            //Console.WriteLine(indexOfSubstring);//8

            //string path = @"C:\Zadanie5";
            //string[] files = Directory.GetFiles(path);
            //for (int i = 0; i < files.Length; i++)
            //{
            //    if (files[i].EndsWith(".jpg"))
            //    {
            //        File.Delete(files[i]);
            //    }
            //}


            //string text = " privet chelovek ";   ///НЕ РАБОТАЕТ, ПРОВЕРИТЬ!
            ////text = text.Trim();
            //char[] chars = new char[] { 'r', 'e' };
            //text = text.Trim(chars);
            //Console.WriteLine(text);


            //string txt = "Google chrome";
            ////txt = txt.Substring(2);
            ////Console.WriteLine(txt); //ogle chrome
            //txt = txt.Substring(0, txt.Length - 2);
            //Console.WriteLine(txt); //Google chro


            //var sb = new StringBuilder("Good Morning");
            //sb.Append("!");
            //sb.Insert(5, "sunny ");
            //sb.Replace("Morning", "Miami");//заменяем слово
            ///*sb.Remove(5, 5);*///удаляем с какого-то индекса и указываем длину удаления

            //var s = sb.ToString();
            //Console.WriteLine(s);



            //static void Swap(ref int e1, ref int e2)
            //{
            //    var temp = e1;
            //    e1 = e2;
            //    e2 = temp;
            //}

            ////сортировка пузырьком
            //static int[] BubbleSort(int[] array)
            //{
            //    var len = array.Length;
            //    for (var i = 1; i < len; i++)
            //    {
            //        Console.WriteLine($"----------------------------------------------------------------");
            //        for (var j = 0; j < len - i; j++)
            //        {
            //            Console.WriteLine($"Сравниваем {array[j]} > {array[j + 1]}");
            //            if (array[j] > array[j + 1])
            //            {
            //                Console.WriteLine($"Так как {array[j]} > {array[j + 1]} свапаем эти значения");
            //                Swap(ref array[j], ref array[j + 1]);
            //            }
            //        }
            //    }

            //    return array;
            //}

            //5 4 7 8 9 5 1 2
            //4 5 7 8 9 5 1 2
            //4 5 7 8 5 9 1 2
            //4 5 7 8 5 1 2 9
            //4 5 7 5 8 1 2 9
            //4 5 7 5 1 2 8 9
            //4 5 5 1 2 7 8 9


            //Console.WriteLine("Сортировка пузырьком");
            //Console.Write("Введите элементы массива: ");
            //var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            //var array = new int[parts.Length];
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(parts[i]);
            //}

            //Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array)));

            //Console.ReadLine();


            ///LESSON 6

            //Car car = new Car(); //init object car
            //car.Drive();

            //Console.WriteLine(car.MultiCar(210, 330));


            //Car audi = new Car("Audi", 2007, 4, "Tomas");
            //Car bmw = new Car("BMW", 2011, 6, "Mike");

            //audi.Drive();
            //bmw.Drive();


            // Lesson 7

            //audi.Distance(120);
            //audi.Distance(90, 3.5);
            //bmw.Distance(1.5, 75);


            //Передача параметров по значению

            //При передаче аргументов  по значению параметр метода получает не саму переменную, а ее копию и  работает с этой копией независимо.

            //int num = 12;

            //void PlusOne(int example)
            //{
            //    example = example + 485;
            //    Console.WriteLine($"Число в методе: {example}");
            //}

            //Console.WriteLine($"Число до метода: {num}"); ////12
            //PlusOne(num);                                 ////497
            //Console.WriteLine($"Число после метода: {num}"); ////12


            //Console.WriteLine("------------------------------------------------------------------");

            ////Передача параметров по ссылке

            ////При передаче значений параметрам по ссылке метод получает адрес переменной в памяти. И, таким образом,
            ////если в методе изменяется значение параметра, передаваемого по ссылке, то также изменяется и значение переменной, которая передается на его место.

            //int secondNum = 12;

            //void PlusOneRef(ref int example)
            //{
            //    example = example + 485;
            //    Console.WriteLine($"Число в методе: {example}");
            //}

            //Console.WriteLine($"Число до метода: {secondNum}"); ////12
            //PlusOneRef(ref secondNum);                          ////497
            //Console.WriteLine($"Число после метода: {secondNum}"); //497

            //Console.WriteLine("------------------------------------------------------------------");


            ////Выше в качестве примера входные параметры.Но параметры могут быть также выходными. Чтобы сделать параметр выходным, перед ним ставится модификатор out:

            ////В примере ниже результат возвращается не через оператор return, а через выходной параметр result.


            //int number;

            //void Sum(int first, int second, out int resultSum)
            //{
            //    resultSum = first + second;
            //}

            //int SumSecond(int first, int second) ////второй вариант, тот же результат
            //{
            //    int result = first + second;
            //    return result;
            //}


            //Sum(110, 125, out number);

            //Console.WriteLine(number); //235
            //Console.WriteLine(SumSecond(110, 125));
            //Как ис ref ключевое слово out используется как при определении метода, так и при его вызове.


            //Car car = new Car("Toyota", 2005);
            //car.Age = 20;
            //car.Brand = "Honda";
            //Console.WriteLine(car.Age);
            //Console.WriteLine(car.Brand);


            // Lesson 8

            //Doctor doctor = new Doctor();
            //doctor.Eat();

            //var rectangle = new Rectangle { Width = 90, Height = 70 };
            //var circle = new Circle { Radius = 100 };
            //PrintShape(rectangle);
            //PrintShape(circle);

            //var honda = new Car1();
            //Console.WriteLine(honda.Speed);
            //honda.Move();
            //honda.Stop();

            //var leonardo = new Reader();
            //leonardo.Read();
            //leonardo.Record();

            //Console.WriteLine(Operations.Pow(3, 0));
            //Console.WriteLine(Operations.Pow(2, 9));
            //Console.WriteLine(Operations.Abs(-234));

            //WarriorStruct voin1 = new WarriorStruct();

            //WarriorStruct voin2 = voin1 with { sword = "Сабля", armor = 73};

            //Console.WriteLine(voin1.sword);
            //Console.WriteLine(voin1.armor);

            //Console.WriteLine(voin2.sword);
            //Console.WriteLine(voin2.armor);

            //voin2.Print();


            //Console.WriteLine((int)AgeTermin.Young);    


            //LESSON 9


            var intro = new IntroStruct();
            var transaction = new AccountTransact();

            int opt;
            intro.Intro();
            intro.Loading();

            Console.Clear();

            do
            {
                Console.Write("\n\n\tРазделы меню");
                Console.Write("\n 1.Создать новый аккаунт");
                Console.Write("\n 2.Посмотреть информацию об аккаунте");
                Console.Write("\n 3.Обновить информацию об аккаунте");
                Console.Write("\n 4.Внести сумму на баланс счета");
                Console.Write("\n 5.Снять сумму с баланса счета");
                Console.Write("\n 6.Показать текущий баланс счета");
                Console.Write("\n 7.Выход из приложения");
                Console.WriteLine("\n Выберите опцию 1-7: ");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(opt)
                {
                    case (int)Options.New:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.CreateAccount();
                            break;
                        }
                    case (int)Options.Show:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.ShowAccount();
                            break;
                        }
                    case (int)Options.Modify:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            Console.Write("Введите ID аккаунта: ");
                            int id = int.Parse(Console.ReadLine());
                            transaction.ModifyAccount(id);
                            break;
                        }
                    case (int)Options.Deposit:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.MoneyDeposit();
                            break;
                        }
                    case (int)Options.Withdraw:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.MoneyWithDraw();
                            break;
                        }
                    case (int)Options.BalanceShow:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.BalanceShow();
                            break;
                        }
                    case (int)Options.Exit:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }

            } while (opt != (int)Options.Exit);





        }

    }
        
}

