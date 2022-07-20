using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class _270
    {
        class Program
        {
            class Test
            {
                public long Multiply(long min, long max)
                {
                    long output = 1;
                    for (long i = min; i <= max; i++)
                    {

                        output *= i;
                    }
                    return output;
                }
            }

            static void Main1(string[] args)
            {
                Test test = new Test();
                Console.WriteLine(test.Multiply(1, 10));
            }
        }
    }
}
