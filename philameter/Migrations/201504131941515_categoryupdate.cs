namespace philameter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "FontAwesomeIcon", c => c.String());
            DropTable("dbo.StatTags");
            DropTable("dbo.Tags");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Categories", "FontAwesomeIcon");
        }
    }
}
