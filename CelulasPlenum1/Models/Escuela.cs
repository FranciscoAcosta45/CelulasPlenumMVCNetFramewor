using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelulasPlenum1.Models
{
    public class Escuela
    {
        private String nombre;
        private String ciudad;
        private String estado;
        private int telefono;
        private int cp;
        private int id;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Cp { get => cp; set => cp = value; }
        public int Id { get => id; set => id = value; }
    }
}
