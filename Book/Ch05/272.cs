﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class _272
    {class Program
        {
            class MyMath
            {
                public static int Abs(int input)
                {
                    if (input < 0)
                    {
                        return -input;
                    }
                    else
                    {
                        return input;
                    }
                }
            }

            static void Main1(string[] args)
            {
                Console.WriteLine(MyMath.Abs(52));
                Console.WriteLine(MyMath.Abs(-273));
            }
        }
    }
}
        
        
