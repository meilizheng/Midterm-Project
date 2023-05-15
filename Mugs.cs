using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Mugs : Merchandise
    {
        public string design;

        public Mugs(string name, double price, double points, string design) : base(name, price, points)
        {
            this.design = design;
        }

        public override string ToString()
        {
            return base.ToString() + $"{design}";
        }
    }
}
