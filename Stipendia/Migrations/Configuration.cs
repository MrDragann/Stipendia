namespace Stipendia.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            //This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.
            //var db = new DataContext();
            //context.ScholarshipCategories.AddOrUpdate(
            //  p => p.Id,
            //  new ScholarshipCategory { Id = EnumScholarshipCategories.Devoid, Name = "�����(�)", Value = 0, Student = db.Students.Where(x => x.Id == 4).ToList() },
            //    new ScholarshipCategory { Id = EnumScholarshipCategories.Normal, Name = "������� ���������", Value = 200 },
            //    new ScholarshipCategory { Id = EnumScholarshipCategories.High, Name = "���������� ���������", Value = 300 }
            //  );

        }
    }
}
