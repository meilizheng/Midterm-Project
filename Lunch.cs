using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Lunch : Food //creat a class based on parent class
    {
        public bool isCombo; // add a new field;
        public Lunch(string name, double price, double points, bool isHeated, bool isCombo = false) : base(name, price, points, isHeated) //created a constructor based on parent class;
        {
            this.isCombo = isCombo;
        }

        public override string ToString() //use override to display informations;
        {
            return base.ToString() + $"{isCombo}";
        }
    }
}
