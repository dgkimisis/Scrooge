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
            ////Add Sellers
            //sc.Sellers.Add(new Sellers { Name = "Kotsovolos", Address = "Leoforos Sygrou 215", Phone = "210-3545392", PostalCode = 15312 });
            //sc.Sellers.Add(new Sellers { Name = "Masoutis", Address = "Egnatias 45", Phone = "210-6792374", PostalCode = 15275 });
            //sc.Sellers.Add(new Sellers { Name = "Media Markt", Address = "Vouliagmenis 14", Phone = "210-9345712", PostalCode = 17453 });
            //sc.Sellers.Add(new Sellers { Name = "InfoWorld", Address = "Ipeirou 23", Phone = "210-5484639", PostalCode = 19563 });

            ////Add Categories
            sc.Categories.Add(new Categories { Name = "Technology" });
            sc.Categories.Add(new Categories { Name = "Computers", ParentId = 1 });
            sc.Categories.Add(new Categories { Name = "Entertainment", ParentId = 1 });
            sc.Categories.Add(new Categories { Name = "Gaming", ParentId = 1 });
            sc.Categories.Add(new Categories { Name = "Monitors", ParentId = 2 });
            sc.Categories.Add(new Categories { Name = "HardWare", ParentId = 2 });

            //Mnitor Attributes
            sc.ItemKeys.Add(new ItemKeys { Description = "Size", Units = "Inches", CategoriesId = 4 });
            sc.ItemKeys.Add(new ItemKeys { Description = "Size", Units = "Inches", CategoriesId = 4 });




            //sc.Categories.Add(new Categories { Name = "Rams", ParentId = 5 });


            //sc.Categories.Add(new Categories { Name = "Motherboards", ParentId = 5 });


            //sc.Categories.Add(new Categories { Name = "HardDrives", ParentId = 5 });
            sc.ItemKeys.Add(new ItemKeys { Units = "GB", CategoriesId = 8 });
            sc.ItemKeys.Add(new ItemKeys { Units = "GBit/s", CategoriesId = 8 });


            //sc.Categories.Add(new Categories { Name = "Processors", ParentId = 5 });


            //sc.Categories.Add(new Categories { Name = "VGAs", ParentId = 5 });


            //sc.Categories.Add(new Categories { Name = "PSUs", ParentId = 5 });


            //sc.Categories.Add(new Categories { Name = "Televisions", ParentId = 3 });


            //sc.Categories.Add(new Categories { Name = "Projectors", ParentId = 3 });


            //sc.Categories.Add(new Categories { Name = "Consoles", ParentId = 4 });


            //sc.Categories.Add(new Categories { Name = "Virtual Reality", ParentId = 4 });



            //Add Products
            //Rams
            sc.Products.Add(new Products { Name = "Corsair CMZ8GX3M2A1600C9 Vengeance 8 GB (2 x 4 GB) DDR3 1600 MHz CL9 XMP Performance Desktop Memory Kit - Black", CategoriesId = 7 });
            sc.Products.Add(new Products { Name = "HyperX FURY 8 GB (2 x 4 GB) DDR3 1866 MHz CL10 DIMM Memory Module Kit - Black", CategoriesId = 7 });
            sc.Products.Add(new Products { Name = "Corsair CMY16GX3M2A2400C11R Vengeance Pro Series 16GB (2x8GB) DDR3 2400Mhz CL11 XMP Performance Desktop Memory Kit - Red", CategoriesId = 7 });
            sc.Products.Add(new Products { Name = "Ballistix Sport 8GB Kit (4GBx2) DDR3 1600 MT/s (PC3-12800) UDIMM 240-Pin Memory - BLS2CP4G3D1609DS1S00CEU", CategoriesId = 7 });
            sc.Products.Add(new Products { Name = "Crucial 8 GB (4 GB x 2) DDR3L 1600 MT/s (PC3L-12800) SODIMM 204-Pin Memory Kit", CategoriesId = 7 });


            //Motherboards
            sc.Products.Add(new Products { Name = "ASRock Z170 Extreme4 Skylake ATX Motherboard", CategoriesId = 8 });
            sc.Products.Add(new Products { Name = "AsRock Z170 Gaming K6 Skylake ATX Motherboard", CategoriesId = 8 });
            sc.Products.Add(new Products { Name = "Asus Z170 Pro Motherboard (Socket 1151, Z170, DDR4, S-ATA 600, ATX, SupremeFX, Sonic Radar ll)", CategoriesId = 8 });
            sc.Products.Add(new Products { Name = "Gigabyte Z97P-D3 Intel LGA1150 Z97 ATX Motherboard (4x DDR3, 4x USB3.0, 10x USB2.0, GBE, LAN, HDMI)", CategoriesId = 8 });
            sc.Products.Add(new Products { Name = "MSI Z97 Gaming 3 Intel LGA1150 Z97 ATX Motherboard (4x DDR3, 6x USB3.0, 6x USB2.0, GBE, LAN, HDMI, DVI, DP, VGA)", CategoriesId = 8 });


            //HardDrives
            sc.Products.Add(new Products { Name = "KingDian 120GB 240GB 480GB With 128M Cache SATAIII SSD Solid State Drive (S280 120GB)", CategoriesId = 9 });
            sc.Products.Add(new Products { Name = "Kingston Technology 120 GB Solid State Drive 2.5 inch V300 SATA 3", CategoriesId = 9 });
            sc.Products.Add(new Products { Name = "Samsung 750 EVO 250 GB 2.5 inch Solid State Drive - Black", CategoriesId = 9 });
            sc.Products.Add(new Products { Name = "Samsung 850 EVO 500 GB 2.5 inch Solid State Drive", CategoriesId = 9 });
            sc.Products.Add(new Products { Name = "Seagate ST1000DX001 3.5 inch 1TB Hybrid Internal Solid State Drive", CategoriesId = 9 });


            //Processors
            sc.Products.Add(new Products { Name = "AMD Athlon X4 860K Quad-Core 3.7GHz 4MB Socket FM2+ 95W Desktop Processor", CategoriesId = 10 });
            sc.Products.Add(new Products { Name = "AMD FX-9370 Black Edition Octa Core CPU (Retail, Socket AM3+, 4.70GHz, 8MB, 220W)", CategoriesId = 10 });
            sc.Products.Add(new Products { Name = "Intel Core i5 4690K Processor (3.5 GHz, 6 MB Cache, LGA1150 Socket)", CategoriesId = 10 });
            sc.Products.Add(new Products { Name = "Intel Core i7 Quad-Core i7-6700 3.4GHz Processor CPU", CategoriesId = 10 });
            sc.Products.Add(new Products { Name = "Intel Core I7-6700K Processor (4 GHz, 8 M Cache, LGA1151)", CategoriesId = 10 });


            //VGAs
            sc.Products.Add(new Products { Name = "ASUS GTX750TI-OC-2GD5 - NVIDIA GTX", CategoriesId = 11 });
            sc.Products.Add(new Products { Name = "EVGA Nvidia GTX 1070 Founders Edition 8Gb GDDR5 1683mhz Boost, 1506Mhz Base, DP, HDMI, DL DVI PCI E Graphics Card", CategoriesId = 11 });
            sc.Products.Add(new Products { Name = "Gigabyte GV-N710D3-2GL NVIDIA GeForce GT 710 PCI Express 2.0 2 GB Graphics Card - Multi-Colour", CategoriesId = 11 });
            sc.Products.Add(new Products { Name = "MSI NVIDIA GeForce GTX 1060 GAMING X 3 GB GDDR5 Memory PCI Express 3 Zero Froze Cooling Graphics Card", CategoriesId = 11 });
            sc.Products.Add(new Products { Name = "Sapphire AMD RX460 Nitro+ 4 GB GDDR5 Memory Polaris FinFET DX 12 Vulkan FreeSync PCI Express Graphics Card", CategoriesId = 11 });


            //PSUs
            sc.Products.Add(new Products { Name = "9V Multi-Plug 5 Way Power Supply fits Behringer PSU-SB", CategoriesId = 12 });
            sc.Products.Add(new Products { Name = "ACE 400W PSU with 12cm Fan and SATA 24-Pin Model - Grey", CategoriesId = 12 });
            sc.Products.Add(new Products { Name = "Cooler Master B Series B500 ver.2 PSU", CategoriesId = 12 });
            sc.Products.Add(new Products { Name = "Corsair VS350 Power Supply Unit", CategoriesId = 12 });
            sc.Products.Add(new Products { Name = "PSU, 750W BLACK ATX & RED FAN, ACE PSUACE750BR By ACE & Best Price Square", CategoriesId = 12 });


            //Televisions
            sc.Products.Add(new Products { Name = "Hisense 49 - Inch Widescreen 4K Smart LED TV with Freeview HD", CategoriesId = 13 });
            sc.Products.Add(new Products { Name = "LG 55UH605V 55 inch Ultra HD 4K Smart TV WebOS (HDR Pro, Local Dimming, ColorPrime Pro, Ultra Surround) - Silver", CategoriesId = 13 });
            sc.Products.Add(new Products { Name = "Panasonic TX-50DX700B 50-inch 1400 Hz 4K Ultra HD Smart LED TV with Freeview Play (2016 Model) - Silver", CategoriesId = 13 });
            sc.Products.Add(new Products { Name = "Sharp LC-40CFF5221K 40-Inch Widescreen 1080p Full HD LED TV with Freeview", CategoriesId = 13 });
            sc.Products.Add(new Products { Name = "Sony Bravia KD55XD8005 55 inch Android 4K HDR Ultra HD Smart TV with TRILUMINOS Display, PlayStation", CategoriesId = 13 });


            //Projectors
            sc.Products.Add(new Products { Name = "Abdtech 1200 Lumens Mini LED Multimedia Home Theater", CategoriesId = 14 });
            sc.Products.Add(new Products { Name = "ELEPHAS Full Color 130 Portable LED Pico Projector with HDMI cable 1000 lumen for Home Entertainment, Party and Games, Black", CategoriesId = 14 });
            sc.Products.Add(new Products { Name = "Epson EB-S31 Portable", CategoriesId = 14 });
            sc.Products.Add(new Products { Name = "Optoma HD141X Full HD 3D 1080p Projector", CategoriesId = 14 });
            sc.Products.Add(new Products { Name = "PowerLead Vpun PL-UC40 Pro Mini Portable LCD LED Home Theater", CategoriesId = 14 });


            //Consoles
            sc.Products.Add(new Products { Name = "PXP 3 Slim Station 16 Bit Portable Video Game Console (Colours May Vary)", CategoriesId = 15 });
            sc.Products.Add(new Products { Name = "Sega Mega Drive Classic Game Console with 80 Games (Electronic Games)", CategoriesId = 15 });
            sc.Products.Add(new Products { Name = "Sony PlayStation 4 500GB with Uncharted 4 Bundle", CategoriesId = 15 });
            sc.Products.Add(new Products { Name = "Sony PlayStation 4 500GB", CategoriesId = 15 });
            sc.Products.Add(new Products { Name = "Xbox One S FIFA 17 Bundle (500GB)", CategoriesId = 15 });


            //Virtual Reality
            sc.Products.Add(new Products { Name = "Aizbo® 3D VR Virtual Reality Headset 3D VR Glasses For Samsung iPhone 4~6“ inch", CategoriesId = 16 });
            sc.Products.Add(new Products { Name = "AUKEY VR Headset Virtual Reality 3D Glasses with Adjustable Lens and Lens Distance for Film and Video Games, Compatible with Smartphone from 4.0 - 5.5 inches, Such as iPhone, Samsung, etc.(VR-", CategoriesId = 16 });
            sc.Products.Add(new Products { Name = "ELEGIANT 3D VR Glasses Headset Virtual Reality Box Headset", CategoriesId = 16 });
            sc.Products.Add(new Products { Name = "SIDARDOE 3D VR Glasses, Virtual Reality Headset with Android Bluetooth Remote Controller,", CategoriesId = 16 });
            sc.Products.Add(new Products { Name = "VRBox 3D VR Virtual Reality Headset 3D Glasses VR BOX", CategoriesId = 16 });



            //Remove stuff
            //sc.Products.Add(new Products { Name = "Virtual Reality", CategoriesId = 4 });
            //sc.Sellers.Remove(sc.Sellers.Where(m => m.Name == "Cosmodata").FirstOrDefault());
            //sc.Categories.Remove(sc.Categories.Where(m => m.Name == "Technology").FirstOrDefault());
            //sc.Categories.Remove(sc.Categories.Where(m => m.Name == "Computers").FirstOrDefault());
            //sc.Categories.Remove(sc.Categories.Where(m => m.Name == "Entertainment").FirstOrDefault());
            //sc.Categories.Remove(sc.Categories.Where(m => m.Name == "Gaming").FirstOrDefault());

            sc.Products.SqlQuery("TRUNCATE TABLE");

            sc.SaveChanges();
            return View();
        }
    }
}