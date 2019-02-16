using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducateMeForums.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Display(Name = "Post Title")]
        public string Title { get; set; }


        [Display(Name = "Post text")]
       public string Content { get; set; }
        
        
        
        [Display(Name = "Posted on")]

        public DateTime Created { get; set; }


       public virtual ApplicationUser User { get; set; }

         public virtual Forum Forum { get; set; }

       public virtual IEnumerable<PostReply> Replies {get; set;}
    
    }
}