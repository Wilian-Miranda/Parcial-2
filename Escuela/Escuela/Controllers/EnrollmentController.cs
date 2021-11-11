using Escuela.Dominio;
using Escuela.Models.ViewModels;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Web.Mvc.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly ILogger<EnrollmentController> logger;
        private IEnrollement iEnrollement;
        private ICourse iCourse;
        private IStudent iStudent;

        public EnrollmentController(ILogger<EnrollmentController> _logger, IEnrollement _iEnrollement, ICourse _iCourse, IStudent _iStudent)
        {
            logger = _logger;
            iEnrollement = _iEnrollement;
            iCourse = _iCourse;
            iStudent = _iStudent;
        }
        public IActionResult Details()
        {
            var ListEnrollement = iEnrollement.ShowEnrollment();
            return View(ListEnrollement);
        }

        public IActionResult ControlEnrollment(String interruptor,  int id)
        {
            //====================================================
            var listStudent = iStudent.ShowStudents();
            List<SelectListItem> listStudentCombo = new List<SelectListItem>();
            foreach (var i in listStudent)
            {
                listStudentCombo.Add(
                    new SelectListItem
                    {
                        Text = i.firstMidName +", "+ i.lastName,
                        Value = i.studendId.ToString()

                    }
                );
                _ = listStudentCombo;
                ViewBag.Students = listStudentCombo;
            }
            //===================================================
            var listCourse = iCourse.ShowCourses();
            List<SelectListItem> llistCourseCombo = new List<SelectListItem>();
            foreach (var i in listCourse)
            {
                llistCourseCombo.Add(
                    new SelectListItem
                    {
                        Text = i.title,
                        Value = i.courseId.ToString()

                    }
                );
                ViewBag.Courses = llistCourseCombo;
            }
            //=====================================================

            var listaGrades_2 = Enum.GetValues(typeof(Dominio.grades)).Cast<Dominio.grades>().ToList().Select(x=> new SelectListItem { 
                Text = x.ToString(),
                Value = ((int)x).ToString()
            
            });
                ViewBag.Grades = listaGrades_2;
            
            //=====================================
            int _interruptor = Convert.ToInt32(interruptor);
            Tbl_EnrollmentViewModel _EnrollmentViewModel = new Tbl_EnrollmentViewModel();

            if (_interruptor == 0)
            {
                ViewBag.id = 0;
                return View();
            }
            else if(_interruptor == 1)
            {
                    var rowById = iEnrollement.GetById(id);
                    foreach (var i in rowById)
                    {
                        _EnrollmentViewModel.enrollmentId = i.enrollmentId;
                        _EnrollmentViewModel.studentId = i.studentId;
                        _EnrollmentViewModel.courseId = i.courseId;
                        _EnrollmentViewModel.grade = i.grade;
                    }
                    return View("ControlEnrollment", _EnrollmentViewModel);

            }
            else
            {
                var rowById = iStudent.GetById(id);
                foreach (var i in rowById)
                {
                    _EnrollmentViewModel.enrollmentId = 0;
                    _EnrollmentViewModel.studentId = i.studendId;
                    _EnrollmentViewModel.courseId = 0;
                    _EnrollmentViewModel.grade = 0;
                }
                return View("ControlEnrollment", _EnrollmentViewModel);
            }
        }
        [HttpPost]
        public IActionResult ControlEnrollment(Tbl_EnrollmentViewModel _model)
        {
            Tbl_Enrollment enrollment = new Tbl_Enrollment();
            enrollment.enrollmentId = _model.enrollmentId;
            enrollment.studentId = _model.studentId;
            enrollment.courseId = _model.courseId;
            enrollment.grade = _model.grade;

            if (ModelState.IsValid)
            {
                if (_model.enrollmentId == 0)
                {
                    iEnrollement.Add(enrollment);
                    return Redirect("/Enrollment/Details");
                }
                else
                {
                    iEnrollement.Update(enrollment);
                    return Redirect("/Enrollment/Details");
                }
            }
            else
            {
                ViewBag.id = 0;
                //====================================================
                var listStudent = iStudent.ShowStudents();
                List<SelectListItem> listStudentCombo = new List<SelectListItem>();
                foreach (var i in listStudent)
                {
                    listStudentCombo.Add(
                        new SelectListItem
                        {
                            Text = i.firstMidName + ", " + i.lastName,
                            Value = i.studendId.ToString()

                        }
                    );
                    _ = listStudentCombo;
                    ViewBag.Students = listStudentCombo;
                }
                //===================================================
                var listCourse = iCourse.ShowCourses();
                List<SelectListItem> llistCourseCombo = new List<SelectListItem>();
                foreach (var i in listCourse)
                {
                    llistCourseCombo.Add(
                        new SelectListItem
                        {
                            Text = i.title,
                            Value = i.courseId.ToString()

                        }
                    );
                    ViewBag.Courses = llistCourseCombo;
                }
                //=====================================================

                var listaGrades_2 = Enum.GetValues(typeof(Dominio.grades)).Cast<Dominio.grades>().ToList().Select(x => new SelectListItem
                {
                    Text = x.ToString(),
                    Value = ((int)x).ToString()

                });
                ViewBag.Grades = listaGrades_2;

                //=====================================
                return View("ControlEnrollment", _model);
            }

        }

        public IActionResult DeleteEnrollment(int id)
        {
            iEnrollement.Delete(id);
            return Redirect("/Enrollment/Details");
        }
    }
}
