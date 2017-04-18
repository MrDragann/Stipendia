using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendia.Models
{
    public class Student
    {
        /// <summary>
        /// Идентификатор студента
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия студента
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// Имя студента
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Отчество студента
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Ссылка на группу.
        /// </summary>
        public Group Group { get; set; }
        /// <summary>
        /// Список категорий стипендий.
        /// </summary>
        public List<ScholarshipCategory> ScholarshipCategories { get; set; }
        /// <summary>
        /// Буджет или контракт.
        /// </summary>
        public bool Budget { get; set; }
        //public int ProgressId { get; set; }
        //public List<Progress> Progress { get; set; }
        //public EnumMonths ScholarshipId { get; set; }
        /// <summary>
        /// Ссылка на начисления
        /// </summary>
        public List<Scholarship> Scholarship { get; set; }
    }
}
