using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrooge.Models
{
    public class DPCombos
    {
        public int Id { get; set; }
        public int DistinctionsId { get; set; }
        public virtual Distinctions Distinctions { get; set; }
        public int SellersId { get; set; }
        public virtual Sellers Sellers { get; set; }
        public int Pricetag { get; set; }
    }
}