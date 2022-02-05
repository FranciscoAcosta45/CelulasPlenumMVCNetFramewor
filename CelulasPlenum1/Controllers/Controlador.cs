using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelulasPlenum1.Controllers;
using CelulasPlenum1.Models;
using CelulasPlenum1.Views;
using MySql.Data.MySqlClient;

namespace CelulasPlenum1.Controllers
{
    class Controlador
    {
        Principal vistaPrincipal;
        VistaTemas vistaTemas;
        VistaEscuelas vE;
        VistaAlumnos vA;
        ModalAgregarEscuelas modalAddEscuelas;
        ModalAgregarAlumno modalAddAlumno;
        ModalEditarAlumno modalEditarAlumno;
        ModalEditarEscuela modalEditarEscuela;
        Escuela escuela;
        Alumno est;

        public Controlador(Principal view, VistaTemas vTemas, ModalAgregarEscuelas modalAddEscuelas, VistaEscuelas vE, VistaAlumnos vA, ModalAgregarAlumno modalAddAlumno, Escuela escuela, Alumno est, ModalEditarAlumno modalEditarAlumno, ModalEditarEscuela modalEditarEscuela)
        {
            vistaPrincipal = view;
            vistaTemas = vTemas;
            this.modalAddEscuelas = modalAddEscuelas;
            this.vE = vE;
            this.vA = vA;
            this.modalAddAlumno = modalAddAlumno;
            this.escuela = escuela;
            this.est = est;
            this.modalEditarAlumno = modalEditarAlumno;
            this.modalEditarEscuela = modalEditarEscuela;
            vE.btnAddSchool.Click += new EventHandler(abrirModalAgregarEscuela);
            vA.btnAddStudent.Click += new EventHandler(abrirModalAgregarAlumnos);
            this.modalAddEscuelas.btnAceptar.Click += new EventHandler(obtnerDatosModalAddEscuela);
            this.modalAddAlumno.btnAceptar.Click += new EventHandler(obtnerDatosModalAddEstudiantes);
            vistaPrincipal.btnAlumnos.Click += new EventHandler(obtenerDatosTablaAlumnos);
            vistaPrincipal.btnEscuelas.Click += new EventHandler(obtenerDatosTablaEscuelas);
            vA.btnEliminar.Click += new EventHandler(eliminarAlumno);
            vA.btnEditar.Click += new EventHandler(obtenerDatosAlumnoAcualizar);
            vE.btnEditar.Click += new EventHandler(obtenerDatosEscuelaActualizar);
            vE.btnEliminar.Click += new EventHandler(eliminarEscuela);
            this.modalEditarAlumno.btnAceptar.Click += new EventHandler(actualizarAlumno);
            this.modalEditarEscuela.btnAceptar.Click += new EventHandler(actualizarEscuela);
        }


        private void abrirModalAgregarEscuela(object sender, EventArgs e)
        {
            modalAddEscuelas.Show(); 
        }

        private void abrirModalAgregarAlumnos(object sender, EventArgs e)
        {
            modalAddAlumno.Show();
        }

        private void obtnerDatosModalAddEscuela(object sender, EventArgs e)
        {
            escuela.Nombre = modalAddEscuelas.txtNombre.Text;
            escuela.Estado = modalAddEscuelas.txtEstado.Text;
            escuela.Ciudad = modalAddEscuelas.txtCiudad.Text;
            escuela.Cp = (int.Parse(modalAddEscuelas.txtCp.Text));
            escuela.Telefono = (int.Parse(modalAddEscuelas.txtTelefono.Text));

            String query = "insert into celulas.school (nombre, ciudad, estado, telefono, cp) " +
                "values(@nombre,@ciudad, @estado, @telefono, @cp)";
            SqlConnection conexionSQLServer = ConexionSQLServer.conexion();

            using (conexionSQLServer)
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, conexionSQLServer);
                    command.Parameters.AddWithValue("@nombre", escuela.Nombre);
                    command.Parameters.AddWithValue("@ciudad", escuela.Ciudad);
                    command.Parameters.AddWithValue("@estado", escuela.Estado);
                    command.Parameters.AddWithValue("@telefono", escuela.Telefono);
                    command.Parameters.AddWithValue("@cp", escuela.Cp);

