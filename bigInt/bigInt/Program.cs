using System;
using System.Numerics;

namespace bigInt
{
    class Program
    {
        static BigInteger Multiply(BigInteger number1, BigInteger number2)
        {
            BigInteger result = 1;
            for (BigInteger i = number1; i <= number2; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a: ");
            BigInteger a;
            while (true)
            {
                string number1 = Console.ReadLine();
                bool result1 = BigInteger.TryParse(number1, out a);
                if (!result1 || a <= 0) Console.WriteLine("Input a: ");
                else break;
            }
            BigInteger b;
            Console.WriteLine("Input b: ");
            while (true)
            {
                string number2 = Console.ReadLine();
                bool result2 = BigInteger.TryParse(number2, out b);
                if (!result2 || b <= 0) Console.WriteLine("Input b: ");
                else break;
            }
            if (a > b)
            {
                BigInteger c = a;
                a = b;
                b = c;
            }
            Console.WriteLine("Composition: " + Multiply(a, b));
            BigInteger result = Multiply(a, b);
            BigInteger degree = 0;
            while (result % 2 == 0)
            {
                result /= 2;
                degree++;
            }
            Console.WriteLine("Maximum power of two: " + degree);
            Console.ReadKey();
        }
    }
}

