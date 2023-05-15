using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    abstract class Member  //created a member class;
    {
        public string FirstName { get; set; } //created fields and properties;
        public string LastName { get; set; }
        public int MemberNumber { get; set; }
        public double PointAmount { get; set; }
        public DateTime MemberSince { get; set; }
        public ObservableCollection<Product> PreviousTransactions { get; set; }

        protected static Random rand = new Random();

        public Member(string firstName, string lastName)  //created a constructor with 2 arguments;
        {
            FirstName = firstName;
            LastName = lastName;
            MemberNumber = rand.Next(1000000, 10000000);
            PointAmount = 0;
            MemberSince = DateTime.Now;
            PreviousTransactions = new ObservableCollection<Product>();
        }

        public abstract void DeductPoints(Product product);  //created a abstract method for deduct points
        public abstract void AddPoints(Product product); //created a abstract method for add points;

        public void AddProduct(Product product)  //created a method to add all products points;
        {
            PreviousTransactions.Add(product);
            AddPoints(product);
        }

        public override string ToString() //use override to display information;
        {
            return $"{GetType().Name} - {FirstName} {LastName} - Points: {PointAmount} - Member Number: {MemberNumber}";
        }
    }
}
