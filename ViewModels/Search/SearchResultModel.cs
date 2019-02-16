using System.Collections.Generic;
using EducateMeForums.ViewModels.Post;

namespace EducateMeForums.ViewModels.Search
{
    public class SearchResultModel
    {
        public IEnumerable<PostListingModel> Posts { get; set; }
        public string SearchQuery { get; set; }
        public bool EmptySearchResults { get; set; }
    }
}