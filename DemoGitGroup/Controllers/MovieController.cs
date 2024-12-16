using Microsoft.AspNetCore.Mvc;

namespace DemoGitGroup.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
