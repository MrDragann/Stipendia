using Stipendia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendia
{
    public class DataContext : DbContext
    {
        public DataContext()
                : base("StipendiaDB")
        { }
        
        public DbSet<Student> Students { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Specialty> Specialties { get; set; }

        public DbSet<Discipline> Disciplines { get; set; }

        public DbSet<ScholarshipCategory> ScholarshipCategories { get; set; }

        public DbSet<Scholarship> Scholarships { get; set; }

        public DbSet<Progress> Progresses { get; set; }
    }
}
