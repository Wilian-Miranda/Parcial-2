using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface IEnrollement
    {
        List<Tbl_Enrollment> ShowEnrollment();
        void Add(Tbl_Enrollment _Enrollment);
        void Update(Tbl_Enrollment _Enrollment);
        void Delete(int id);
        List<Tbl_Enrollment> GetById(int id);
    }
}
