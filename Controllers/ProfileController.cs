using System.Net.Http.Headers;
using System.Threading.Tasks;
using EducateMeForums.Models;
using EducateMeForums.ViewModels.ApplicationUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using EducateMeForums.InterfaceForService;
using System;

namespace EducateMeForums.Contollers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IUpload _uploadService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IWallPostComment _wallpostService;
      private readonly IConfiguration _configuration;

        public ProfileController(
            IDemographic demographicService,
        UserManager<ApplicationUser> userManager,
        IApplicationUser userService,
         SignInManager<ApplicationUser> signInManager,
        IUpload uploadService,
        IConfiguration configuration,
           IWallPostComment wallpostService)
        {
            _userManager = userManager;
            _userService = userService;
            _uploadService = uploadService;
            _configuration = configuration;
            _signInManager = signInManager;
            _wallpostService = wallpostService;
           
        }

        public IActionResult Detail(string id)
        {
            var user = _userService.GetById(id);
            var userRoles = _userManager.GetRolesAsync(user).Result;

            var model = new ProfileModel()
            {
                UserId = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserRating = user.UserRating.ToString(),
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
                MemberSince = user.MemberSince,
                BirthDate = user.BirthDate,
                Introduction = _userService.GetDemographics(id)?.Introduction,
                Town = _userService.GetDemographics(id)?.Town,
                Country = _userService.GetDemographics(id)?.Country,
                AchievedWhen = _userService.GetPortfolios(id).AchievedWhen,
                Subject = _userService.GetPortfolios(id)?.Subject,
                AcademicInstitution = _userService.GetPortfolios(id)?.AcademicInstitution,
                HighestAchievement = _userService.GetPortfolios(id)?.HighestAchievement,
                Website = _userService.GetPortfolios(id)?.Website,
                WallPostTitle = _userService.GetWallPosts(id)?.WallPostTitle,
                WallPostBodyContent = _userService.GetWallPosts(id)?.WallPostBodyContent,
                Posted = _userService.GetWallPosts(id).Posted
            };

            return View(model);
        }
       
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                       
                var user = new ApplicationUser
                {
                    UserName = register.Email,
                    Email = register.Email,
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    BirthDate = register.BirthDate,
                    MemberSince = DateTime.Now,
                   

                };
                
                var result = await _userManager.CreateAsync(user, register.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Create", "Demographic", new { id = user.Id });
                }
                else
                {
                    foreach (var error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }

            return View(register);
        }

            [HttpPost]
        public async Task<IActionResult> UploadProfileImage(IFormFile file)
        {
            var userId = _userManager.GetUserId(User);

            //Connect to Azure Storage ConTAINER

            var connectionString = _configuration.GetConnectionString("AzureStorageAccount");
            //Get blob container
            var container = _uploadService.GetBlobContainer(connectionString, "profile-images");

            //parse the content disposition response header 
            // Parse the Content Disposition response header
            var contentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);

            // Grab the filename
            var filename = contentDisposition.FileName.Trim('"');

            // Get a reference to a Block Blob
            var blockBlob = container.GetBlockBlobReference(filename);

            // on the block blob, upload our file <-- file upload to the cloud
            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());
            // set the Users profile image to the URI
            await _userService.SetProfileImage(userId, blockBlob.Uri);

            //Rediorect to the users profile page
            return RedirectToAction("Detail", "Profile", new { id = userId });

        }
    }
}