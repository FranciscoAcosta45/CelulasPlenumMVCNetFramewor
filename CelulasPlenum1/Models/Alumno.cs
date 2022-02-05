using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelulasPlenum1.Models
{
    class Alumno
    {
        private String nombre;
        private String correo;
        private String carrera;
        private int idEstudent;
        private int idSchool;
        private int semestre;
        private int celular;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public int Id_estudent { get => idEstudent; set => idEstudent = value; }
        public int Id_school { get => idSchool; set => idSchool = value; }
        public int Semestre { get => semestre; set => semestre = value; }
        public int Celular { get => celular; set => celular = value; }
    }


}
