using Microsoft.AspNetCore.Mvc;

namespace DemoGitGroup.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(int id)
        {
            Console.WriteLine("Hello");
            return View();
            Console.WriteLine("vikash implemnation");
        }
    }
}
