using System.Collections.Generic;
using EducateMeForums.ViewModels.Post;

namespace EducateMeForums.ViewModels.Home
{
    public class HomeIndexModel
    {
        public string SearchQuery {get; set;}
        public IEnumerable<PostListingModel> LatestPosts { get; set; }
    }
}