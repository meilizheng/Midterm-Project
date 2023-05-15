using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    internal class GoldMember : Member //created a goldmemeber based on member class;
    {
        public GoldMember(string firstName, string lastName) : base(firstName, lastName) //created a constructor based on parent class;
        {
        }

        public override void DeductPoints(Product product) //created a method to deduct points
        {
            PointAmount -= product._Points / 2;
        }

        public override void AddPoints(Product product) //created a method for the gold member to add 50 bonus;
        {
            PointAmount += product._Points + 50;
        }
    }
}
