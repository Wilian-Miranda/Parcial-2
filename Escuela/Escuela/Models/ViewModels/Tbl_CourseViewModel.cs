using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models.ViewModels
{
    public class Tbl_CourseViewModel
    {
        [Display(Name ="ID:")]
        [Range(0, int.MaxValue)]
        public int courseId { get; set; }

        [Display(Name = "TITLE:")]
        [Required(ErrorMessage ="Este valor es obligatorio.")]
        public string title { get; set; }

        [Display(Name = "CREDITS:")]
        [Range(1,int.MaxValue, ErrorMessage ="Valor no válido.")]
        [Required(ErrorMessage = "Este valor es obligatorio.")]
        public int credits { get; set; }

        public Tbl_CourseViewModel(){}

        public Tbl_CourseViewModel(Tbl_Course course)
        {
            this.courseId = course.courseId;
            this.title = course.title;
            this.credits = course.credits;
        }
    }
}
