namespace Ejemplo_Colegio
{
    partial class Form1
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
            this.gpbRegistroAlumno = new System.Windows.Forms.GroupBox();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbRegistroNota = new System.Windows.Forms.GroupBox();
            this.btnRegistrarNota = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.dgvMostrarNotas = new System.Windows.Forms.DataGridView();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.gpbRegistroAlumno.SuspendLayout();
            this.gpbRegistroNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbRegistroAlumno
            // 
            this.gpbRegistroAlumno.Controls.Add(this.btnRegistrarAlumno);
            this.gpbRegistroAlumno.Controls.Add(this.txtSeccion);
            this.gpbRegistroAlumno.Controls.Add(this.txtGrado);
            this.gpbRegistroAlumno.Controls.Add(this.txtNombre);
            this.gpbRegistroAlumno.Controls.Add(this.lblSeccion);
            this.gpbRegistroAlumno.Controls.Add(this.lblGrado);
            this.gpbRegistroAlumno.Controls.Add(this.lblNombre);
            this.gpbRegistroAlumno.Location = new System.Drawing.Point(48, 13);
            this.gpbRegistroAlumno.Name = "gpbRegistroAlumno";
            this.gpbRegistroAlumno.Size = new System.Drawing.Size(675, 134);
            this.gpbRegistroAlumno.TabIndex = 0;
            this.gpbRegistroAlumno.TabStop = false;
            this.gpbRegistroAlumno.Text = "Registro de Alumnos";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(488, 85);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(149, 29);
            this.btnRegistrarAlumno.TabIndex = 6;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(488, 43);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(149, 22);
            this.txtSeccion.TabIndex = 5;
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(254, 42);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(158, 22);
            this.txtGrado.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Location = new System.Drawing.Point(485, 22);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(58, 17);
            this.lblSeccion.TabIndex = 2;
            this.lblSeccion.Text = "Seccion";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(251, 22);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(48, 17);
            this.lblGrado.TabIndex = 1;
            this.lblGrado.Text = "Grado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gpbRegistroNota
            // 
            this.gpbRegistroNota.Controls.Add(this.btnRegistrarNota);
            this.gpbRegistroNota.Controls.Add(this.txtNota);
            this.gpbRegistroNota.Controls.Add(this.txtMateria);
            this.gpbRegistroNota.Controls.Add(this.lblNota);
            this.gpbRegistroNota.Controls.Add(this.lblMateria);
            this.gpbRegistroNota.Location = new System.Drawing.Point(48, 153);
            this.gpbRegistroNota.Name = "gpbRegistroNota";
            this.gpbRegistroNota.Size = new System.Drawing.Size(675, 118);
            this.gpbRegistroNota.TabIndex = 1;
            this.gpbRegistroNota.TabStop = false;
            this.gpbRegistroNota.Text = "Registro de nota";
            // 
            // btnRegistrarNota
            // 
            this.btnRegistrarNota.Location = new System.Drawing.Point(488, 80);
            this.btnRegistrarNota.Name = "btnRegistrarNota";
            this.btnRegistrarNota.Size = new System.Drawing.Size(149, 23);
            this.btnRegistrarNota.TabIndex = 4;
            this.btnRegistrarNota.Text = "Registrar Nota";
            this.btnRegistrarNota.UseVisualStyleBackColor = true;
            this.btnRegistrarNota.Click += new System.EventHandler(this.btnRegistrarNota_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(254, 43);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(158, 22);
            this.txtNota.TabIndex = 3;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(20, 43);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(146, 22);
            this.txtMateria.TabIndex = 2;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(251, 22);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(38, 17);
            this.lblNota.TabIndex = 1;
            this.lblNota.Text = "Nota";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(20, 22);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 17);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Materia";
            // 
            // dgvMostrarNotas
            // 
            this.dgvMostrarNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarNotas.Location = new System.Drawing.Point(48, 287);
            this.dgvMostrarNotas.Name = "dgvMostrarNotas";
            this.dgvMostrarNotas.RowTemplate.Height = 24;
            this.dgvMostrarNotas.Size = new System.Drawing.Size(675, 170);
            this.dgvMostrarNotas.TabIndex = 2;
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(536, 472);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(149, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.dgvMostrarNotas);
            this.Controls.Add(this.gpbRegistroNota);
            this.Controls.Add(this.gpbRegistroAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbRegistroAlumno.ResumeLayout(false);
            this.gpbRegistroAlumno.PerformLayout();
            this.gpbRegistroNota.ResumeLayout(false);
            this.gpbRegistroNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbRegistroAlumno;
        private System.Windows.Forms.GroupBox gpbRegistroNota;
        private System.Windows.Forms.DataGridView dgvMostrarNotas;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrarNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnMostrarDatos;
    }
}

