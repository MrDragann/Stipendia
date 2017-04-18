namespace Stipendia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecialtyAbbreviature1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Groups", "Specialty_Id", "dbo.Specialties");
            DropIndex("dbo.Groups", new[] { "Specialty_Id" });
            RenameColumn(table: "dbo.Groups", name: "Specialty_Id", newName: "SpecialtyId");
            AlterColumn("dbo.Groups", "SpecialtyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Groups", "SpecialtyId");
            AddForeignKey("dbo.Groups", "SpecialtyId", "dbo.Specialties", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "SpecialtyId", "dbo.Specialties");
            DropIndex("dbo.Groups", new[] { "SpecialtyId" });
            AlterColumn("dbo.Groups", "SpecialtyId", c => c.Int());
            RenameColumn(table: "dbo.Groups", name: "SpecialtyId", newName: "Specialty_Id");
            CreateIndex("dbo.Groups", "Specialty_Id");
            AddForeignKey("dbo.Groups", "Specialty_Id", "dbo.Specialties", "Id");
        }
    }
}
