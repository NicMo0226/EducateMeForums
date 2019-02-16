using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EducateMeForums.Models;

namespace EducateMeForums.InterfaceForService
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();
  
        Task SetProfileImage(string id, Uri uri);
        Task UpdateUserRating(string id, Type type);

                Demographic GetDemographics(string userId);
        Portfolio GetPortfolios(string userId);
        WallPost GetWallPosts(string userId);
    }
}