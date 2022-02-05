using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelulasPlenum1.Models
{
    public class Student
    {
        private String nombre, carrera, correo;
        private int id, id_Eschool, semestre, celular;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setCarrera(String carrera)
        {
            this.carrera = carrera;
        }

        public String getCarrera()
        {
            return carrera;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        public String getCorreo()
        {
            return correo;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public void setId_Eschool(int id_Eschool)
        {
            this.id_Eschool = id_Eschool;
        }

        public int getId_Eschool()
        {
            return id_Eschool;
        }

        public void setSemestre(int semestre)
        {
            this.semestre = semestre;
        }

        public int getSemestre()
        {
            return semestre;
        }

        public void setCelular(int celular)
        {
            this.celular = celular;
        }

        public int getCelular()
        {
            return celular;
        }
    }
}
