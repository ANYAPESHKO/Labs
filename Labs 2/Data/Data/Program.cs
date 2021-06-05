using System;

namespace Data
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            string str = now.ToString();
            int[] count = new int[10];
            Print(now);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == i + '0')
                        count[i]++;
                }
            }
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Quantity of " + i + ": " + count[i]);

            Console.ReadKey();
        }
        static void Print(DateTime now)
        {
            Console.Write("Time and date in first format:  ");
            Console.WriteLine(now.ToString("ddd dd MMMM yyyy HH:mm:ss\n"));
            Console.Write("Time and date in second format:  ");
            Console.WriteLine(now.ToString("dd.MM.yyyy HH:mm:ss\n"));
        }
    }
}