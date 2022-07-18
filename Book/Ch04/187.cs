using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Threading;

class Program
{
    static void Main1(string[] args)
    {
        Console.WriteLine("첫 번째 출력");
        Thread.Sleep(1000);
        Console.WriteLine("두 번째 출력");

        Thread.Sleep(1000);
        Console.WriteLine("세 번째 출력");
    }
}

