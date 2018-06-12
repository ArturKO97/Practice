using System;

namespace Test
{
    class Program
    {
        static void OutLine(int length)
        {
            Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        static void FirstTask()
        {
            string FIO = "Козыч Артур Евгеньевич";
            OutLine(FIO.Length);
            Console.Write("|");
            Console.Write(FIO);
            Console.WriteLine("|");
            OutLine(FIO.Length);
        }

        static void One()
        {
            Console.WriteLine("Please enter two integers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.Write("Greater: ");
            Console.WriteLine(a > b ? a : b);
        }

        static void Two()
        {
            Console.WriteLine("Пожалуйста введите \"мяу\" или \" гав\": ");
            string input = Console.ReadLine();
            if (input == "мяу")
            {
                Console.WriteLine("Покорми кота");
            }
            else if (input == "гав")
            {
                Console.WriteLine("Погуляй с собакой");
            }
        }

        static void Three()
        {
            Console.WriteLine("Пожалуйста введите номер месяца: ");
            int mounth = int.Parse(Console.ReadLine());
            if (mounth == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (mounth >= 6)
            {
                if (mounth < 9)
                {
                    Console.WriteLine("Лето");
                }
                else if (mounth < 12)
                {
                    Console.WriteLine("Осень");
                }
                else
                {
                    Console.WriteLine("На этой планете такого месяца нет");
                }
            }
            else
            {
                if (mounth > 2)
                {
                    Console.WriteLine("Весна");
                }
                else if (mounth > 0)
                {
                    Console.WriteLine("Зима");
                }
                else
                {
                    Console.WriteLine("На этой планете такого месяца нет");
                }
            }
        }

        static void Four()
        {
            Console.WriteLine("Введите число 0 или 1:");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(1 == input ? "Хорошо" : "Плохо");
        }

        static void Five()
        {
            Console.WriteLine("Введите номер дня недели:");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Это: ");
            if (1 == input)
                Console.WriteLine("Понедельник");
            if (2 == input)
                Console.WriteLine("Вторник");
            if (3 == input)
                Console.WriteLine("Среда");
            if (4 == input)
                Console.WriteLine("Четверг");
            if (5 == input)
                Console.WriteLine("Пятница");
            if (6 == input)
                Console.WriteLine("Суббота");
            if (7 == input)
                Console.WriteLine("Воскресенье");
        }

        static void Six()
        {
            Console.WriteLine("Количество колометров: ");
            int kilometrs = int.Parse(Console.ReadLine());
            Console.WriteLine("Минуты простоя: ");
            int prostoy = int.Parse(Console.ReadLine());

            int counter = 20;
            kilometrs -= 5;
            if (kilometrs > 0)
            {
                counter += kilometrs * 3;
            }
            counter += prostoy;

            Console.WriteLine("К оплате: {0}грн", counter);
        }

        static void Seven()
        {
            Console.WriteLine("Введите натуральное число: ");
            bool isPrime = true;
            int N = int.Parse(Console.ReadLine());
            for (int i = 2; i < N / 2; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime ? "Число простое" : "Число не простое:)");
        }

        static void Eight()
        {
            Console.WriteLine("Введите ставку: ");
            int input = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            //return [1, 13)
            int result = rnd.Next(1, 13);
            if (result < 6)
            {
                input *= 0;
            }
            if (result > 8)
            {
                if (result == 12)
                {
                    input *= 10;
                }
                else
                {
                    input *= 2;
                }
            }
            Console.WriteLine(input > 0 ? "Вы выиграли {0}" : "Вы проиграли (к сожалению)", input);
        }

        static void Nine()
        {
            double grn = 1;
            double doll = 2;
            double eur = 3;

            Console.WriteLine("Введите сумму: ");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите валюту:\n1 грн\n2 доллары\n3 евро");
            int choice = int.Parse(Console.ReadLine());
            if (1 == choice)
            {
                Console.WriteLine("Доллары: {0}\nЕвро: {1}", doll / grn * sum, eur / grn * sum);
            }
            if (2 == choice)
            {
                Console.WriteLine("Гривны: {0}\nЕвро: {1}", grn / doll * sum, grn / eur * sum);
            }
            if (3 == choice)
            {
                Console.WriteLine("Доллары: {0}\nГривны: {1}", doll / eur * sum, grn / eur * sum);
            }
        }



        static void СOne()
        {
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, N, i * N);
            }
        }


        static void CTwo()
        {
            Console.WriteLine("Введите число: ");
            string input = Console.ReadLine();
            Console.WriteLine("Что ж... если это число то разрадов там не иначе как {0}", input.Length);
        }

        static void СThree()
        {
            Console.WriteLine("Угадай число:");
            Random rnd = new Random();
            int result = rnd.Next(1, 147);
            int input = 0;
            while (input != result)
            {
                input = int.Parse(Console.ReadLine());
                if (input > result)
                {
                    Console.WriteLine("Много, пробуй еще:");
                }
                else if (input < result)
                {
                    Console.WriteLine("Мало... :");
                }
            }
            Console.WriteLine("Ну наконец-то!");
        }

        static void СFour()
        {
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Точные квадраты меньше {0}: ", N);
            for (int i = 1; i < N; i++)
            {
                if (i * i < N)
                {
                    Console.Write("{0} ", i * i);
                }
                else
                {
                    break;
                }
            }
            Console.Write("\n");
        }

        static void СFive()
        {
            double[] inputs = new double[5];
            double counter = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите {0}-e число: ", i);
                counter += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Среднее арифметическое: {0}", counter / 5);
        }

        static void СSix()
        {
            double counter = 0;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                counter += rnd.Next(1, 100);
            }
            Console.WriteLine("Среднее арифметическое 5-и случайных чисел: {0}", counter / 5);
        }

        static void СSeven()
        {
            Console.Write("Лап: 64\n");
            for (int goose = 32, rabbit = 0; rabbit <= 16; rabbit += 1, goose -= 2)
            {
                Console.Write("Гусей: {0};  Кроликов: {1};\n", goose, rabbit);
            }
        }

        static void СEight()
        {
            bool successfully = false;
            while (false == successfully)
            {
                Console.Write("Введите пароль: ");
                string input = Console.ReadLine();
                if (input == "root")
                {
                    successfully = true;
                }
                else
                {
                    Console.Write("Неверный пароль!\n");
                }
            }
            Console.Write("Ура!");
        }



        static void Main(string[] args)
        {
            //All tasks are divided into functions
            FirstTask();

            //1
            One();

            //2
            Two();

            //3
            Three();

            //4
            Four();

            //5
            Five();

            //6
            Six();

            //7
            Seven();

            //8
            Eight();

            //9
            Nine();


            //Cycles:
            //1
            СOne();

            //2
            CTwo();

            //3
            СThree();

            //4
            СFour();

            //5
            СFive();

            //6
            СSix();

            //7
            СSeven();

            //8
            СEight();


            Console.ReadKey();
        }


    }
}
