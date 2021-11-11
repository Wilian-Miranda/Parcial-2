using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Models.ViewModels
{
    public class Tbl_StudentViewModel
    {

        [Display(Name = "ID:")]
        [Range(0,int.MaxValue)]
        public int studendId { get; set; }

        [Display(Name = "LAST NAME:")]
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public string lastName { get; set; }

        [Display(Name = "FIRST MID NAME:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string firstMidName { get; set; }

        [Display(Name = "DATE:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime enrollmentsDate { get; set; }


        public Tbl_StudentViewModel(Tbl_Student _Student)
        {
            this.studendId = _Student.studendId;
            this.lastName = _Student.lastName;
            this.firstMidName = _Student.firstMidName;
            this.enrollmentsDate = _Student.enrollmentsDate;
        }
        public Tbl_StudentViewModel()
        {
        }

    }



}
