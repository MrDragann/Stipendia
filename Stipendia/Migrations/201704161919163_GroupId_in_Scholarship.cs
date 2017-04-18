namespace Stipendia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GroupId_in_Scholarship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scholarships", "GroupId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scholarships", "GroupId");
        }
    }
}
