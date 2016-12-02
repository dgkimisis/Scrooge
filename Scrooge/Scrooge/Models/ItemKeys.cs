using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrooge.Models
{
    public enum ItemDataType
    {
        Integer,
        String,
        Boolean
    }
    public class ItemKeys
    {
        public int Id { get; set; }
        public string Description { get; set; }
        //Measurement unit corresponds to description and 
        //refers to MHz, MBs, Rounds/Minte etc
        //It shows in which unit we measure an attribute
        public string Units { get; set; }
        public ItemDataType DataType { get; set; }
        public int CategoriesId { get; set; }
        public virtual Categories Categories { get; set; }
    }
}