using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducateMeForums.Models
{
    public class Forum
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Forum Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Forum Description")]
        public string Description { get; set; }



        [Display(Name = "Forum created on")]
        public DateTime Created { get; set; }


        [Required]
        [Display(Name = "Forum Image")]
        public string ImageUrl { get; set; }


        [Display(Name = "Number of Posts")]
        public int NumberOfPosts { get; set; }


        [Display(Name = "Number of Users")]
        public int NumberOfUsers { get; set; }
        public bool HasRecentPost { get; set; }


        public virtual IEnumerable<Post> Posts { get; set; }
    }
}