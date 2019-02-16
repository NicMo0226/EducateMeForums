
using EducateMeForums.Models;using Microsoft.AspNetCore.Identity;using Microsoft.AspNetCore.Mvc;using System.Threading.Tasks;using EducateMeForums.ViewModels.Demographic;using EducateMeForums.InterfaceForService;

namespace EducateMeForums.Controllers{    public class DemographicController : Controller    {        private readonly IDemographic _demographicService;        private readonly IApplicationUser _userService;        private static UserManager<ApplicationUser> _userManager;
        public DemographicController(IDemographic demographicService, UserManager<ApplicationUser> userManager, IApplicationUser userService)        {           _demographicService = demographicService;           _userManager = userManager;           _userService = userService;        }
        public IActionResult Index(int id)        {            var demographic = _demographicService.GetById(id);
            var model = new DemographicIndexModel            {               Id = demographic.Id,                Town = demographic.Town,               Country = demographic.Country,                Introduction = demographic.Introduction,            };            return View(model);        }

        public async Task<IActionResult> Create(int id)
        {            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var model = new NewDemographicModel
            {                UserId = user.Id,
            };            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddDemographic(NewDemographicModel model)        {            var userId = _userManager.GetUserId(User);
            var user = _userManager.FindByIdAsync(userId).Result;
            var demographic = BuildDemographic(model, user);
            await _demographicService.Create(demographic);
            return RedirectToAction("Create", "Portfolio", new { id = demographic.Id });        }
        private Demographic BuildDemographic(NewDemographicModel model, ApplicationUser user)        {           return new Demographic            {                Town = model.Town,                Country = model.Country,                Introduction = model.Introduction,                User = user
            };        }    }}