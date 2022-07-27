using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class _430
    {
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose() 메서드를 호출합니다.");
            }
        }

        static void Main1(string[] args)
        {
            using (Dummy dummy = new Dummy())
            {

            }
        }
    }
}
