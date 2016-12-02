namespace Scrooge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ar : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Company");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Company", c => c.String());
        }
    }
}
