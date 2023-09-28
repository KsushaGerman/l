using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ТП_1лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nЛабораторная работа №1");
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("1.Посчитать факториал числа n.");
                Console.WriteLine("2.Рассчитать функцию, значение задает пользователь.");
                Console.WriteLine("3.Составить последовательность чисел Фибоначчи от 0 до n.");
                Console.WriteLine("4.Разложить функцию в ряд Тейлора.");
                Console.WriteLine(" ");

                int zadanie = int.Parse(Console.ReadLine());

                switch (zadanie)
                {
                    case 1:
                        Factorial_1();
                        break;

                    case 2:
                        Funkzia_2();
                        break;

                    case 3:
                        Finabochi_3();
                        break;

                    case 4:
                        Teilor_4();
                        break;
                }
            }
        }

        public static void Factorial_1()
        {
            Console.WriteLine("Задание 1: Посчитать факториал числа n");

            Console.WriteLine("Введите целое положительное число n :");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Вычисляем факториал числа {n}:");

            long fact = 1;
            for (long i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Фактриал числа {n} равен {fact}");
            Console.ReadLine();
        }

        public static void Funkzia_2()
        {
            Console.WriteLine("Задание 2: Рассчитать значение функции: A = √(ln(4/3)) + (x + 9/7) - (e^sin(1,3x - 0,7))");

            Console.Write("Введите значение переменной x: ");
            double x = double.Parse(Console.ReadLine());

            double ln = Math.Log(4 / 3);
            double sin = Math.Sin(1.3 * x - 0.7);
            double e = Math.Exp(sin);

            double A = Math.Sqrt(ln) + (x + 9 / 7) - e;

            Console.WriteLine("Значение функции A для x = " + x + " равно " + A);
            Console.ReadLine();
        }

        public static void Finabochi_3()
        {
            Console.WriteLine("Задание 3: Составить последовательность чисел Фибоначчи от 0 до n");

            //Последовательность чисел,в которой первые два числа равны 0 и 1,
            //а каждое последующее число равно сумме двух предыдущих
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,
            //610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 

            Console.WriteLine("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            int pervoe_chislo = 0;
            int vtoroe_chislo = 1;

            Console.Write($"Последовательность Фибоначчи: {pervoe_chislo}, {vtoroe_chislo}");

            for (int i = 2; i <= n; i++) //начинаем цикл со второго элемента, т.к. первые два уже выведены
            {
                int tretie_chislo = pervoe_chislo + vtoroe_chislo; //вычисляем следующее число
                Console.Write(", {0}", tretie_chislo); //выводим его на экран
                pervoe_chislo = vtoroe_chislo; //переназначаем значения для вычисления следующего числа
                vtoroe_chislo = tretie_chislo;
            }
            Console.ReadLine();
        }

        public static void Teilor_4()
        {
            Console.Write("Задание 4: Разложить в ряд Тейлора функцию : e ^ x ");

            //e^x = 1 + x/1! + x^2/2! + ... + x^n/n!

            double x = 1; // Значение x для разложения функции e^x
            double term = 0; // Переменная для хранения каждого члена ряда Тейлора
            double sum = 0; // Переменная для хранения суммы ряда
            double prevSum = 0; // Переменная для хранения предыдущей суммы ряда

            int n = 0; // Итератор для количества членов ряда

            while (true)
            {

                double xn = Math.Pow(x, n); // Вычисление значения x в степени n

                double fact = 1;

                // Вычисление факториала числа n
                for (int i = 1; i <= n; i++)
                {
                    fact *= i; // Вычисление факториала путем последовательного умножения чисел
                }

                term = xn / fact; // Вычисление текущего члена ряда Тейлора

                prevSum = sum; // Сохранение предыдущей суммы

                sum += term; // Добавление текущего члена к сумме ряда
                n++; // Увеличение итератора

                Console.WriteLine($"\nCумма ряда {n}: {sum}");

                // Проверка разницы между текущей и предыдущей суммами
                if (sum - prevSum < 0.0001)
                {
                    break; // Если разница меньше 0,0001, завершаем цикл
                }

            }
                Console.ReadLine();
            
        }
    }
}

