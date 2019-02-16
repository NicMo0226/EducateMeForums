using System;
using System.ComponentModel.DataAnnotations;

namespace EducateMeForums.Models
{
    public class PostReply
    {
        public int Id { get; set; }



        [Display(Name = "Date of Comment")]
        public DateTime Created { get; set; }
  

        [Display(Name = "Comment")]
        public string Content { get; set; }

        [Display(Name = "Post Title")]
        public string Title { get; set; }
  

        public virtual ApplicationUser User { get; set; }
       public virtual Post Post { get; set; }
    }
}