using System.ComponentModel.DataAnnotations;

namespace ExamTakeHomeLvl7.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }

    }
}
