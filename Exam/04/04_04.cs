using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
    class MyGeneric<T>
    {
        private T[] arr;
        private int count = 0;

        public MyGeneric(int length)
        {
            arr = new T[length];
            count = length;
        }

        public void Insert(params T[] args)
        {
            for (int i = 0; i< args.Length; i++)
            {
                arr[i] = args[i];
            }
        }

        public void Print()
        {
            foreach (T i in arr)
                Console.WriteLine(i + "");
            Console.WriteLine();
        }
    }

    internal class _04_04
    {
        static void Main1(string[] args)
        {
            MyGeneric<int> mg1 = new MyGeneric<int>(10);
            MyGeneric<string> mg2 = new MyGeneric<string>(5);

        }
    }
}
