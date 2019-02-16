using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducateMeForums.ViewModels.WallPost
{
    public class WallPostIndex
    {
        public int Id { get; set;  } 
        public string WallPostTitle { get; set; }

        public DateTime Posted { get; set; }
        public string WallPostAuthor { get; set; }

        [Required]
        public string WallPostBodyContent { get; set; }
      
    }
}