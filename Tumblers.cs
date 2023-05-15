using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Tumblers : Merchandise
    {
        public string color;

        public Tumblers(string name, double price, double points, string color) : base(name, price, points)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return base.ToString() + $"{color}";
        }
    }
}
