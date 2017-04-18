using Stipendia.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Stipendia
{
    /// <summary>
    /// Класс для управления данными, связанными со студентами
    /// </summary>
    public class StudentServices
    {
        public static StudentServices Instance = new StudentServices();
        const string DefaultSelect = "*Все*";
        /// <summary>
        /// Удаление выбранного студента
        /// </summary>
        /// <param name="id"></param>
        public void DeleteStudent(int id)
        {
            using (var db = new DataContext())
            {
                var Student = db.Students.FirstOrDefault(x => x.Id == id);
                db.Students.Remove(Student);
                db.SaveChanges();
            }
        }
        public List<Student> StudentListSort(string SpecialtySort, string ScholarshipCategorySort,
            string CourseSort,string GroupSort)
        {
            using(var db=new DataContext())
            {
                var students = db.Students.Include(x => x.Group).Include(x => x.ScholarshipCategories)
                    .ToList();

                if (SpecialtySort != DefaultSelect && SpecialtySort != null)
                {
                    var SpecialtyId = db.Specialties.FirstOrDefault(x => x.Abbreviature == SpecialtySort).Id;
                    students = students
                    .Where(x => x.Group.SpecialtyId == SpecialtyId).ToList();
                }
                if (GroupSort != DefaultSelect && GroupSort != null)
                {
                    students = students
                    .Where(x => x.Group.Name == GroupSort).ToList();
                }
                if (CourseSort != DefaultSelect && CourseSort != null)
                {
                    students = students
                    .Where(x => x.Group.CourseName == CourseSort).ToList();
                }
                if (ScholarshipCategorySort != DefaultSelect && ScholarshipCategorySort != null)
                {
                    students = students
                    .Where(x => x.ScholarshipCategories.FirstOrDefault().Name == ScholarshipCategorySort 
                    || x.ScholarshipCategories.LastOrDefault().Name == ScholarshipCategorySort).ToList();
                }
                return students;
            }
        }
        
    }
}
