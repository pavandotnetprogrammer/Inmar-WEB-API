using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inmar_WEB_API.Models
{
    public class OfferService
    {
        private List<Product> _inventory = null;

        private void createInventory()
        {
            _inventory.Add(new Product("P1", "P1 Desc", 1000));
            _inventory.Add(new Product("P2", "P2 Desc", 200));
            _inventory.Add(new Product("P3", "P3 Desc", 400));
            _inventory.Add(new Product("P4", "P4 Desc", 700));
            _inventory.Add(new Product("P5", "P5 Desc", 600));
            _inventory.Add(new Product("P6", "P6 Desc", 800));
        }

        public OfferService()
        {
            createInventory();
        }
        public List<Product> GetAllProducts()
        {
            return _inventory;
        }
        public List<Product> GetTodaysOffers()
        {
            return _inventory;
        }
    }
}