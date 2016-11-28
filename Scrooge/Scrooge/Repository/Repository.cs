using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scrooge.Models;

namespace Scrooge.Repository
{
    public class Repository
    {
        public Repository()
        {
            ScroogeContext sc = new ScroogeContext();
            sc.Sellers.Add(new Sellers { Name = "Kotsovolos", Address = "Leoforos Sygrou 215" });
            sc.Sellers.Add(new Sellers { Name = "Masoutis", Address = "Egnatias 45" });
            sc.Sellers.Add(new Sellers { Name = "Media Markt", Address = "Vouliagmenis 14" });
            sc.Sellers.Add(new Sellers { Name = "InfoWorld", Address = "Ipeirou 23" });
            sc.Sellers.Add(new Sellers { Name = "Cosmodata", Address = "Varis Koropiou 4" });
            sc.SaveChanges();
        }
     }
}
    
