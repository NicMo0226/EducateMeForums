using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducateMeForums.Models
{
    public class Demographic
    {
        public int Id { get; set; }
        
        [Display(Name = "What town do you reside in?")]
        public string Town { get; set; }

        [Display(Name = "In what Country?")]
        public string Country { get; set; }

        [Display(Name = "Introduction")]
        public string Introduction { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}