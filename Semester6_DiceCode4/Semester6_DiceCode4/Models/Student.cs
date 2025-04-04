using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Semester6_DiceCode4.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        public ICollection<StudentVak> StudentVakken { get; set; }
    }
}
