using System.Collections.Generic;
using System.Threading.Tasks;
using EducateMeForums.Models;

namespace EducateMeForums.InterfaceForService
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
        IEnumerable<ApplicationUser> GetActiveUsers(int id);
       bool HasRecentPost(int id);

    }
}