namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Description : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 8000, unicode: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
        }
    }
}
