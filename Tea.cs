using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Tea : Drink
    {
        string TypeOfTea;
        public Tea(string name, double price, double points, Size size, string typeOfTea) : base(name, price, points, size)
        {
            TypeOfTea = typeOfTea;
        }

        public override string ToString()
        {
            return base.ToString() + $"{TypeOfTea}";
        }
    }
}
