using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class GiftCard : Product
    {
        public double _Amount;
        public GiftCard(string name, double price, double points, double amount) : base(name, price, points)
        {
            _Amount = amount;
        }

        public override string ToString()
        {
            return base.ToString() + $"{_Amount}";
        }
    }
}
