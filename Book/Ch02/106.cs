using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class _106
    {
        static void Main1(string[] args)
        {
            // long 자료형을 int 자료형으로 변환한다
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);
        }
    }
}
