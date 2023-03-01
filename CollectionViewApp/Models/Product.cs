using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool HasOffer { get; set; }
        public string Image { get; set; }
        public decimal OfferPrice { get; set; }
    }
}
