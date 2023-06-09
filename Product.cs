﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    public class Product  //created a class as a parent class;
    {
        public string _Name;  //creatd field;
        protected static Random rand = new Random();
        public int _Sku;
        public double _Price;
        public double _Points;
        public int _NumOfProduct;

        public Product(string name, double price, double points) //created constructor with three arguments;
        {
            _Name = name;
            _Sku = rand.Next(1000000, 10000000);
            _Price = price;
            _Points = points;
            _NumOfProduct++;
        }

        public override string ToString()  //use override to display information;
        {
            return $"{GetType().Name} Sku: {_Sku} Name: {_Name} Price: {_Price} Points: {_Points}"; 
        }
    }
}
