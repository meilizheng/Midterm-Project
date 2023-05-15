using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    abstract class Food : Product
    {
        public bool isHeated;
        public Food(string name, double price, double points, bool isHeated) : base(name, price, points)
        {
            this.isHeated = isHeated;
        }
    }
}
