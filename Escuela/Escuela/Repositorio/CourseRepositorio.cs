using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class CourseRepositorio : ICourse
    {
        private ApplicationDBContext dBContext;

        public CourseRepositorio(ApplicationDBContext _dBContext)
        {
            this.dBContext = _dBContext;
        }

        public void Add(Tbl_Course _Course)
        {
            dBContext.Add(_Course);
            dBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var rowToErase = dBContext.Tbl_Course.Where(x => x.courseId == id).FirstOrDefault();
            dBContext.Tbl_Course.Remove(rowToErase);
            dBContext.SaveChanges();
        }

        public List<Tbl_Course> GetById(int id)
        {
            return dBContext.Tbl_Course.Where(x => x.courseId == id).ToList();

        }

        public List<Tbl_Course> ShowStudents()
        {
            return dBContext.Tbl_Course.ToList();
        }

        public void Update(Tbl_Course _Course)
        {
            dBContext.Tbl_Course.Update(_Course);
            dBContext.SaveChanges();
        }

        public ICollection<Tbl_Course> ShowCourses()
        {
            return dBContext.Tbl_Course.ToList();
        }
    }
}
