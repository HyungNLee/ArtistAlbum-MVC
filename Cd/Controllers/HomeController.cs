using Microsoft.AspNetCore.Mvc;
using Cd.Models;

namespace Cd.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
