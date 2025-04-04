using Semester6_DiceCode4.Models;

namespace Semester6_DiceCode4.Models
{
    public class StudentVak
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int VakId { get; set; }
        public Vak Vak { get; set; }
    }
}
