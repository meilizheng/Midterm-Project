using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    abstract class Drink : Product //created a drink class based on product class;
    {
        public enum Size { Short, Tall, Grande, Venti, Trenta }; //use enum add a field;
        public Size drinkSize { get; set; }
        public Drink(string name, double price, double points, Size size) : base(name, price, points) //created a constructor based on parent class;
        {
            drinkSize = size;
        }
    }
}
