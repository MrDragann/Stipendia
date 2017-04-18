using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendia.Models
{
    public class Scholarship
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Список студентов
        /// </summary>
        public List<Student> Students { get; set; }
        /// <summary>
        /// Месяц
        /// </summary>
        public string Month { get; set; }
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Наименование курса
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// Сумма стипендии
        /// </summary>
        public double Value { get; set; }
    }

    
}
