using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    abstract class Food : Product   //created a food class based on product class;
    {
        public bool isHeated; //add a field
        public Food(string name, double price, double points, bool isHeated) : base(name, price, points) //created a constructor based on parent class;
        {
            this.isHeated = isHeated;
        }
    }
}
