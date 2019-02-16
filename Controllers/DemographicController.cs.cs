﻿
using EducateMeForums.Models;

namespace EducateMeForums.Controllers
        public DemographicController(IDemographic demographicService, UserManager<ApplicationUser> userManager, IApplicationUser userService)
        public IActionResult Index(int id)
            var model = new DemographicIndexModel

        public async Task<IActionResult> Create(int id)
        {
            var model = new NewDemographicModel
            {
            };
        }
        [HttpPost]
        public async Task<IActionResult> AddDemographic(NewDemographicModel model)
            var user = _userManager.FindByIdAsync(userId).Result;
            var demographic = BuildDemographic(model, user);
            await _demographicService.Create(demographic);
            return RedirectToAction("Create", "Portfolio", new { id = demographic.Id });
        private Demographic BuildDemographic(NewDemographicModel model, ApplicationUser user)
            };