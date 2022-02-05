using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelulasPlenum1.Controllers;
using CelulasPlenum1.Views;
using CelulasPlenum1.Models;
using System.Runtime.InteropServices;

namespace CelulasPlenum1.Views
{
    public partial class Principal : Form
    {
        VistaTemas v;
        VistaEscuelas vE;
        VistaAlumnos vA;
        ModalAgregarEscuelas modalAddEscuelas;
        ModalAgregarAlumno modalAddAlumno;
        Escuela escuela;
        Alumno est;
        ModalEditarAlumno modalEditarAlumno;
        ModalEditarEscuela modalEditarEscuela;

        public Principal()
        {
            InitializeComponent();

            v = new VistaTemas();
            vE = new VistaEscuelas();
            vA = new VistaAlumnos();
            modalAddEscuelas = new ModalAgregarEscuelas();
            modalAddAlumno = new ModalAgregarAlumno();
            escuela = new Escuela();
            est = new Alumno();
            modalEditarAlumno = new ModalEditarAlumno();
            modalEditarEscuela = new ModalEditarEscuela();
            Controlador ctrl = new Controlador(this, v, modalAddEscuelas, vE, vA, modalAddAlumno, escuela, est, modalEditarAlumno, modalEditarEscuela);
        }

        private void abrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            abrirFormHija(v);
        }

        private void btnEscuelas_Click(object sender, EventArgs e)
        {
            abrirFormHija(vE);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            abrirFormHija(vA);
        }

        private void botonCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwmd, int wMsg, int wParam, int lParam);

        private void barra_principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
