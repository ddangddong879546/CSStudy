﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class _167
    {
        static void Main1(string[] args)
        {
            //변수를 선언합니다
            int output = 0;

            //반복을 수행합니다
            for (int i = 0; i <= 100; i++)
            {
                output += i;
            }

            //출력합니다
            Console.WriteLine(output);
        }
    }
}
