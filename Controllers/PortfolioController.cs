using System.Threading.Tasks;
using EducateMeForums.InterfaceForService;
using EducateMeForums.Models;
using EducateMeForums.ViewModels.Portfolio;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EducateMeForums.Contollers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolio _portfolioService;
      

        private static UserManager<ApplicationUser> _userManager;
        public PortfolioController(IPortfolio portfolioService, UserManager<ApplicationUser> userManager)
        {
            _portfolioService = portfolioService;
               _userManager = userManager;
        }

        public IActionResult Index(int id)
        {
            var portfolio = _portfolioService.GetById(id);
          
            var model = new PortfolioIndexModel
            {
                Id = portfolio.Id,
                Subject = portfolio.Subject,
                AcademicInstitution = portfolio.AcademicInstitution,
                AchievedWhen = portfolio.AchievedWhen,
                HighestAchievement = portfolio.HighestAchievement,
                Website = portfolio.Website      
            };
            return View(model);
        }

        public async Task<IActionResult> Create(int id)        {            var user = await _userManager.FindByNameAsync(User.Identity.Name);            var model = new NewPortfolioModel            {                UserId = user.Id,            };            return View(model);        }       [HttpPost]        public async Task<IActionResult> AddPortfolio(NewPortfolioModel model)        {            var userId = _userManager.GetUserId(User);
            var user = _userManager.FindByIdAsync(userId).Result;
            var portfolio = BuildPortfolio(model, user);            await _portfolioService.Create(portfolio);

            return RedirectToAction("Create", "WallPost", new { id = portfolio.Id });        }        private Portfolio BuildPortfolio(NewPortfolioModel model, ApplicationUser user)        {            return new Portfolio           {               Subject = model.Subject,                HighestAchievement = model.HighestAchievement,                AchievedWhen = model.AchievedWhen,                AcademicInstitution = model.AcademicInstitution,               Website = model.Website,                User = user            };        }        private bool IsAuthorAdmin(ApplicationUser user)        {            return _userManager.GetRolesAsync(user)            .Result.Contains("Admin");
        }   }
}