using EducateMeForums.InterfaceForService;
using EducateMeForums.Models;
namespace EducateMeForums.Controllers
            var model = new ProfileModel
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            var user = _userManager.FindByIdAsync(userId).Result;
            var wallPost = BuildWallPost(model, user);
        private WallPost BuildWallPost(NewWallPostModel model, ApplicationUser user)
            };