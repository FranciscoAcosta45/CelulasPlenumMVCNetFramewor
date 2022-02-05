using CelulasPlenum1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelulasPlenum1.Views
{
    public partial class VistaAlumnos : Form
    {
        public VistaAlumnos()
        {
            InitializeComponent();
        }

        public void MostrarDatoTabla(List<Object> lista)
        {
            tablaAlumnos.DataSource = lista;
        }

    }
}
