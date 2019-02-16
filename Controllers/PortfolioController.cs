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

        public async Task<IActionResult> Create(int id)
            var user = _userManager.FindByIdAsync(userId).Result;
            var portfolio = BuildPortfolio(model, user);

            return RedirectToAction("Create", "WallPost", new { id = portfolio.Id });
        }
}