using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    static class Data //creat a static class 
    {
        static ObservableCollection<Member> memberCollection;  //created a observable collection for member collection;
        static ObservableCollection<Product> productCollection; //created a observable collection for product collection;
        static Product currentProduct;
        static Member currentMember;

        static Data() //created a static constructor;
        {
            memberCollection = new ObservableCollection<Member>(); 
            productCollection = new ObservableCollection<Product>();
        }

        public static ObservableCollection<Member> MemberCollection { get { return memberCollection; } }
        public static ObservableCollection<Product> ProductCollection { get { return productCollection; } }
        public static Product CurrentProduct { get { return currentProduct; } }
        public static Member CurrentMember { get { return currentMember; } }

        public static void AddProductToCollection(Product product) //created a method add product;
        {
            productCollection.Add(product);
        }

        public static void AddMemberToCollection(Member member)  //created a method add member;
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
