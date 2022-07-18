using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon._01단계
{
    internal class _01_09
    {
        static void Main1(string[] args)
        {
            string[] outputs = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(outputs[0]) + int.Parse(outputs[1]));
            Console.WriteLine(int.Parse(outputs[0]) - int.Parse(outputs[1]));
            Console.WriteLine(int.Parse(outputs[0]) * int.Parse(outputs[1]));
            Console.WriteLine(int.Parse(outputs[0]) / int.Parse(outputs[1]));
            Console.WriteLine(int.Parse(outputs[0]) % int.Parse(outputs[1]));
        }
    }
}
