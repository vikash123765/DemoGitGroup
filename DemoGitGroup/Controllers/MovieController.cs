using Microsoft.AspNetCore.Mvc;

namespace DemoGitGroup.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(int id,int y)
        {
            Console.WriteLine("vikash implenentayi");
            return View();
           
        }
    }
}
