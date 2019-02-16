using System.Collections.Generic;
using EducateMeForums.ViewModels.Post;

namespace EducateMeForums.ViewModels.Forum
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
        public string SearchQuery { get; set; }
    }
}