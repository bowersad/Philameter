namespace philameter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialupdte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Stats", "Stat", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stats", "Stat", c => c.Int(nullable: false));
        }
    }
}
