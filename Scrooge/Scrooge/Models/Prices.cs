using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrooge.Models
{
    public class Prices
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }
        public int SellerId { get; set; }
        public virtual Sellers Seller { get; set; }
        public int Price { get; set; }

    }
}