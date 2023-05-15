using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Tea : Drink //creat tea class based on parent class;
    {
        string TypeOfTea; //add new field;
        public Tea(string name, double price, double points, Size size, string typeOfTea) : base(name, price, points, size) //creat a constructor based on parent class
        {
            TypeOfTea = typeOfTea;
        }

        public override string ToString()  //use override to display information;
        {
            return base.ToString() + $"{TypeOfTea}";
        }
    }
}
