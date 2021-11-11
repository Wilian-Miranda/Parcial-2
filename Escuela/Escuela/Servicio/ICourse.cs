using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface ICourse
    {
        //solo deben incluirse métodos a utilizar.Solo metodo y nada mas
        //Solo quienes implementen deben agregar la logica. En repositorio
        void Add(Tbl_Course _Student);
        void Update(Tbl_Course _Student);
        void Delete(int id);
        List<Tbl_Course> GetById(int id);
        ICollection<Tbl_Course> ShowCourses();
    }
}
