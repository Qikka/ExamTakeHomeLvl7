using System.ComponentModel.DataAnnotations;

namespace ExamTakeHomeLvl7.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Activity Name")]
        public string Name { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

    }
}
