
namespace CelulasPlenum1.Views
{
    partial class Principal
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
            this.barra_principal = new System.Windows.Forms.Panel();
            this.botonCerrarApp = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTemas = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnEscuelas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.barra_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrarApp)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_principal
            // 
            this.barra_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(67)))));
            this.barra_principal.Controls.Add(this.botonCerrarApp);
            this.barra_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_principal.Location = new System.Drawing.Point(0, 0);
            this.barra_principal.Name = "barra_principal";
            this.barra_principal.Size = new System.Drawing.Size(968, 30);
            this.barra_principal.TabIndex = 0;
            this.barra_principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_principal_MouseDown);
            // 
            // botonCerrarApp
            // 
            this.botonCerrarApp.Image = global::CelulasPlenum1.Properties.Resources.circulo_rojo_png_4;
            this.botonCerrarApp.Location = new System.Drawing.Point(24, 3);
            this.botonCerrarApp.Name = "botonCerrarApp";
            this.botonCerrarApp.Size = new System.Drawing.Size(24, 25);
            this.botonCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonCerrarApp.TabIndex = 0;
            this.botonCerrarApp.TabStop = false;
            this.botonCerrarApp.Click += new System.EventHandler(this.botonCerrarApp_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(145)))), ((int)(((byte)(240)))));
            this.menu.Controls.Add(this.panel3);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.btnTemas);
            this.menu.Controls.Add(this.btnAlumnos);
            this.menu.Controls.Add(this.btnEscuelas);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 30);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(163, 492);
            this.menu.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(247)))));
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 55);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(247)))));
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 55);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(247)))));
            this.panel1.Location = new System.Drawing.Point(0, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnTemas
            // 
            this.btnTemas.FlatAppearance.BorderSize = 0;
            this.btnTemas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(247)))));
            this.btnTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemas.ForeColor = System.Drawing.Color.White;
            this.btnTemas.Location = new System.Drawing.Point(12, 233);
            this.btnTemas.Name = "btnTemas";
            this.btnTemas.Size = new System.Drawing.Size(151, 55);
            this.btnTemas.TabIndex = 3;
            this.btnTemas.Text = "Temas";
            this.btnTemas.UseVisualStyleBackColor = true;
            this.btnTemas.Click += new System.EventHandler(this.btnTemas_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(247)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.Location = new System.Drawing.Point(12, 172);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(151, 55);
            this.btnAlumnos.TabIndex = 2;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnEscuelas
            // 
            this.btnEscuelas.FlatAppearance.BorderSize = 0;
            this.btnEscuelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(12)))), ((int)(((byte)(247)))));
            this.btnEscuelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscuelas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscuelas.ForeColor = System.Drawing.Color.White;
            this.btnEscuelas.Location = new System.Drawing.Point(12, 111);
            this.btnEscuelas.Name = "btnEscuelas";
            this.btnEscuelas.Size = new System.Drawing.Size(151, 55);
            this.btnEscuelas.TabIndex = 1;
            this.btnEscuelas.Text = "Escuelas";
            this.btnEscuelas.UseVisualStyleBackColor = true;
            this.btnEscuelas.Click += new System.EventHandler(this.btnEscuelas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CelulasPlenum1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(163, 30);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(805, 492);
            this.panelContenedor.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 522);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.barra_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.barra_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrarApp)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barra_principal;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnTemas;
        public System.Windows.Forms.Button btnAlumnos;
        public System.Windows.Forms.Button btnEscuelas;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelContenedor;
        public System.Windows.Forms.PictureBox botonCerrarApp;
    }
}