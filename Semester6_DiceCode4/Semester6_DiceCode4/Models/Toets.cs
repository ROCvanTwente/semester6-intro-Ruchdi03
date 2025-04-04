using System.ComponentModel.DataAnnotations;
using Semester6_DiceCode4.Models;

namespace Semester6_DiceCode4.Models
{
    public class Toets
    {
        public int Id { get; set; }

        public int VakId { get; set; }
        public Vak Vak { get; set; }

        [Required]
        public string Naam { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public double Cijfer { get; set; }

        public bool Herkansing { get; set; }
    }
}
