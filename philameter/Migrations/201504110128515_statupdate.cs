namespace philameter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stats", "PanelClass", c => c.String());
            AddColumn("dbo.Stats", "FontAwesomeIcon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stats", "FontAwesomeIcon");
            DropColumn("dbo.Stats", "PanelClass");
        }
    }
}
