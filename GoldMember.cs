using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    internal class GoldMember : Member
    {
        public GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void DeductPoints(Product product)
        {
            PointAmount -= product._Points / 2;
        }

        public override void AddPoints(Product product)
        {
            PointAmount += product._Points + 50;
        }
    }
}
