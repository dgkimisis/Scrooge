using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrooge.Models
{
    public class Distinctions
    {
        public enum DistinctiveDataType
        {
            Integer,
            String,
            Boolean
        }
        public int Id { get; set; }
        public int ProductsId { get; set; }
        public virtual Products Products { get; set; }
        //Product Attributes
        public ICollection<DistinctiveDataType> DataTypes { get; set; }
        public virtual ICollection<DPCombos> DPCombos { get; set; }
    }
}