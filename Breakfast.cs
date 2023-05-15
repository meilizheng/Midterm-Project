using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    internal class Breakfast : Food
    {
        public bool hasDairy;

        public Breakfast(string name, double price, double points, bool isHeated, bool hasDairy = false) : base(name, price, points, isHeated)
        {
            this.hasDairy = hasDairy;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.hasDairy}";
        }
    }
}
