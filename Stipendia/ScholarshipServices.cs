using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Stipendia.Models;
using Word = Microsoft.Office.Interop.Word;

namespace Stipendia
{
    /// <summary>
    /// Класс для управления данными, связанными со стипендиями
    /// </summary>
    public class ScholarshipServices
    {
        public static ScholarshipServices Instance = new ScholarshipServices();
        const string DefaultSelect = "*Все*";
        /// <summary>
        /// Проверка на существование начислений
        /// </summary>
        /// <param name="month"></param>
        /// <param name="course"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        public string PrepareChargeScholarship(string month, string course, string group)
        {
            using (var db = new DataContext())
            {
                var Scholarships = db.Scholarships.Where(x => x.Month == month).ToList();
                if (course == DefaultSelect && group == DefaultSelect)
                {
                    if (Scholarships.Count > 0)
                    {
                        return "За выбранный Вами месяц \"" + month + "\" уже существуют начисления. Перезаписать их?";
                    }
                }
                else if (course != DefaultSelect && group == DefaultSelect)
                {
                    if (Scholarships.Where(x => x.CourseName == course).Count() > 0)
                    {
                        return "За выбранный Вами месяц \"" + month + "\" и \"" + course + "\" уже существуют начисления. Перезаписать их?";
                    }
                }
                else if (group != DefaultSelect)
                {
                    var GroupId = db.Groups.Where(x => x.Name == group).FirstOrDefault().Id;
                    if (Scholarships.Where(x => x.GroupId == GroupId).Count() > 0)
                    {
                        return "За выбранный Вами месяц \"" + month + "\", \"" + course + "\" и \"" + group + " группа\" уже существуют начисления. Перезаписать их?";
                    }
                }
                return "Ок";
            }

        }
        /// <summary>
        /// Начисление стипендий в соответствии с указанными параметрами
        /// </summary>
        /// <param name="month">Месяц</param>
        /// <param name="course">Курс</param>
        /// <param name="group">Группа</param>
        public void ChargeScholarship(string month, string course, string group, bool remove = false)
        {
            using (var db = new DataContext())
            {
                var students = db.Students.Include(x => x.Group).Include(x => x.ScholarshipCategories)
                    .Where(x => x.ScholarshipCategories.FirstOrDefault().Name != "Не получает"
                    && x.ScholarshipCategories.Count > 0).ToList();

                if (course != DefaultSelect)
                {
                    students = students
                    .Where(x => x.Group.CourseName == course).ToList();
                }
                if (group != DefaultSelect)
                {
                    students = students
                    .Where(x => x.Group.Name == group).ToList();
                }
                if (remove) { RemoveChergetScholarship(month, course, group); }
                foreach (var student in students)
                {
                    double ScholarshipValue = 0;
                    if (student.ScholarshipCategories.FirstOrDefault().CategoryType == ScholarshipCategoryType.Performance
                        && student.ScholarshipCategories.LastOrDefault().CategoryType == ScholarshipCategoryType.Privileges)
                    {
                        ScholarshipValue = student.ScholarshipCategories.FirstOrDefault().Value * 2;
                    }
                    else if (student.ScholarshipCategories.FirstOrDefault().CategoryType == ScholarshipCategoryType.Privileges
                        && student.ScholarshipCategories.LastOrDefault().CategoryType == ScholarshipCategoryType.Performance)
                    {
                        ScholarshipValue = student.ScholarshipCategories.LastOrDefault().Value * 2;
                    }
                    else
                    {
                        ScholarshipValue = student.ScholarshipCategories.LastOrDefault().Value;
                    }
                    db.Scholarships
                        .Add(new Scholarship()
                        {
                            Month = month,
                            Students = new List<Student>() { student },
                            GroupId = student.GroupId,
                            CourseName = student.Group.CourseName,
                            Value = ScholarshipValue
                        });
                }
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Удаление начислений
        /// </summary>
        /// <param name="month"></param>
        /// <param name="course"></param>
        /// <param name="group"></param>
        public void RemoveChergetScholarship(string month, string course, string group)
        {
            using (var db = new DataContext())
            {
                var Scholarships = db.Scholarships
                    .Where(x => x.Month == month).ToList();

                if (course != DefaultSelect)
                {
                    Scholarships = Scholarships
                    .Where(x => x.CourseName == course).ToList();
                }
                if (group != DefaultSelect)
                {
                    var GroupId = db.Groups.Where(x => x.Name == group).FirstOrDefault().Id;
                    Scholarships = Scholarships
                    .Where(x => x.GroupId == GroupId).ToList();
                }
                db.Scholarships.RemoveRange(Scholarships);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Формирование отчета по начислениям
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="filenameSave"></param>
        /// <param name="month"></param>
        /// <param name="course"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        public string CreateDocx(string filename, string filenameSave, string month, string course, string group)
        {
            var wordapp = new Word.Application();
            wordapp.Visible = false;
            var worddocument = wordapp.Documents.Open(filename);
            Word.Table table = worddocument.Tables[1];
            try
            {
                using (var db = new DataContext())
                {
                    var GroupId = db.Groups.FirstOrDefault(x => x.Name == group).Id;
                    int i = 1;
                    var scholarships = db.Scholarships.Include(x => x.Students)
                        .Where(x => x.Month == month && x.GroupId == GroupId).ToList();
                    ReplaceWordSub("{Group}", group, worddocument);
                    ReplaceWordSub("{Month}", month, worddocument);

                    double TotalValue = 0;
                    foreach (var student in scholarships)
                    {
                        i++;
                        table.Rows.Add();
                        table.Cell(i, 1).Range.Text = (i - 1).ToString();
                        table.Cell(i, 2).Range.Text = student.Students.FirstOrDefault()
                            .Firstname + " " + student.Students.FirstOrDefault().Lastname + " " + student.Students
                            .FirstOrDefault().Patronymic;

                        table.Cell(i, 3).Range.Text = student.Value.ToString();
                        TotalValue += student.Value;
                    }
                    table.Rows[i + 1].Delete();
                    ReplaceWordSub("{TotalValue}", TotalValue.ToString(), worddocument);
                    worddocument.SaveAs(filenameSave);
                    worddocument.Close();
                }
            }
            catch
            {
                worddocument.Close();
            }
            return "Отчет успешно сгенерирован";
        }
        private void ReplaceWordSub(string stubToReplace, string text, Word.Document WordDocument)
        {
            var range = WordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
