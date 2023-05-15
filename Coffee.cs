using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Coffee : Drink
    {
        public string _TypeOfRoast;
        public Coffee(string name, double price, double points, Size size, string typeOfRoast) : base(name, price, points, size)
        {
            _TypeOfRoast = typeOfRoast;
        }

        public override string ToString()
        {
            return base.ToString() + $"Roast: {_TypeOfRoast}";
        }
    }
}
