using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inmar_WEB_API.Models
{
    public class Product
    {
        private string _productName;
        private string _Description;
        private decimal _price;

        public Product(string productName, string description, decimal price)
        {
            _productName = productName;
            _Description = description;
            _price = price;
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }
    }
}