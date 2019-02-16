using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducateMeForums.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        [Display(Name = "Highest Level of Achievement")]
        public string HighestAchievement { get; set; }

        [Display(Name = "Main Subject")]
        public string Subject { get; set; }

        [Display(Name = "Achieved when?")]
        [DataType(DataType.Date)]
        public DateTime AchievedWhen { get; set; }

        [Display(Name = "Academic Institution where qualification obtained?")]
        public string AcademicInstitution { get; set; }

        [Display(Name = "Add a link to your website")]
        public string Website { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

    }
}