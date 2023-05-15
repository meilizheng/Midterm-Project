using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class GiftCard : Product //created a gifrcard class base on product class;
    {
        public double _Amount; //add a field;
        public GiftCard(string name, double price, double points, double amount) : base(name, price, points) //created a constructor based on parent class;
        {
            _Amount = amount;
        }

        public override string ToString()  //use override display infromation;
        {
            return base.ToString() + $"{_Amount}";
        }
    }
}
