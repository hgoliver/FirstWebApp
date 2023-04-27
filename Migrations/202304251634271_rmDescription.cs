namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rmDescription : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Product", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "Description", c => c.String(maxLength: 8000, unicode: false));
        }
    }
}
