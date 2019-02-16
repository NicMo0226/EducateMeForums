using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducateMeForums.ViewModels.Portfolio
{
    public class NewPortfolioModel
    {
        [Display(Name = "Highest Level of Achievement")]
        public string HighestAchievement { get; set; }

        [Display(Name = "Main Subject")]
        public string Subject { get; set; }

        [Display(Name = "Achieved when?")]
        [DataType(DataType.Date)]
        public DateTime AchievedWhen { get; set; }

        [Display(Name = "Academic Institution where achievement was gained?")]
        public string AcademicInstitution { get; set; }

        [Display(Name = "Add a link to your website")]
        public string Website { get; set; }
                public string UserId { get; set; }
    }
}
