using System;

namespace totry
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "joe";
            string[] phrases = { "stupid", "dumb", "donkey" };
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
            Console.WriteLine(name);
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
            Console.WriteLine(k);
        }
    }
}
