namespace Dishes11d.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dishes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        DishType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishTypes", t => t.DishType_Id)
                .Index(t => t.DishType_Id);
            
            CreateTable(
                "dbo.DishTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "DishType_Id", "dbo.DishTypes");
            DropIndex("dbo.Dishes", new[] { "DishType_Id" });
            DropTable("dbo.DishTypes");
            DropTable("dbo.Dishes");
        }
    }
}
