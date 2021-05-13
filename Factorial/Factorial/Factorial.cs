using System;

namespace Factorial
{
    public static class Factorial
    {
        public static int Fact(int n)
        {
            if (n == 0) return 1;
            else return n * Fact(n - 1);
            
        }

        public static int Fibonachi(int x)
        {
            if (x == 0) return 0;
            else if (x == 1) return 1;
            else return Fibonachi(x - 1) + Fibonachi(x - 2);
        }
    }
}
