using Microsoft.AspNetCore.Mvc;

namespace CarProject.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

            return View();
        }

    }
    
}