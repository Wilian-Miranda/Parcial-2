using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    //lista de datos constantes
    public enum grades {
        [DescriptionAttribute("A")]
        A = 1,
        [DescriptionAttribute("B")]
        B = 2,
        [DescriptionAttribute("C")]
        C = 3,
        [DescriptionAttribute("D")]
        D = 4}
    public class Tbl_Enrollment
    {
        //definiendo el campo como llave primaria
        [Key]
        //para dar identacion
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; }

        //Foranea del curso
        public int courseId { get; set; }
        public int studentId { get; set; }

        public grades? grade { get; set; }

        public Tbl_Course Course { get; set; }
        public Tbl_Student Student { get; set; }
    }
}
