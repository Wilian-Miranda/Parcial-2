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
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> logger;
        private IStudent iStudent;

        public StudentController(ILogger<StudentController> _logger, IStudent _student)
        {
            logger = _logger;
            iStudent = _student;
        }
        public IActionResult Details()
        {
            var ListStudent = iStudent.ShowStudents();
            _ = ListStudent;
            return View(ListStudent);
        }

        public IActionResult ControlStudent(String interruptor, int id)
        {
            int _interruptor = Convert.ToInt32(interruptor);
            Tbl_StudentViewModel _StudentViewModel = new Tbl_StudentViewModel();
            if (_interruptor == 0)
            {
                ViewBag.id = 0;
                return View();
            }
            else
            {
                var rowById = iStudent.GetById(id);
                foreach (var i in rowById)
                {
                    _StudentViewModel.studendId = i.studendId;
                    _StudentViewModel.lastName = i.lastName;
                    _StudentViewModel.firstMidName = i.firstMidName;
                    _StudentViewModel.enrollmentsDate = i.enrollmentsDate;
                }
                return View("ControlStudent", _StudentViewModel);
            }
        }

        [HttpPost]
        public IActionResult ControlStudent(Tbl_StudentViewModel _model)
        {
            Tbl_Student student = new Tbl_Student();
            student.studendId = _model.studendId;
            student.lastName = _model.lastName;
            student.firstMidName = _model.firstMidName;
            student.enrollmentsDate = _model.enrollmentsDate;

            if (ModelState.IsValid)
            {
                if (_model.studendId == 0)
                {
                    iStudent.Add(student);
                    return Redirect("/Student/Details");
                }
                else
                {
                    iStudent.Update(student);
                    return Redirect("/Student/Details");
                }
            }
            else
            {
                return View("ControlStudent",_model);
            }
            
        }

        public IActionResult DeleteStudent(int id)
        {
            iStudent.Delete(id);
            return Redirect("/Student/Details");
        }


    }
}
