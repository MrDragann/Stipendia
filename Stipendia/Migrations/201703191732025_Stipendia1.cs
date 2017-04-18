namespace Stipendia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stipendia1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Disciplines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Progresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Semester = c.Int(nullable: false),
                        DisciplineId = c.Int(nullable: false),
                        Evaluation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplines", t => t.DisciplineId, cascadeDelete: true)
                .Index(t => t.DisciplineId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Patronymic = c.String(),
                        GroupId = c.Int(nullable: false),
                        SpecialtyId = c.Int(nullable: false),
                        AverageScore = c.Double(nullable: false),
                        Budget = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Specialties", t => t.SpecialtyId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.SpecialtyId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Scholarships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Month = c.String(),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ScholarshipCategories",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specialties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentProgresses",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Progress_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Progress_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Progresses", t => t.Progress_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Progress_Id);
            
            CreateTable(
                "dbo.ScholarshipStudents",
                c => new
                    {
                        Scholarship_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Scholarship_Id, t.Student_Id })
                .ForeignKey("dbo.Scholarships", t => t.Scholarship_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Scholarship_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.ScholarshipCategoryStudents",
                c => new
                    {
                        ScholarshipCategory_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ScholarshipCategory_Id, t.Student_Id })
                .ForeignKey("dbo.ScholarshipCategories", t => t.ScholarshipCategory_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.ScholarshipCategory_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SpecialtyId", "dbo.Specialties");
            DropForeignKey("dbo.ScholarshipCategoryStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.ScholarshipCategoryStudents", "ScholarshipCategory_Id", "dbo.ScholarshipCategories");
            DropForeignKey("dbo.ScholarshipStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.ScholarshipStudents", "Scholarship_Id", "dbo.Scholarships");
            DropForeignKey("dbo.StudentProgresses", "Progress_Id", "dbo.Progresses");
            DropForeignKey("dbo.StudentProgresses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Progresses", "DisciplineId", "dbo.Disciplines");
            DropIndex("dbo.ScholarshipCategoryStudents", new[] { "Student_Id" });
            DropIndex("dbo.ScholarshipCategoryStudents", new[] { "ScholarshipCategory_Id" });
            DropIndex("dbo.ScholarshipStudents", new[] { "Student_Id" });
            DropIndex("dbo.ScholarshipStudents", new[] { "Scholarship_Id" });
            DropIndex("dbo.StudentProgresses", new[] { "Progress_Id" });
            DropIndex("dbo.StudentProgresses", new[] { "Student_Id" });
            DropIndex("dbo.Students", new[] { "SpecialtyId" });
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropIndex("dbo.Progresses", new[] { "DisciplineId" });
            DropTable("dbo.ScholarshipCategoryStudents");
            DropTable("dbo.ScholarshipStudents");
            DropTable("dbo.StudentProgresses");
            DropTable("dbo.Specialties");
            DropTable("dbo.ScholarshipCategories");
            DropTable("dbo.Scholarships");
            DropTable("dbo.Groups");
            DropTable("dbo.Students");
            DropTable("dbo.Progresses");
            DropTable("dbo.Disciplines");
        }
    }
}
