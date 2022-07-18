using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class _109
    {
        static void Main1(string[] args)
        {
            //long 자료형을 int 자료형으로 변환합니다.
            long longNumber = 2147483647L + 2147483647L;
            int longToInt = (int)longNumber;
            Console.WriteLine(longToInt);

            //double 자료형을 int 자료형으로 변환합니다.
            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);

            //int 자료형의 숫자를 생성합니다.
            int intNumber = 2147483647;

            //int 자료형을 long 자료형으로 자동 변환합니다.
            long intToLong = intNumber;
            Console.WriteLine(intToLong);

            //int 자료형을 double 자료형으로 자동 변환합니다.
            double intToDouble = intNumber;
            Console.WriteLine(intToDouble);
        }
    }
}
