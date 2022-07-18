using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_10
    {
        static void Main1(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.WriteLine(n1 + ", ");
            Console.WriteLine(n2 + ", ");

            for (int i = 1; i <= 10; i++)
            {
                n3 = n1 + n2;

                Console.WriteLine(n3 + ",");

                n1 = n2;
                n2 = n3;
            }
        }
    }
}
