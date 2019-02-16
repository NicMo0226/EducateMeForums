using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducateMeForums.Data;
using EducateMeForums.InterfaceForService;
using EducateMeForums.Models;
using Microsoft.EntityFrameworkCore;

namespace EducateMeForums.Services
{

    public class ApplicationUserService : IApplicationUser
    {
        private readonly ApplicationDbContext _context;
        public ApplicationUserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return _context.ApplicationUsers
            .Include(u => u.PortfolioWithProfile)
            .Include(u => u.DemographicWithProfile)
            .Include(u => u.WallPostsWithProfile);
        }

        public ApplicationUser GetById(string id)
        {
            return _context.ApplicationUsers.Where(user => user.Id == id)
        .Include(u => u.PortfolioWithProfile)
            .Include(u => u.DemographicWithProfile)
            .Include(u => u.WallPostsWithProfile)
                       .FirstOrDefault();
        }
     
        public async Task UpdateUserRating(string userId, Type type)
        {
            var user = GetById(userId);
            user.UserRating = CalculateUserRating(type, user.UserRating);
            await _context.SaveChangesAsync();
        }

        private int CalculateUserRating(Type type, int userRating)
        {
            var inc = 0;

            if (type == typeof(Post))
                inc = 1;

            if (type == typeof(PostReply))
                inc = 3;

            return userRating + inc;
        }

        public async Task SetProfileImage(string id, Uri uri)
        {
            var user = GetById(id);
            user.ProfileImageUrl = uri.AbsoluteUri;
            _context.Update(user);
            await _context.SaveChangesAsync();
        }

        public Demographic GetDemographics(string userId)
        {
            return _context.ApplicationUsers.First(a => a.Id == userId).DemographicWithProfile;
        }

        public Portfolio GetPortfolios(string userId)
        {
            return _context.ApplicationUsers.First(a => a.Id == userId).PortfolioWithProfile;
        }

        public WallPost GetWallPosts(string userId)
        {
            return _context.ApplicationUsers.First(a => a.Id == userId).WallPostsWithProfile;
        }
    }
}