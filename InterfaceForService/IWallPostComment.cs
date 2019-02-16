using System.Collections.Generic;
using System.Threading.Tasks;
using EducateMeForums.Models;

namespace EducateMeForums.InterfaceForService
{
    public interface IWallPostComment
    {
        bool WallPostExists(int userId);
        WallPost GetById(int id);
        IEnumerable<WallPost> GetAll();
 
        IEnumerable<Comment> GetCommentForWallPost(int wallpostId);
        Comment GetComment(int wallpostId, int commentId);
        Task Create(WallPost wallPost);
        
        Task AddComment(int wallpostId, Comment comment);
        void DeleteComment(Comment comment);
        IEnumerable<Comment> GetComments(int wallpostId);


        bool Save();
    }
}