using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Mugs : Merchandise       //created a mugs class based on parent class;
    {
        public string design;  //add a new field;

        public Mugs(string name, double price, double points, string design) : base(name, price, points)  //created a constructor based on parent class;
        {
            this.design = design;
        }

        public override string ToString()  //use override disply information;
        {
            return base.ToString() + $"{design}";
        }
    }
}