                    conexionSQLServer.Open();
                    command.ExecuteNonQuery();
                    limpiarModalAgregarEscuelas();
                    modalAddEscuelas.Close();
                    MessageBox.Show("Escuela Agregada");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al agregar la escuela "+ ex);
                }
                finally
                {
                    conexionSQLServer.Close();
                }

            }
        }

        private void obtnerDatosModalAddEstudiantes(object sender, EventArgs e)
        {

            est.Nombre = modalAddAlumno.txtNombre.Text;
            est.Id_school = 1;
            est.Carrera = modalAddAlumno.txtCarrera.Text;
            est.Correo = modalAddAlumno.txtCorreo.Text;
            est.Semestre = int.Parse(modalAddAlumno.txtSemestre.Text);
            est.Celular = int.Parse(modalAddAlumno.txtCelular.Text);

            String query = "INSERT INTO celulas.student (nombre,id_school,carrera,correo,semestre,celular) " +
                "values(@nombre, @id_school, @carrera, @correo, @semestre, @celular)";
            SqlConnection conexionSQLServer = ConexionSQLServer.conexion();
            using (conexionSQLServer)
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, conexionSQLServer);
                    command.Parameters.AddWithValue("@nombre", est.Nombre);
                    command.Parameters.AddWithValue("@id_school",est.Id_school);
                    command.Parameters.AddWithValue("@carrera", est.Carrera);
                    command.Parameters.AddWithValue("@correo", est.Correo);
                    command.Parameters.AddWithValue("@semestre",est.Semestre);
                    command.Parameters.AddWithValue("@celular", est.Celular);

                    conexionSQLServer.Open();
                    command.ExecuteNonQuery();
                    limpiarModalAgregarAlumno();
                    modalAddAlumno.Close();
                    MessageBox.Show("Alumno Agregado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar al alumno "+ ex);
                }
                finally
                {
                    conexionSQLServer.Close();
                }
            }

            

        }

        private void obtenerDatosTablaEscuelas(object sender, EventArgs e)
        {
            string query = "SELECT id, nombre, ciudad, estado, telefono, cp FROM celulas.school";

            SqlConnection conexionSQLServer = ConexionSQLServer.conexion();
            List<Object> lista = new List<Object>();

            using (conexionSQLServer)
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, conexionSQLServer);

                    conexionSQLServer.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Escuela es = new Escuela();
                        es.Id = reader.GetInt32(0);
                        es.Nombre = reader.GetString(1);
                        es.Ciudad = reader.GetString(2);
                        es.Estado = reader.GetString(3);
                        es.Telefono = reader.GetInt32(4);
                        es.Cp = reader.GetInt32(5);
                        Console.WriteLine(es.Nombre);
                        lista.Add(es);
                    }
                    conexionSQLServer.Close();
                    vE.tablaEscuelas.DataSource = lista;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void obtenerDatosTablaAlumnos(object sender, EventArgs e)
        {
            string query = "SELECT id_student, nombre, id_school, carrera, correo, semestre, celular FROM celulas.student";

            SqlConnection conexionSQLServer = ConexionSQLServer.conexion();
            List<Object> lista = new List<Object>();

            using (conexionSQLServer)
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, conexionSQLServer);

                    conexionSQLServer.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Alumno al = new Alumno();
                        al.Id_estudent = reader.GetInt32(0);
                        al.Nombre = reader.GetString(1);
                        al.Id_school = reader.GetInt32(2);
                        al.Carrera = reader.GetString(3);
                        al.Correo = reader.GetString(4);
                        al.Semestre = reader.GetInt32(5);
                        al.Celular = reader.GetInt32(6);
                        lista.Add(al);
                    }
                    conexionSQLServer.Close();
                    vA.MostrarDatoTabla(lista);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }            
        }

        private void eliminarAlumno(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el alumno?", "salir",
                MessageBoxButtons.YesNoCancel);
            String query = "delete from celulas.student where id_student=@id";
            SqlConnection conexionSQLServer = ConexionSQLServer.conexion();
            if (resultado == DialogResult.Yes)
            {
                int id = Int32.Parse(vA.tablaAlumnos.CurrentRow.Cells[3].Value.ToString());
                try
                {
                    using (conexionSQLServer)
                    {
                        SqlCommand command = new SqlCommand(query, conexionSQLServer);
                        command.Parameters.AddWithValue("@id", id);
                        conexionSQLServer.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Alumno Eliminado");
                        conexionSQLServer.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al elimanr el alumno " + ex);
                }
            }
        }

        private void eliminarEscuela(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar la escuela?", "salir",
                MessageBoxButtons.YesNoCancel);
            String query = "delete from celulas.school where id=@id";
            SqlConnection conexionSQLServer = ConexionSQLServer.conexion();
            if (resultado == DialogResult.Yes)
            {
                int id = Int32.Parse(vE.tablaEscuelas.CurrentRow.Cells[5].Value.ToString());
                try
                {
                    using (conexionSQLServer)
                    {
                        SqlCommand command = new SqlCommand(query, conexionSQLServer);
                        command.Parameters.AddWithValue("@id", id);
                        conexionSQLServer.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Escuela eliminada");
                        conexionSQLServer.Close();

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al elimanr la escuela "+ex);
                }
            }
        }

        private void obtenerDatosAlumnoAcualizar(object sender, EventArgs e)
        {
            est.Nombre = vA.tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
            est.Carrera = vA.tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
            est.Semestre = Int32.Parse(vA.tablaAlumnos.CurrentRow.Cells[3].Value.ToString());
            est.Correo = vA.tablaAlumnos.CurrentRow.Cells[4].Value.ToString();
            est.Celular = Int32.Parse(vA.tablaAlumnos.CurrentRow.Cells[5].Value.ToString());
            est.Id_estudent = Int32.Parse(vA.tablaAlumnos.CurrentRow.Cells[6].Value.ToString());

            modalEditarAlumno.Show();

            modalEditarAlumno.txtNombre.Text = est.Nombre;
            modalEditarAlumno.txtCarrera.Text = est.Carrera;
            modalEditarAlumno.txtSemestre.Text = est.Semestre.ToString();
            modalEditarAlumno.txtCorreo.Text = est.Correo;
            modalEditarAlumno.txtCelular.Text = est.Celular.ToString();
        }

        private void obtenerDatosEscuelaActualizar(object sender, EventArgs e)
        {
            escuela.Nombre = vE.tablaEscuelas.CurrentRow.Cells[0].Value.ToString();
            escuela.Ciudad = vE.tablaEscuelas.CurrentRow.Cells[1].Value.ToString();
            escuela.Estado = vE.tablaEscuelas.CurrentRow.Cells[2].Value.ToString();
            escuela.Telefono = Int32.Parse(vE.tablaEscuelas.CurrentRow.Cells[3].Value.ToString());
            escuela.Cp = Int32.Parse(vE.tablaEscuelas.CurrentRow.Cells[4].Value.ToString());
            escuela.Id = Int32.Parse(vE.tablaEscuelas.CurrentRow.Cells[5].Value.ToString());

            modalEditarEscuela.Show();

            modalEditarEscuela.txtNombre.Text = escuela.Nombre;
            modalEditarEscuela.txtCiudad.Text = escuela.Ciudad;
            modalEditarEscuela.txtEstado.Text = escuela.Estado;
            modalEditarEscuela.txtTelefono.Text = escuela.Telefono.ToString();
            modalEditarEscuela.txtCp.Text = escuela.Cp.ToString();
        }

        private void actualizarAlumno(object sender, EventArgs e)
        {
            String query = "UPDATE celulas.student SET nombre=@nombre,carrera=@carrera,correo=@correo,semestre=@semestre,celular=@celular where id_student=@id";
            SqlConnection conexionSQLServer = ConexionSQLServer.conexion();


            try
            {
                using (conexionSQLServer)
                {
                    SqlCommand command = new SqlCommand(query, conexionSQLServer);
                    command.Parameters.AddWithValue("@nombre", modalEditarAlumno.txtNombre.Text);
                    command.Parameters.AddWithValue("@carrera",modalEditarAlumno.txtCarrera.Text);
                    command.Parameters.AddWithValue("@correo", modalEditarAlumno.txtCorreo.Text);
                    command.Parameters.AddWithValue("@semestre", Int32.Parse(modalEditarAlumno.txtSemestre.Text));
                    command.Parameters.AddWithValue("@celular", Int32.Parse(modalEditarAlumno.txtCelular.Text));
                    command.Parameters.AddWithValue("@id", est.Id_estudent);
                    conexionSQLServer.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Alumno Actualizado");
                    modalEditarAlumno.Close();
                    conexionSQLServer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar al Alumno "+ex);
            }
        }

        private void actualizarEscuela(object sender, EventArgs e)
        {
            String query = "UPDATE celulas.school SET nombre=@nombre, ciudad=@ciudad, estado=@estado, cp=@cp where id=@id";
            SqlConnection conexionSQLServer = ConexionSQLServer.conexion();

            try
            {
                using (conexionSQLServer)
                {
                    SqlCommand command = new SqlCommand(query, conexionSQLServer);
                    command.Parameters.AddWithValue("@nombre", modalEditarEscuela.txtNombre.Text);
                    command.Parameters.AddWithValue("@ciudad", modalEditarEscuela.txtCiudad.Text);
                    command.Parameters.AddWithValue("@estado",modalEditarEscuela.txtEstado.Text);
                    command.Parameters.AddWithValue("cp", modalEditarEscuela.txtCp.Text);
                    command.Parameters.AddWithValue("@id", escuela.Id);
                    conexionSQLServer.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Escuela Actualizada");
                    modalEditarEscuela.Close();
                    conexionSQLServer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar al Alumno " + ex);
            }
        }

        private void limpiarModalAgregarAlumno()
        {
            modalAddAlumno.txtNombre.Text = "";
            modalAddAlumno.txtCarrera.Text = "";
            modalAddAlumno.txtSemestre.Text = "";
            modalAddAlumno.txtCorreo.Text = "";
            modalAddAlumno.txtCelular.Text = "";
        }
        
        private void limpiarModalAgregarEscuelas()
        {
            modalAddEscuelas.txtNombre.Text = "";
            modalAddEscuelas.txtEstado.Text = "";
            modalAddEscuelas.txtCiudad.Text = "";
            modalAddEscuelas.txtTelefono.Text = "";
            modalAddEscuelas.txtCp.Text = "";
        }

    }
}
