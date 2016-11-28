namespace Scrooge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sellers", "Adress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sellers", "Adress");
        }
    }
}
