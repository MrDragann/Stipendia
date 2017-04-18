using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendia.Models
{
    public class Group
    {
        /// <summary>
        /// Идентификатор группы.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование группы.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Идентификатор специальности
        /// </summary>
        //[ForeignKey("SpecialtyId")]
        public int SpecialtyId { get; set; }
        /// <summary>
        /// Ссылка на специальность.
        /// </summary>
        public Specialty Specialty { get; set; }
        /// <summary>
        /// Название курса.
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// Список студентов.
        /// </summary>
        public List<Student> Student { get; set; }
    }
}
