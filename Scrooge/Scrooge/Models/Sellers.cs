using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrooge.Models
{
    public class Sellers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int PostalCode { get; set; }
        //Every Seller sells some items(itemvalues)
        //in the table Prices, where a specific item 
        //is being sold by a specific Seller in a 
        //Specific Price
        public ICollection<Prices> Prices { get; set; }
    }
}