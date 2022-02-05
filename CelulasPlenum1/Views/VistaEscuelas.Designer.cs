
namespace CelulasPlenum1.Views
{
    partial class VistaEscuelas
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
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.txbBuscarEscuela = new System.Windows.Forms.TextBox();
            this.tablaEscuelas = new System.Windows.Forms.DataGridView();
            this.escuelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEscuelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(15)))));
            this.btnAddSchool.FlatAppearance.BorderSize = 0;
            this.btnAddSchool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(0)))));
            this.btnAddSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchool.Location = new System.Drawing.Point(86, 68);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(100, 37);
            this.btnAddSchool.TabIndex = 1;
            this.btnAddSchool.Text = "Agregar Escuela";
            this.btnAddSchool.UseVisualStyleBackColor = false;
            // 
            // txbBuscarEscuela
            // 
            this.txbBuscarEscuela.Location = new System.Drawing.Point(204, 85);
            this.txbBuscarEscuela.Name = "txbBuscarEscuela";
            this.txbBuscarEscuela.Size = new System.Drawing.Size(368, 20);
            this.txbBuscarEscuela.TabIndex = 2;
            // 
            // tablaEscuelas
            // 
            this.tablaEscuelas.AutoGenerateColumns = false;
            this.tablaEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEscuelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.tablaEscuelas.DataSource = this.escuelaBindingSource;
            this.tablaEscuelas.Location = new System.Drawing.Point(86, 136);
            this.tablaEscuelas.Name = "tablaEscuelas";
            this.tablaEscuelas.Size = new System.Drawing.Size(612, 259);
            this.tablaEscuelas.TabIndex = 4;
            // 
            // escuelaBindingSource
            // 
            this.escuelaBindingSource.DataSource = typeof(CelulasPlenum1.Models.Escuela);
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
            this.btnEditar.TabIndex = 6;
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
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "Cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "Cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // VistaEscuelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 492);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tablaEscuelas);
            this.Controls.Add(this.txbBuscarEscuela);
            this.Controls.Add(this.btnAddSchool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaEscuelas";
            this.Text = "VistaEscuelas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEscuelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAddSchool;
        public System.Windows.Forms.TextBox txbBuscarEscuela;
        public System.Windows.Forms.DataGridView tablaEscuelas;
        private System.Windows.Forms.BindingSource escuelaBindingSource;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}