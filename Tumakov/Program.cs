using System;

namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            hw2();
        }

        static void BiggerFromTwo(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("The bigger is: " + a);
            }
            else if (a == b)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("The bigger number is: " + b);
            }

        }
        static void ex1()
        {
            Console.WriteLine("Написать метод, возвращающий наибольшее из двух чисел. Входные параметры - два целых числа." +
                "Протестрировать метод.");
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            BiggerFromTwo(num1, num2);
        }

        static void SwitchPlaces(ref string a, ref string b)
        {
            Console.WriteLine("Elements after SwitchPlaces " + b + " " + a); // как сделать пробел нормально???

        }
        static void ex2()
        {
            Console.WriteLine("Написать метод, который меняет местами значения двух передаваемых параметров. " +
                "Параметры передавать по ссылке. Протестировать метод.");
            Console.WriteLine("Enter first element");
            string f = Console.ReadLine();
            Console.WriteLine("Enter second element");
            string s = Console.ReadLine();
            Console.WriteLine("Elements before SwitchPlaces: " + f + " " + s);
            SwitchPlaces(ref f, ref s);
        }

        static int Factorial(int a)
        {
            if (a == 1) return 1;
            return a * Factorial(a - 1);
        }

        public static void ex3()
        {
            Console.WriteLine("Написать метод вычисления факториала числа, результат вычислений передавать в выходном параметре." +
                "Если метод отработал успешно, то вернуть значение true; если в процессе вычисления возникло переполнение," +
                "то вернуть значение false. Для отслеживания переполнения значения использовать блок checked.");
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int m = checked(Factorial(num));
            if (m != 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static void Divider(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine("Smallest common divider: " + a);
        }

        public static void hw1()
        {
            Console.WriteLine("Написать метод, который вычисляет НОД двух натуральных чисел (алгоритм Евклида). " +
                "Написать метод с тем же именем, который вычисляет НОД трех натуральных чисел");
            Console.WriteLine("Enter a first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Divider(num1, num2);
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void hw2()
        {
            Console.WriteLine("Написать рекурсивный метод, вычисляющий значение n-го члена числа ряда Фибоначчи");
            Console.WriteLine("Enter the number of sign");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is: " + Fibonacci(num));
        }
    }
}
