using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAlumnos.Clases;

namespace WebApiAlumnos.Persistencia
{
    public class AlumnoContext :DbContext
    {

        public AlumnoContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Alumno> Alumnos { get; set; }
    }
}
