using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class _351
    { 
        class Program
        {
            class Parent
            {
                public Parent()
                {
                    Console.WriteLine("부모 생성자");
                }
            }

            class Child : Parent
            {
                public Child()
                {
                    Console.WriteLine("자식 생성자");
                }
            }

            static void Main(string[] args)
            {
                Child child = new Child();
            }
        }
    }
}
