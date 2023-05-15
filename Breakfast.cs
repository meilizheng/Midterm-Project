using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    internal class Breakfast : Food  //created a breakfast class based on food class;
    {
        public bool hasDairy;//add field;

        public Breakfast(string name, double price, double points, bool isHeated, bool hasDairy = false) : base(name, price, points, isHeated) //created a constructor based on parent class;
        {
            this.hasDairy = hasDairy;
        }

        public override string ToString() //use overrride display information;
        {
            return base.ToString() + $"{this.hasDairy}";
        }
    }
}
