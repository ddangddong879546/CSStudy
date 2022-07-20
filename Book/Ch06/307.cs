using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class _307
    { class FIbonacci
        {
            public long Get(int i)
            {
                if (i < 0) { return 0; }
                if (i == 1) { return 1; }
                return Get (i - 2) + Get (i - 1);
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                FIbonacci fibo = new FIbonacci();
                Console.WriteLine(fibo.Get(1));
                Console.WriteLine(fibo.Get(2));
                Console.WriteLine(fibo.Get(3));
                Console.WriteLine(fibo.Get(4));
                Console.WriteLine(fibo.Get(5));
                
            }
        }
    }
}
