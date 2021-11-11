using Escuela.Data;
using Escuela.Dominio;
using Escuela.Models.ViewModels;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class CourseController : Controller
    {
        private ILogger<CourseController> logger;
        private ICourse iCourse;
        public CourseController(ILogger<CourseController> _logger, ICourse _icourse)
        {
            logger = _logger;
            iCourse = _icourse;

        }
        public IActionResult Details()
        {
            var ListCourse = iCourse.ShowCourses();
            return View(ListCourse);
        }

        public IActionResult ControlCourse(String interruptor, int id)
        {
            int _interruptor = Convert.ToInt32(interruptor);
            Tbl_CourseViewModel _CourseViewModel = new Tbl_CourseViewModel();

            if (_interruptor == 0)
            {
                ViewBag.id = 0;
                return View();
            }
            else
            {
                var rowById = iCourse.GetById(id);
                foreach (var i in rowById)
                {
                    _CourseViewModel.courseId = i.courseId;
                    _CourseViewModel.title = i.title;
                    _CourseViewModel.credits = i.credits;
                }
                return View("ControlCourse", _CourseViewModel);
            }
        }
        [HttpPost]
        public IActionResult ControlCourse(Tbl_CourseViewModel _model)
        {
            Tbl_Course course = new Tbl_Course();
            course.courseId = _model.courseId;
            course.title = _model.title;
            course.credits = _model.credits;

            if (ModelState.IsValid)
            {
                if (_model.courseId == 0)
                {
                    iCourse.Add(course);
                    return Redirect("/Course/Details");
                }
                else
                {
                    iCourse.Update(course);
                    return Redirect("/Course/Details");
                }
            }
            else
            {
                return View("ControlCourse", _model);
            }

        }

        public IActionResult DeleteCourse(int id)
        {
            iCourse.Delete(id);
            return Redirect("/Course/Details");
        }
    }
}
