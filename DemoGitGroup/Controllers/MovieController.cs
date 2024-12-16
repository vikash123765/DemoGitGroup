using Microsoft.AspNetCore.Mvc;

namespace DemoGitGroup.Controllers
{
    public class MovieController : Controller
    {

        public IActionResult Index(int id,int y)

        {
            Console.WriteLine("Hello");
            Console.WriteLine("Testi, working now?");

            return View();
           
        }
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
