using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class _293
    {class Box
        {
            public int width;
            public int height;

            public Box(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public int Area()
            {
                return this.width * this.height;
            }
        }
    }
}
