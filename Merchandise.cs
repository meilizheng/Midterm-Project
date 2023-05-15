using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    abstract class Merchandise : Product
    {
        public Merchandise(string name, double price, double points) : base(name, price, points)
        {
        }
    }
}
