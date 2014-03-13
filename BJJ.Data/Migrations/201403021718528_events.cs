namespace BJJ.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class events : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Events", new[] { "SchoolId" });
            AddColumn("dbo.Events", "School_SchoolId", c => c.Int());
            CreateIndex("dbo.Events", "School_SchoolId");
            AddForeignKey("dbo.Events", "School_SchoolId", "dbo.Schools", "SchoolId");
            DropColumn("dbo.Events", "SchoolId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "SchoolId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Events", "School_SchoolId", "dbo.Schools");
            DropIndex("dbo.Events", new[] { "School_SchoolId" });
            DropColumn("dbo.Events", "School_SchoolId");
            CreateIndex("dbo.Events", "SchoolId");
            AddForeignKey("dbo.Events", "SchoolId", "dbo.Schools", "SchoolId", cascadeDelete: true);
        }
    }
}
