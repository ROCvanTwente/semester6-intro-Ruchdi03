namespace Semester6_DiceCode4.Models
{
    public class CijferWijziging
    {
        public int Id { get; set; }
        public int StudentId { get; set; }  
        public int VakId { get; set; }
        public int ToetsId { get; set; } 
        public int? OudCijfer { get; set; }  
        public int? NieuwCijfer { get; set; } 
        public DateTime WijzigingsDatum { get; set; } = DateTime.Now; 
    }
}
