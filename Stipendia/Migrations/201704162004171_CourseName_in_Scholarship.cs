namespace Stipendia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseName_in_Scholarship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scholarships", "CourseName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scholarships", "CourseName");
        }
    }
}
