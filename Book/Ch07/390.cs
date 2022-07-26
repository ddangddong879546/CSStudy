using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class _390
    {
        class Unit { }
        class Tank : Unit { }

        class Program
        {
            static void Main1(string[] args)
            {
                Unit unit = new Unit();
                Tank tank = new Tank();

                Unit a = (Unit)unit;
                Unit b = (Unit)tank;
                
                Tank d = (Tank)tank;
            }
        }
    }
}
