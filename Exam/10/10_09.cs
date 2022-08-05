﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._10
{
    class Saram
    {
        public virtual void Print()
        {
            Console.WriteLine("사람입니다.");
        }
    }

    class Man : Saram
    {
        public override void Print()
        {
            Console.WriteLine("남자 입니다.");
        }
    }

    class Woman : Saram
    {
        public override void Print()
        {
            Console.WriteLine("여자 입니다.");
        }
    }

    internal class _10_09
    {
        static void Main1(string[] args)
        {
            Saram s1 = MakeSaram(1);
            Saram s2 = MakeSaram(1);

            s1.Print();
            s2.Print();
        }

        public static Saram MakeSaram(int kind)
        {
            if(kind == 1)
                return new Man();
            else
                return new Woman();
        }
    }
}
