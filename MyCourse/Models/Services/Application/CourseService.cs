using System;
using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetCourses()
        {
            var courseList = new List<CourseViewModel>();
            var rand = new Random();
            for (int i = 0; i <20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel
                {
                    Id = i,
                    Title = $"Corso {i}",
                    CurrentPrice = price,
                    FullPrice = Convert.ToDecimal((rand.NextDouble() * 10 + 10) > 0.5 ? price : price - 1),
                    Author = "Nome Cognome",
                    Rating = rand.NextDouble() * 5.0,
                    ImagePath = "~/log.png"
                };
                courseList.Add(course);
            }

            return courseList;
        }

    }
}