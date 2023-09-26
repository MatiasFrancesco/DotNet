using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult Index() {
            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetCourses();
            return View(courses);
        }
    public ActionResult Detail(string id) => /*Content($"I'm Detail, I have recieve the id = {id}")*/ View();
}
}
