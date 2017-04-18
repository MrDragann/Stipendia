namespace Stipendia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scInt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ScholarshipCategoryStudents", "ScholarshipCategory_Id", "dbo.ScholarshipCategories");
            DropPrimaryKey("dbo.ScholarshipCategories");
            AlterColumn("dbo.ScholarshipCategories", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ScholarshipCategories", "Id");
            AddForeignKey("dbo.ScholarshipCategoryStudents", "ScholarshipCategory_Id", "dbo.ScholarshipCategories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScholarshipCategoryStudents", "ScholarshipCategory_Id", "dbo.ScholarshipCategories");
            DropPrimaryKey("dbo.ScholarshipCategories");
            AlterColumn("dbo.ScholarshipCategories", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ScholarshipCategories", "Id");
            AddForeignKey("dbo.ScholarshipCategoryStudents", "ScholarshipCategory_Id", "dbo.ScholarshipCategories", "Id", cascadeDelete: true);
        }
    }
}
