namespace philameter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class category : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Stats", "Category_Id", c => c.Int());
            CreateIndex("dbo.Stats", "Category_Id");
            AddForeignKey("dbo.Stats", "Category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stats", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Stats", new[] { "Category_Id" });
            DropColumn("dbo.Stats", "Category_Id");
            DropTable("dbo.Categories");
        }
    }
}
