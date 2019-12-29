namespace E_CommerceWebSite.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eCommerceConfigs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "eCommerce.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "eCommerce.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductDescriptin = c.String(),
                        ProductPrice = c.Double(nullable: false),
                        ProductImage = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("eCommerce.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("eCommerce.Products", "CategoryId", "eCommerce.Categories");
            DropIndex("eCommerce.Products", new[] { "CategoryId" });
            DropTable("eCommerce.Products");
            DropTable("eCommerce.Categories");
        }
    }
}
