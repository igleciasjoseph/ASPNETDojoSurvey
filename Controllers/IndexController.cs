using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey
{
    public class IndexController : Controller {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }

        [HttpPost("method")]
        public IActionResult Result(string name, string location, string language, string comment) {
            @ViewBag.name = name;
            @ViewBag.location = location;
            @ViewBag.language = language;
            @ViewBag.comment = comment;
            return View();
        }

        // [HttpGet("result")]
        // public ViewResult Result() {
        //     return View();
        // }
    }
}