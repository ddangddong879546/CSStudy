using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class _308
    { class Fibonacci
        {
            public static long Get(int i)
            {
                if (i < 0) { return 0; }
                if (i == 1) { return 1; }
                if (i == 2) { return 1; }
                return Get(i - 2) + Get(i - 1);
            }
        }
        class Program
        {
            static void Main1(string[] args)
            {
                
                Console.WriteLine(Fibonacci.Get(1));
                Console.WriteLine(Fibonacci.Get(2));
                Console.WriteLine(Fibonacci.Get(3));
                Console.WriteLine(Fibonacci.Get(4));
                Console.WriteLine(Fibonacci.Get(5));

            }
        }
    }
}

