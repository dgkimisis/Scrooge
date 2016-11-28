namespace Scrooge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sellers", "Address", c => c.String());
            DropColumn("dbo.Sellers", "Adress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sellers", "Adress", c => c.String());
            DropColumn("dbo.Sellers", "Address");
        }
    }
}
