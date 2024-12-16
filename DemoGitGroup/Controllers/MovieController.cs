using Microsoft.AspNetCore.Mvc;

namespace DemoGitGroup.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(int id , string std)
        {
            Console.WriteLine("Hello");
            return View();
            Console.WriteLine("vikash implemnation");
        }
    }
}
