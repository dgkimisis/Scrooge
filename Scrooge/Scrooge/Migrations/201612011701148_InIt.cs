namespace Scrooge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InIt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prices", "ProductsId", "dbo.Products");
            DropForeignKey("dbo.Products", "Sellers_Id", "dbo.Sellers");
            DropForeignKey("dbo.Prices", "SellersId", "dbo.Sellers");
            DropForeignKey("dbo.Prices", "Specs_Id", "dbo.Specs");
            DropForeignKey("dbo.Specs", "ProductsId", "dbo.Products");
            DropIndex("dbo.Products", new[] { "Sellers_Id" });
            DropIndex("dbo.Specs", new[] { "ProductsId" });
            DropIndex("dbo.Prices", new[] { "ProductsId" });
            DropIndex("dbo.Prices", new[] { "SellersId" });
            DropIndex("dbo.Prices", new[] { "Specs_Id" });
            CreateTable(
                "dbo.Distinctions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductsId, cascadeDelete: true)
                .Index(t => t.ProductsId);
            
            CreateTable(
                "dbo.DPCombos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DistinctionsId = c.Int(nullable: false),
                        SellersId = c.Int(nullable: false),
                        Pricetag = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Distinctions", t => t.DistinctionsId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellersId, cascadeDelete: true)
                .Index(t => t.DistinctionsId)
                .Index(t => t.SellersId);
            
            DropColumn("dbo.Products", "Sellers_Id");
            DropTable("dbo.Specs");
            DropTable("dbo.Prices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductsId = c.Int(nullable: false),
                        SellersId = c.Int(nullable: false),
                        Pricetag = c.Int(nullable: false),
                        Specs_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductsId = c.Int(nullable: false),
                        Measurements = c.String(),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Sellers_Id", c => c.Int());
            DropForeignKey("dbo.Distinctions", "ProductsId", "dbo.Products");
            DropForeignKey("dbo.DPCombos", "SellersId", "dbo.Sellers");
            DropForeignKey("dbo.DPCombos", "DistinctionsId", "dbo.Distinctions");
            DropIndex("dbo.DPCombos", new[] { "SellersId" });
            DropIndex("dbo.DPCombos", new[] { "DistinctionsId" });
            DropIndex("dbo.Distinctions", new[] { "ProductsId" });
            DropTable("dbo.DPCombos");
            DropTable("dbo.Distinctions");
            CreateIndex("dbo.Prices", "Specs_Id");
            CreateIndex("dbo.Prices", "SellersId");
            CreateIndex("dbo.Prices", "ProductsId");
            CreateIndex("dbo.Specs", "ProductsId");
            CreateIndex("dbo.Products", "Sellers_Id");
            AddForeignKey("dbo.Specs", "ProductsId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Prices", "Specs_Id", "dbo.Specs", "Id");
            AddForeignKey("dbo.Prices", "SellersId", "dbo.Sellers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "Sellers_Id", "dbo.Sellers", "Id");
            AddForeignKey("dbo.Prices", "ProductsId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
