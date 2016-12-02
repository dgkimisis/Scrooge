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
        public ICollection<DPCombos> DPCombos { get; set; }

        internal void Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}