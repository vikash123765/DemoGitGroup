using Microsoft.AspNetCore.Mvc;

namespace DemoGitGroup.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Hello");
            return View();
        }
    }
}
