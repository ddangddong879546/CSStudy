using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon._01단계
{
    internal class _01_13
    {
        static void Main1(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            int number1 = int.Parse(line1);
            int number2 = int.Parse(line2);

            int number2_digit100 = line2[0] - '0';
            int number2_digit10 = line2[1] - '0';
            int number2_digit1 = line2[2] - '0';

            int answer3 = number1 * number2_digit1;
            int answer4 = number1 * number2_digit10;
            int answer5 = number1 * number2_digit100;
            int answer6 = number1 * number2;

            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            Console.WriteLine(answer5);
            Console.WriteLine(answer6);
        }
    }
}
