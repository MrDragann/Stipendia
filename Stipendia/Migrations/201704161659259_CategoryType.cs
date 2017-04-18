namespace Stipendia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScholarshipCategories", "CategoryType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScholarshipCategories", "CategoryType");
        }
    }
}
