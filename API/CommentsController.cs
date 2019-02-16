using EducateMeForums.InterfaceForService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EducateMeForums.API
{

    public class CommentsController : Controller
    {
        private readonly IWallPostComment _wallpostService;
        private ILogger<CommentsController> _logger;
        public CommentsController(IWallPostComment wallpostService,
        ILogger<CommentsController> logger)
        {
            _wallpostService = wallpostService;
            _logger = logger;
        }
                   

    }
}
