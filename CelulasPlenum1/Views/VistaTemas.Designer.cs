
namespace CelulasPlenum1.Views
{
    partial class VistaTemas
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
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.txbBuscarTema = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(110)))), ((int)(((byte)(15)))));
            this.btnAddTopic.FlatAppearance.BorderSize = 0;
            this.btnAddTopic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(0)))));
            this.btnAddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTopic.Location = new System.Drawing.Point(86, 68);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(100, 37);
            this.btnAddTopic.TabIndex = 0;
            this.btnAddTopic.Text = "Agregar Tema";
            this.btnAddTopic.UseVisualStyleBackColor = false;
            // 
            // txbBuscarTema
            // 
            this.txbBuscarTema.Location = new System.Drawing.Point(204, 85);
            this.txbBuscarTema.Name = "txbBuscarTema";
            this.txbBuscarTema.Size = new System.Drawing.Size(368, 20);
            this.txbBuscarTema.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 259);
            this.dataGridView1.TabIndex = 3;
            // 
            // VistaTemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbBuscarTema);
            this.Controls.Add(this.btnAddTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaTemas";
            this.Text = "VistaTemas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAddTopic;
        public System.Windows.Forms.TextBox txbBuscarTema;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}