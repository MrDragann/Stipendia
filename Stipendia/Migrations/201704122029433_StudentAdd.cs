namespace Stipendia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentAdd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentProgresses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentProgresses", "Progress_Id", "dbo.Progresses");
            DropForeignKey("dbo.Students", "SpecialtyId", "dbo.Specialties");
            DropIndex("dbo.Students", new[] { "SpecialtyId" });
            DropIndex("dbo.StudentProgresses", new[] { "Student_Id" });
            DropIndex("dbo.StudentProgresses", new[] { "Progress_Id" });
            DropColumn("dbo.Students", "SpecialtyId");
            DropColumn("dbo.Students", "AverageScore");
            DropTable("dbo.StudentProgresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentProgresses",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Progress_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Progress_Id });
            
            AddColumn("dbo.Students", "AverageScore", c => c.Double(nullable: false));
            AddColumn("dbo.Students", "SpecialtyId", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentProgresses", "Progress_Id");
            CreateIndex("dbo.StudentProgresses", "Student_Id");
            CreateIndex("dbo.Students", "SpecialtyId");
            AddForeignKey("dbo.Students", "SpecialtyId", "dbo.Specialties", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentProgresses", "Progress_Id", "dbo.Progresses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentProgresses", "Student_Id", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
