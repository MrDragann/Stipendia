using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendia.Models
{
    public class Progress
    {
        public int Id { get; set; }
        //public List<Student> Students { get; set; }
        public EnumSemester Semester { get; set; }
        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; }
        public int Evaluation { get; set; }
    }

    public enum EnumSemester
    {
        Semester1=1,
        Semester2=2
    }
}
