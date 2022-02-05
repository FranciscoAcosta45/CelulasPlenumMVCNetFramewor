
namespace CelulasPlenum1.Views
{
    partial class VistaAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txbBuscarAlumno = new System.Windows.Forms.TextBox();
            this.tablaAlumnos = new System.Windows.Forms.DataGridView();
            this.esBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(15)))));
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(0)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Location = new System.Drawing.Point(86, 68);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 37);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Agregar Alumno";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // txbBuscarAlumno
            // 
            this.txbBuscarAlumno.Location = new System.Drawing.Point(204, 85);
            this.txbBuscarAlumno.Name = "txbBuscarAlumno";
            this.txbBuscarAlumno.Size = new System.Drawing.Size(368, 20);
            this.txbBuscarAlumno.TabIndex = 2;
            // 
            // tablaAlumnos
            // 
            this.tablaAlumnos.AutoGenerateColumns = false;
            this.tablaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.carreraDataGridViewTextBoxColumn,
            this.idschoolDataGridViewTextBoxColumn,
            this.semestreDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.idestudentDataGridViewTextBoxColumn});
            this.tablaAlumnos.DataSource = this.esBindingSource;
            this.tablaAlumnos.Location = new System.Drawing.Point(86, 136);
            this.tablaAlumnos.Name = "tablaAlumnos";
            this.tablaAlumnos.Size = new System.Drawing.Size(612, 259);
            this.tablaAlumnos.TabIndex = 4;
            // 
            // esBindingSource
            // 
            this.esBindingSource.DataSource = typeof(CelulasPlenum1.Models.Alumno);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(196)))), ((int)(((byte)(28)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(50)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(587, 68);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 37);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(675, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 37);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // carreraDataGridViewTextBoxColumn
            // 
            this.carreraDataGridViewTextBoxColumn.DataPropertyName = "Carrera";
            this.carreraDataGridViewTextBoxColumn.HeaderText = "Carrera";
            this.carreraDataGridViewTextBoxColumn.Name = "carreraDataGridViewTextBoxColumn";
            // 
            // idschoolDataGridViewTextBoxColumn
            // 
            this.idschoolDataGridViewTextBoxColumn.DataPropertyName = "Id_school";
            this.idschoolDataGridViewTextBoxColumn.HeaderText = "Escuela";
            this.idschoolDataGridViewTextBoxColumn.Name = "idschoolDataGridViewTextBoxColumn";
            // 
            // semestreDataGridViewTextBoxColumn
            // 
            this.semestreDataGridViewTextBoxColumn.DataPropertyName = "Semestre";
            this.semestreDataGridViewTextBoxColumn.HeaderText = "Semestre";
            this.semestreDataGridViewTextBoxColumn.Name = "semestreDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // idestudentDataGridViewTextBoxColumn
            // 
            this.idestudentDataGridViewTextBoxColumn.DataPropertyName = "Id_estudent";
            this.idestudentDataGridViewTextBoxColumn.HeaderText = "Id_estudent";
            this.idestudentDataGridViewTextBoxColumn.Name = "idestudentDataGridViewTextBoxColumn";
            this.idestudentDataGridViewTextBoxColumn.Visible = false;
            // 
            // VistaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tablaAlumnos);
            this.Controls.Add(this.txbBuscarAlumno);
            this.Controls.Add(this.btnAddStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaAlumnos";
            this.Text = "VistaAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAddStudent;
        public System.Windows.Forms.TextBox txbBuscarAlumno;
        public System.Windows.Forms.DataGridView tablaAlumnos;
        private System.Windows.Forms.BindingSource esBindingSource;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestudentDataGridViewTextBoxColumn;
    }
}