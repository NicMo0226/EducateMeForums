using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducateMeForums.Data;
using EducateMeForums.Models;
using EducateMeForums.InterfaceForService;
using Microsoft.EntityFrameworkCore;

namespace EducateMeForums.Services
{
    public class WallPostService : IWallPostComment
    {
        private readonly ApplicationDbContext _context;
        public WallPostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<WallPost> GetAll()
        {
            return _context.WallPosts
                      .Include(w => w.User);
        }

        public WallPost GetById(int id)
        {
            return _context.WallPosts.Where(w => w.Id == id)
                 .Include(w => w.User)
                       .First();
        }

        
        public Comment GetComment(int wallpostId, int commentId)
        {
            return _context.Comments.Where(p => p.Id == commentId && p.Id == commentId)
            .Include(c => c.CommentBodyContent)
            .Include(c => c.CommentPosted)
            .Include(c => c.CommentAuthor)
               .FirstOrDefault();
        }


        public async Task Create(WallPost wallPost)
        {
            _context.Add(wallPost);
            await _context.SaveChangesAsync();
        }


        public IEnumerable<Comment> GetCommentForWallPost(int wallpostId)
        {
            return _context.Comments
                           .Where(p => p.Id == wallpostId).ToList();
        }
        public bool WallPostExists(int wallpostId)
        {
            return _context.WallPosts.Any(u => u.Id == wallpostId);
        }
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
        public void DeleteComment(Comment comment)
        {
            _context.Comments.Remove(comment);
        }

        public async Task AddComment(int WallPost, Comment comment)
        {
            _context.Add(comment);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Comment> GetComments(int id)
        {
            return _context.Comments.Where(c => c.Id == id)
            .Include(c => c.CommentBodyContent)
            .Include(c => c.CommentPosted)
            .Include(c => c.CommentAuthor);
        }
    }

}