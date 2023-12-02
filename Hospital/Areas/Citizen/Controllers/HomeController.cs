using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Areas.Citizen.Controllers
{
    public class HomeController : Controller
    {
        [Area("User")]
        //[Authorize(Roles = "Citizen")]
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
    }
}
