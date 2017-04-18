using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendia.Models
{
    public class ScholarshipCategory
    {
        /// <summary>
        /// Идентификатор категории стипендии.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название категории.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Сумма стипендии.
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// Тип категории
        /// </summary>
        public ScholarshipCategoryType CategoryType { get; set; }
        /// <summary>
        /// Список студентов
        /// </summary>
        public List<Student> Student { get; set; }
    }
    public enum ScholarshipCategoryType
    {
        Performance=1,
        Privileges=2
    }
}
