using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _175
    {
        static void Main1(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i + 1; j++)
                    Console.WriteLine('*');
                Console.WriteLine('\n');
            }
        }
    }
}
