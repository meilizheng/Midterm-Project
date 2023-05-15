using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Coffee : Drink  //created a coffee class based on drink class;
    {
        public string _TypeOfRoast; //add a field;
        public Coffee(string name, double price, double points, Size size, string typeOfRoast) : base(name, price, points, size) //created a constructor based on parent class;
        {
            _TypeOfRoast = typeOfRoast;
        }

        public override string ToString()
        {
            return base.ToString() + $"Roast: {_TypeOfRoast}";
        }
    }
}
