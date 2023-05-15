using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class RegularMember : Member
    {
        public RegularMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void DeductPoints(Product product)
        {
            PointAmount -= product._Points;
        }

        public override void AddPoints(Product product)
        {
            PointAmount += product._Points;
        }
    }
}
