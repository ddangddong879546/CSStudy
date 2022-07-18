using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class _205
    {class Car
        {
            int carNumber;
            DateTime inTime;
            DateTime outTime;

            public void SetInTime()
            {
                this.inTime = DateTime.Now;
            }

            public void SetOutTime()
            {
                this.outTime = DateTime.Now;
            }

            static void Main1(string[] args)
            {
                Car car = new Car();
                car.SetInTime();
                car.SetOutTime();
            }
        }
    }
}
