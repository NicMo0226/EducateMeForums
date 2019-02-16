using System;
using System.ComponentModel.DataAnnotations;

namespace EducateMeForums.ViewModels.ApplicationUser
{
    public class ProfileModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserRating { get; set; }
        public string ProfileImageUrl { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public DateTime MemberSince { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string Introduction { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }

        public string HighestAchievement { get; set; }
        public string Subject { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime AchievedWhen { get; set; }

        public string AcademicInstitution { get; set; }
        public string Website { get; set; }

        public string WallPostTitle { get; set; }
        public DateTime Posted { get; set; }
        public string WallPostAuthor { get; set; }
        public string WallPostBodyContent { get; set; }

        public DateTime CommentPosted { get; set; }
        public string CommentAuthor { get; set; }
        public string CommentBodyContent { get; set; }    

    }
}