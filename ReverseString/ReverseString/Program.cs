using System;


namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            Array.Reverse(inputArray);
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
