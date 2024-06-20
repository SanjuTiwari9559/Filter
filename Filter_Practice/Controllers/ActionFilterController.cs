using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace Filter_Practice.Controllers
{

    public class ActionFilterController : Controller
    {
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Server, NoStore = false)]
        public IActionResult Index()
        {
            Response.Headers["Cache-Control"] = "public, max-age=60";
            return View();
        }
    }
}
