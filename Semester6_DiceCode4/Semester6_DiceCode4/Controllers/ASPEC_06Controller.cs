using Microsoft.AspNetCore.Mvc;

namespace Semester6_DiceCode4.Controllers
{
    public class ASPEC_06Controller : Controller
    {
        private const string ViewPath = "~/Views/Semester6_Views/ASPEC_06/Index.cshtml";

        public IActionResult Index()
        {
            return View(ViewPath);
        }


    }
}
