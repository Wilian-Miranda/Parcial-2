using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface IStudent
    {
        List<Tbl_Student> ShowStudents();
        void Add(Tbl_Student _Student);
        void Update(Tbl_Student _Student);
        void Delete(int id);
        List<Tbl_Student> GetById(int id);
    }
}
