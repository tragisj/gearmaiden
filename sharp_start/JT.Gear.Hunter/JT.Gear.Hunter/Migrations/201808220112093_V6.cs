namespace File.Cutter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.GearItems",
                c => new
                    {
                        GearItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.GearItemId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .Index(t => t.Category_CategoryId);
            
            CreateTable(
                "dbo.ItemLists",
                c => new
                    {
                        ItemListId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Classification = c.String(),
                        Created = c.DateTime(nullable: false),
                        Trip_TripId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemListId)
                .ForeignKey("dbo.Trips", t => t.Trip_TripId)
                .Index(t => t.Trip_TripId);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TripDate = c.String(),
                    })
                .PrimaryKey(t => t.TripId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemLists", "Trip_TripId", "dbo.Trips");
            DropForeignKey("dbo.GearItems", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.ItemLists", new[] { "Trip_TripId" });
            DropIndex("dbo.GearItems", new[] { "Category_CategoryId" });
            DropTable("dbo.Trips");
            DropTable("dbo.ItemLists");
            DropTable("dbo.GearItems");
            DropTable("dbo.Categories");
        }
    }
}
