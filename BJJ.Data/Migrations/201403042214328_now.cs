namespace BJJ.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class now : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Articles", new[] { "SchoolId" });
            RenameColumn(table: "dbo.Articles", name: "SchoolId", newName: "School_SchoolId");
            AlterColumn("dbo.Articles", "School_SchoolId", c => c.Int());
            CreateIndex("dbo.Articles", "School_SchoolId");
            AddForeignKey("dbo.Articles", "School_SchoolId", "dbo.Schools", "SchoolId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "School_SchoolId", "dbo.Schools");
            DropIndex("dbo.Articles", new[] { "School_SchoolId" });
            AlterColumn("dbo.Articles", "School_SchoolId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Articles", name: "School_SchoolId", newName: "SchoolId");
            CreateIndex("dbo.Articles", "SchoolId");
            AddForeignKey("dbo.Articles", "SchoolId", "dbo.Schools", "SchoolId", cascadeDelete: true);
        }
    }
}
