using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Data
    {
        static ObservableCollection<Member> memberCollection;
        static ObservableCollection<Product> productCollection;
        static Product currentProduct;
        static Member currentMember;

        static Data()
        {
            memberCollection = new ObservableCollection<Member>();
            productCollection = new ObservableCollection<Product>();
        }

        public static ObservableCollection<Member> MemberCollection { get { return memberCollection; } }
        public static ObservableCollection<Product> ProductCollection { get { return productCollection; } }
        public static Product CurrentProduct { get { return currentProduct; } }
        public static Member CurrentMember { get { return currentMember; } }

        public static void AddProductToCollection(Product product)
        {
            productCollection.Add(product);
        }

        public static void AddMemberToCollection(Member member)
        {
            memberCollection.Add(member);
        }

        public static void UpdateCurrentProduct(Product product)
        {
            currentProduct = product;
        }

        public static void UpdateCurrentMember(Member member)
        {
            currentMember = member;
        }
    }
}
