using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducateMeForums.Models
{
    public class WallPost
    {
        public int Id { get; set; }

        [Display(Name = "Post Title")]
        public string WallPostTitle { get; set; }

        [Display(Name = "Posted on")]
        public DateTime Posted { get; set; }

        [Display(Name = "Post text")]
        public string WallPostBodyContent { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}