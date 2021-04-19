using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanArc.Mvc.Pages
{
    public class Courses3Model : PageModel
    {
        private readonly ICourseService _courseService;
        public Courses3Model(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public void OnGet()
        {
        }
        //public IActionResult Index()
        //{
        //    CourseViewModel model = _courseService.GetCourses();


        //    return model;
        //}
    }
}
