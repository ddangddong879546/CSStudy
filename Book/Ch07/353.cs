using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class _353
    {
        static void Main1(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child();
        }

        class Parent
        {
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(int param)
            {
                Console.WriteLine("Parent(int param)");
            }

            public Parent(string param) { Console.WriteLine("Parent(string param)"); }   
        }
        class Child : Parent
        {
            public Child() : base(10)
            {
                Console.WriteLine("Child() : base(10)");
            }

            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }
        }
    }
}
