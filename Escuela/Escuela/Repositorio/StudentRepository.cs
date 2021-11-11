using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class StudentRepository : IStudent
    {
        private ApplicationDBContext dBContext;

        public StudentRepository(ApplicationDBContext _dBContext)
        {
            this.dBContext = _dBContext;
        }

        public void Add(Tbl_Student _Student)
        {
            dBContext.Add(_Student);
            dBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var rowToErase = dBContext.Tbl_Student.Where(x => x.studendId == id).FirstOrDefault();
            dBContext.Tbl_Student.Remove(rowToErase);
            dBContext.SaveChanges();
        }

        public List<Tbl_Student> GetById(int id)
        {
            return  dBContext.Tbl_Student.Where(x => x.studendId == id).ToList();

        }

        public List<Tbl_Student> ShowStudents()
        {
            return dBContext.Tbl_Student.ToList();
        }

        public void Update(Tbl_Student _Student)
        {
            dBContext.Tbl_Student.Update(_Student);
            dBContext.SaveChanges();
        }
    }
}
