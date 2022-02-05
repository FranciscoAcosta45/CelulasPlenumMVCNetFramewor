using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelulasPlenum1.Models
{
    public class School
    {
        private String nombre, ciudad, estado;
        private int telefono, cp, id;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setCiudad(String ciudad)
        {
            this.ciudad = ciudad;
        }

        public String getCiudad()
        {
            return ciudad;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public int getTelefono()
        {
            return telefono;
        }

        public void setCodigoPostal(int cp)
        {
            this.cp = cp;
        }

        public int getCodigoPostal()
        {
            return cp;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }
    }
}
