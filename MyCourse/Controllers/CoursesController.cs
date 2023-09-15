using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index() => /*Content("I'm Index")*/ View();
        public IActionResult Detail(string id) => /*Content($"I'm Detail, I have recieve the id = {id}")*/ View();
    }
}
