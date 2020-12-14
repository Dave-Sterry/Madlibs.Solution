using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/mad")]
        public ActionResult Mad()
        {

        }
        [Route("/form")]
        public ActionResult Form() { return View(); }
    }
}