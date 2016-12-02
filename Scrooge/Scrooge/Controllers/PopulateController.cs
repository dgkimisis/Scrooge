using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scrooge.Models;
using System.Data.Entity;

namespace Scrooge.Controllers
{
    public class PopulateController : Controller
    {
        // GET: Populate
        public ActionResult DataInsert()
        {   //Populating Database
            ScroogeContext sc = new ScroogeContext();
            //Add Sellers
            //sc.Sellers.Add(new Sellers { Name = "Kotsovolos", Address = "Leoforos Sygrou 215", Phone = "210-3545392", PostalCode = 15312 });
            //sc.Sellers.Add(new Sellers { Name = "Masoutis", Address = "Egnatias 45", Phone = "210-6792374", PostalCode = 15275 });
            //sc.Sellers.Add(new Sellers { Name = "Media Markt", Address = "Vouliagmenis 14", Phone = "210-9345712", PostalCode = 17453 });
            //sc.Sellers.Add(new Sellers { Name = "InfoWorld", Address = "Ipeirou 23", Phone = "210-5484639", PostalCode = 19563 });
            //sc.Sellers.Add(new Sellers { Name = "Cosmodata", Address = "Egnatias 4", Phone = "2310-854751", PostalCode = 31526 });

            //Add Categories
            //sc.Categories.Add(new Categories { Name = "Technology" });
            //sc.Categories.Add(new Categories { Name = "Computers", ParentId = 1 });
            //sc.Categories.Add(new Categories { Name = "Entertainment", ParentId = 1 });
            //sc.Categories.Add(new Categories { Name = "Gaming", ParentId = 1 });

            //Add Products
            //sc.Products.Add(new Products { Name = "Rams", CategoriesId = 2 });
            //sc.Products.Add(new Products { Name = "Motherboards", CategoriesId = 2 });
            //sc.Products.Add(new Products { Name = "HardDrives", CategoriesId = 2 });
            //sc.Products.Add(new Products { Name = "Processors", CategoriesId = 2 });
            //sc.Products.Add(new Products { Name = "Monitors", CategoriesId = 2 });
            //sc.Products.Add(new Products { Name = "Televisions", CategoriesId = 3 });
            //sc.Products.Add(new Products { Name = "Projectors", CategoriesId = 3 });
            //sc.Products.Add(new Products { Name = "Consoles", CategoriesId = 4 });
            sc.Products.Add(new Products { Name = "Virtual Reality", CategoriesId = 4 });

            //Add Distinctions
            sc.Distinctions.Add(new Distinctions { ProductsId = 1, DataTypes{ string s = "DDR4"});
            sc.Distinctions.Add(new Distinctions { ProductsId = 1, DataTypes(0) = "fdd" });



            //Remove stuff
            //sc.Products.Add(new Products { Name = "Virtual Reality", CategoriesId = 4 });
            //sc.Sellers.Remove(sc.Sellers.Where(m => m.Name == "Cosmodata").FirstOrDefault());
            //sc.Categories.Remove(sc.Categories.Where(m => m.Name == "Technology").FirstOrDefault());
            //sc.Categories.Remove(sc.Categories.Where(m => m.Name == "Computers").FirstOrDefault());
            //sc.Categories.Remove(sc.Categories.Where(m => m.Name == "Entertainment").FirstOrDefault());
            //sc.Categories.Remove(sc.Categories.Where(m => m.Name == "Gaming").FirstOrDefault());

            sc.SaveChanges();
            return View();
        }
    }
}