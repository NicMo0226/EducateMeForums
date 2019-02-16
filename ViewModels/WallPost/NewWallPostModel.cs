using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducateMeForums.ViewModels.WallPost
{
    public class NewWallPostModel
    {
        public string WallPostTitle { get; set; }
        public string WallPostBodyContent { get; set; }

        public DateTime Posted { get; set; }
   
        public string AuthorName { get; set; }
        public string UserId { get; set; }
    }
}
