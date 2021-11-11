using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models.ViewModels
{
    public class Tbl_EnrollmentViewModel
    {
        [Display(Name ="ID:")]
        public int enrollmentId { get; set; }

        [Display(Name = "COURSE:")]
        [Required(ErrorMessage ="Este campo es requerido")]
        public int courseId { get; set; }

        [Display(Name = "STUDENT:")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int studentId { get; set; }

        [Display(Name = "GRADE:")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public grades? grade { get; set; }

        public Tbl_EnrollmentViewModel(Tbl_Enrollment _Enrollment)
        {
            this.enrollmentId = _Enrollment.enrollmentId;
            this.courseId = _Enrollment.courseId;
            this.studentId = _Enrollment.studentId;
            this.grade = _Enrollment.grade;
        }
        public Tbl_EnrollmentViewModel()
        {

        }
    }
}
