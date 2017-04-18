using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendia.Models
{
    public class Specialty
    {
        /// <summary>
        /// Идентификатор Специальности.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Полное наименование специальности
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Аббревиатура специальности
        /// </summary>
        public string Abbreviature { get; set; }
        /// <summary>
        /// Список групп
        /// </summary>
        public List<Group> Group { get; set; }
    }
}
