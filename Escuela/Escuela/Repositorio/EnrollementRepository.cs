using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class EnrollementRepository : IEnrollement
    {
        private ApplicationDBContext dBContext;

        public EnrollementRepository(ApplicationDBContext _dBContext)
        {
            this.dBContext = _dBContext;
        }

        public void Add(Tbl_Enrollment _Enrollment)
        {
            dBContext.Add(_Enrollment);
            dBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var rowToErase = dBContext.Tbl_Enrollment.Where(x => x.enrollmentId == id).FirstOrDefault();
            dBContext.Tbl_Enrollment.Remove(rowToErase);
            dBContext.SaveChanges();
        }

        public List<Tbl_Enrollment> GetById(int id)
        {
            return dBContext.Tbl_Enrollment.Where(x => x.enrollmentId == id).ToList();

        }

        public List<Tbl_Enrollment> ShowEnrollment()
        {
            return dBContext.Tbl_Enrollment.Include(x=>x.Student).Include(x=>x.Course).ToList();
        }

        public void Update(Tbl_Enrollment _Enrollment)
        {
            dBContext.Tbl_Enrollment.Update(_Enrollment);
            dBContext.SaveChanges();
        }

    }
}
