using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Semester6_DiceCode4.Models;

namespace Semester6_DiceCode4.Models
{
    public class Docent
    {
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        public ICollection<Vak> Vakken { get; set; }
    }
}
