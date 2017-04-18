namespace Stipendia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecialtyAbbreviature : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Specialty_Id", c => c.Int());
            AddColumn("dbo.Specialties", "Abbreviature", c => c.String());
            CreateIndex("dbo.Groups", "Specialty_Id");
            AddForeignKey("dbo.Groups", "Specialty_Id", "dbo.Specialties", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "Specialty_Id", "dbo.Specialties");
            DropIndex("dbo.Groups", new[] { "Specialty_Id" });
            DropColumn("dbo.Specialties", "Abbreviature");
            DropColumn("dbo.Groups", "Specialty_Id");
        }
    }
}
