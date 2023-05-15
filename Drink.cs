using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    abstract class Drink : Product
    {
        public enum Size { Short, Tall, Grande, Venti, Trenta };
        public Size drinkSize { get; set; }
        public Drink(string name, double price, double points, Size size) : base(name, price, points)
        {
            drinkSize = size;
        }
    }
}
