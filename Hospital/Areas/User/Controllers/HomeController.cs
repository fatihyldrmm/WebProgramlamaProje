using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        [Area("User")]
        //[Authorize(Roles = "User")]
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
    }
}
