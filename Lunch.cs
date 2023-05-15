using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Lunch : Food
    {
        public bool isCombo;
        public Lunch(string name, double price, double points, bool isHeated, bool isCombo = false) : base(name, price, points, isHeated)
        {
            this.isCombo = isCombo;
        }

        public override string ToString()
        {
            return base.ToString() + $"{isCombo}";
        }
    }
}
