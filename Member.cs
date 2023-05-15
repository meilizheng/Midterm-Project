using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    abstract class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MemberNumber { get; set; }
        public double PointAmount { get; set; }
        public DateTime MemberSince { get; set; }
        public ObservableCollection<Product> PreviousTransactions { get; set; }

        protected static Random rand = new Random();

        public Member(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            MemberNumber = rand.Next(1000000, 10000000);
            PointAmount = 0;
            MemberSince = DateTime.Now;
            PreviousTransactions = new ObservableCollection<Product>();
        }

        public abstract void DeductPoints(Product product);
        public abstract void AddPoints(Product product);

        public void AddProduct(Product product)
        {
            PreviousTransactions.Add(product);
            AddPoints(product);
        }

        public override string ToString()
        {
            return $"{GetType().Name} - {FirstName} {LastName} - Points: {PointAmount} - Member Number: {MemberNumber}";
        }
    }
}
