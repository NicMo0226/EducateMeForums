using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducateMeForums.Models
{
    public class Comment
    {
        public int Id { get; set;  }

        [Display(Name = "Date of Comment")]
        public DateTime CommentPosted { get; set; }


        [Display(Name = "Comment by")]
        public string CommentAuthor { get; set; }

             [Display(Name = "Comment")]
        public string CommentBodyContent { get; set; }

        [ForeignKey("WallPostId")]
        public WallPost WallComment { get; set; }
    
       
    }
}