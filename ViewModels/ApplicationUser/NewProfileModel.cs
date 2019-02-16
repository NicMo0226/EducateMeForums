using System;

namespace EducateMeForums.ViewModels.ApplicationUser
{
    public class NewProfileModel
    {

        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserRating { get; set; }
        public string ProfileImageUrl { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsMember { get; set; }

        public DateTime MemberSince { get; set; }


        public DateTime BirthDate { get; set; }

        public string Introduction { get; set; }


        public string WallPostTitle { get; set; }
        public DateTime Posted { get; set; }
        public string WallPostAuthor { get; set; }

        public string WallPostBodyContent { get; set; }

        public string CommentBodyContent { get; set; }

        public DateTime CommentPosted { get; set; }
        public string CommentAuthor { get; set; }
       // public string CommentAuthorId { get; set; }

     

    }
}