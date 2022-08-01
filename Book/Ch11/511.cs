using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch11
{
    internal class _511
    {
        static void Main1(string[] args)
        {
            Thread threadA = new Thread(TestMethod);
            Thread threadB = new Thread(delegate ()
            {

            });
            Thread threadC = new Thread(() =>
            {

            });
        }

        public static void TestMethod()
        {

        }
    }
}
