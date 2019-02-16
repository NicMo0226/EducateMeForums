using System;

namespace EducateMeForums.ViewModels.Comment
{
    public class CreateComment
    {
        public DateTime CommentPosted { get; set; }
        public string CommentAuthor { get; set; }
     
        public string CommentBodyContent { get; set; }
    }
}