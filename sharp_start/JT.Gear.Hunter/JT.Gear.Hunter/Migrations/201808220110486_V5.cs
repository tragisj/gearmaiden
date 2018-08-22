namespace File.Cutter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GearItems", "Category_CategoryId", c => c.Int());
            CreateIndex("dbo.GearItems", "Category_CategoryId");
            AddForeignKey("dbo.GearItems", "Category_CategoryId", "dbo.Categories", "CategoryId");
            DropColumn("dbo.GearItems", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GearItems", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.GearItems", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.GearItems", new[] { "Category_CategoryId" });
            DropColumn("dbo.GearItems", "Category_CategoryId");
        }
    }
}
