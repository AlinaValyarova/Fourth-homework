using System;
using System.Threading;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ex7();
        }

        static string Quadratic(int a, int b, int c)
        {
            int dis = b * b - 4 * a * c;
            if (dis > 0)
            {
                return ("X1: " + (-b + Math.Sqrt(dis)) / (2 * a) + " X2: " + (-b - Math.Sqrt(dis)) / (2 * a));
            }
            else if (dis == 0)
            {
                return ("X: " + -b / 2 * a);
            }
            else
            {
                return ("Equation has no x");
            }

        }


        public static void ex1()
        {
            Console.WriteLine("Написать метод решения квадратного уравнения");
            Console.WriteLine("Enter value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Quadratic(a, b, c));
        }

        public static void ex2()
        {
            Console.WriteLine("Вывести на экран массив из 20 случайных чисел. " +
                "Ввести два числа из этого массива, которые нужно поменять местами." +
                "Вывести на экран получившийся массив.");
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = rand.Next(1, 100);
            }
            foreach (int s in array)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine("Enter numbers that need to be swapped");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(array, num1);
            int index2 = Array.IndexOf(array, num2);
            (array[index], array[index2]) = (array[index2], array[index]);
            foreach (int s in array) Console.Write(s + " ");
        }

        static int[] BubbleSort(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int a = mas[i];
                        mas[i] = mas[j];
                        mas[j] = a;

                    }
                }
            }
            return mas;
        }
        public static void ex3()
        {
            Console.WriteLine("Написать метод для сортировки одномерного массива пузырьком.");
            Console.WriteLine("Enter the numer of elements in array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];
            Console.WriteLine("Enter numbers through enter");
            for (int i = 0; i < num; i++)
            {
                int users = Convert.ToInt32(Console.ReadLine());
                array[i] = users;
            }
            foreach (int s in array)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine("Sorting in process...");
            BubbleSort(array);
            Console.WriteLine("After sorting:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }

        static string Mas(params int[] numbers)
        {
            int Sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Sum += numbers[i];
            }
            int result = 1;
            for (int a = 0; a < numbers.Length; a++)
            {
                result *= numbers[a];
            }

            Console.WriteLine("Произведение = {0}", result);
            return ("Сумма=" + Sum);

        }

        public static void ex4()
        {
            Console.WriteLine("Написать метод, где в качества аргумента будет передан массив (ключевое слово params)." +
                "Вывести сумму элементов массива(вернуть). Вывести(ref) произведение массива. " +
                "Вывести(out) среднее арифметическое в массиве.");
        }

        static void WaitsForExit(string exit)
        {
            if (exit.Equals("exit") || exit.Equals("закрыть"))
            {
                Environment.Exit(0);
            }
        }
        public static void ex5()
        {
            try
            {
                Console.WriteLine("Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать " +
                    "изображение цифры в виде символа #.Если число больше 9 или меньше 0, " +
                    "то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке." +
                    "Если пользователь ввёл не цифру, то программа должна выпасть в исключение." +
                    "Программа завершает работу, если пользователь введёт слово: exit или закрыть(оба варианта должны сработать) - " +
                    "консоль закроется.");
                Console.WriteLine("Enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0 || num > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Thread.Sleep(3000);
                    Console.WriteLine("Wrong enter!");
                    Console.ForegroundColor = ConsoleColor.White;
                    string a = Console.ReadLine();
                    WaitsForExit(a);
                }
                else
                {
                    switch (num)
                    {
                        case 0:
                            Console.WriteLine("######");
                            Console.WriteLine("#    #");
                            Console.WriteLine("#    #");
                            Console.WriteLine("#    #");
                            Console.WriteLine("######");
                            break;
                        case 1:
                            Console.WriteLine("  #   ");
                            Console.WriteLine("# #   ");
                            Console.WriteLine("  #   ");
                            Console.WriteLine("  #   ");
                            Console.WriteLine("##### ");
                            break;
                        case 2:
                            Console.WriteLine(" #### ");
                            Console.WriteLine("#    #");
                            Console.WriteLine("   #  ");
                            Console.WriteLine("#     ");
                            Console.WriteLine("######");
                            break;
                        case 3:
                            Console.WriteLine(" #### ");
                            Console.WriteLine("#    #");
                            Console.WriteLine("   # #");
                            Console.WriteLine("#    #");
                            Console.WriteLine(" #### ");
                            break;
                        case 4:
                            Console.WriteLine("#    #");
                            Console.WriteLine("#    #");
                            Console.WriteLine("######");
                            Console.WriteLine("     #");
                            Console.WriteLine("     #");
                            break;
                        case 5:
                            Console.WriteLine("######");
                            Console.WriteLine("#     ");
                            Console.WriteLine("# ## #");
                            Console.WriteLine("     #");
                            Console.WriteLine("######");
                            break;
                        case 6:
                            Console.WriteLine("######");
                            Console.WriteLine("#     ");
                            Console.WriteLine("# # ##");
                            Console.WriteLine("#    #");
                            Console.WriteLine("######");
                            break;
                        case 7:
                            Console.WriteLine("#######");
                            Console.WriteLine("      #");
                            Console.WriteLine("    #  ");
                            Console.WriteLine("  #    ");
                            Console.WriteLine("#      ");
                            break;
                        case 8:
                            Console.WriteLine("######");
                            Console.WriteLine("#    #");
                            Console.WriteLine("######");
                            Console.WriteLine("#    #");
                            Console.WriteLine("######");
                            break;
                        case 9:
                            Console.WriteLine("######");
                            Console.WriteLine("#    #");
                            Console.WriteLine("######");
                            Console.WriteLine("     #");
                            Console.WriteLine("######");
                            break;
                    }
                    string a = Console.ReadLine();
                    WaitsForExit(a);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public struct Ded
        {
            public string Name;
            public string[] Phrases;
        }

        static void dedHits(string name, params string[] phrases)
        {

                Console.WriteLine("Enter the numer of words");
                int num = Convert.ToInt32(Console.ReadLine());
                string[] array = new string[num];
                Console.WriteLine("Enter words through enter");
                int k = 0;
                for (int i = 0; i < num; i++)
                {
                    string users = Console.ReadLine();
                    array[i] = users;
                }
                Console.WriteLine("Name: " + name);
                foreach (string a in phrases)
                {
                    for (int j = 0; j < phrases.Length; j++)
                    {
                        if (array[j].Equals(a))
                        {
                            k += 1;
                        }
                    }
                }
                Console.WriteLine( "Number of shiners: " + k);
        }
        public static void ex6()
        {
            Console.WriteLine(" Создать структуру деда. У деда есть имя, уровень ворчливости (перечисление), " +
                "массив фраз для ворчания(Например:”проститутки!”, “Гады!”), количество синяков от ударов бабки = 0 по умолчанию." +
                "Создать 5 дедов.У каждого деда - разное количество фраз для ворчания. " +
                "Напишить метод, который на вход принимает деда, список матерных слов(params). " +
                "Если дед содержит в своей лексике матерные слова из списка, то бабка ставит фингал за каждое слово." +
                "Вернуть количество фингалов.");
            Ded GF1;
            GF1.Name = "Gregory";
            string[] ph1 = { "stupid", "careless", "slut", "moron" };
            GF1.Phrases = ph1;

            Ded GF2;
            GF2.Name = "Joe";
            string[] ph2 = { "weirdo", "pig", "stupid" };
            GF2.Phrases = ph2;

            Ded GF3;
            GF3.Name = "Sergey";
            string[] ph3 = { "freak", "nerd" };
            GF3.Phrases = ph3;

            Ded GF4;
            GF4.Name = "Miron";
            string[] ph4 = { "noob", "cow", "sheep", "stupid" };
            GF4.Phrases = ph4;

            Ded GF5;
            GF5.Name = "Lion";
            string[] ph5 = { "stupid" };
            GF5.Phrases = ph5;

            try
            {
                dedHits(GF5.Name, GF5.Phrases);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }


        }
        static int partition<T>(T[] m, int a, int b) where T : IComparable<T>
        {
            int i = a;
            for (int j = a; j <= b; j++)         
            {
                if (m[j].CompareTo(m[b]) <= 0)  
                {
                    T t = m[i];                 
                    m[i] = m[j];               
                    m[j] = t;                 
                    i++;                         
                }
            }
            return i - 1;                       
        }

        static void quicksort<T>(T[] m, int a, int b) where T : IComparable<T>
        {                                        
            if (a >= b) return;
            int c = partition(m, a, b);
            quicksort(m, a, c - 1);
            quicksort(m, c + 1, b);
        }
        public static void ex7()
        {
            try
            {
                Console.WriteLine("Написать метод Быстрой сортировки массива (Быстрая сортировка - название сортировки)");
                Console.WriteLine("Enter number of elements");
                int num = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[num];
                Console.WriteLine("Enter numbers");
                for (int i = 0; i < num; i++)
                {
                    int users = Convert.ToInt32(Console.ReadLine());
                    array[i] = users;
                }
                quicksort<int>(array, 0, array.Length - 1);
                Console.WriteLine("Массив: {0}", String.Join(" ", array));

            }
            catch
            {
                Console.WriteLine("Mistake");
            }

        }
    }
}

