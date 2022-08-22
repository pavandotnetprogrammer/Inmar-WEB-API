using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inmar_WEB_API.Models
{
    public class Offer
    {
        private string _offerName;
        private List<Product> _products;

        public Offer(string offerName, List<Product> products)
        {
            _offerName = offerName;
            _products = products;
        }

        public string OfferName
        {
            get { return _offerName; }
            set
            {
                _offerName = value;
            }
        }
        public List<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
            }
        }
    }
}