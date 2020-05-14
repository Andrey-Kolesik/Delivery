namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMenu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                        FoodCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Menus");
        }
    }
}
