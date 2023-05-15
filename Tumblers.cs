using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Tumblers : Merchandise //create a tumblers based on parent class;
    {
        public string color; //add field

        public Tumblers(string name, double price, double points, string color) : base(name, price, points) //create constructor based on parent class;
        {
            this.color = color;
        }

        public override string ToString() //created override disply information;
        {
            return base.ToString() + $"{color}";
        }
    }
}
