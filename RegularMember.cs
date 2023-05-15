using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class RegularMember : Member  //created a class based on parent class;
    {
        public RegularMember(string firstName, string lastName) : base(firstName, lastName)  //created a constructor based on parent class;
        {
        }

        public override void DeductPoints(Product product)  //created a method for deduct points;
        {
            PointAmount -= product._Points;  
        }

        public override void AddPoints(Product product) //created a method for add points;
        {
            PointAmount += product._Points;
        }
    }
}
