using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Colegio
{
    public partial class Form1 : Form
    {
        //Banderas para saber cuantos alumnos
        //Y notas y registrado
        int cAlumno=0, cMateria=0;
        Alumno[] alumnos = new Alumno[3];
        Materia[] materias = new Materia[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            alumnos[cAlumno].Id = cAlumno + 1;
            alumnos[cAlumno].Nombre = txtNombre.Text;
            alumnos[cAlumno].Grado = txtGrado.Text;
            alumnos[cAlumno].Seccion = txtSeccion.Text;

            cAlumno++;
        }

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            materias[cMateria].Id = cMateria + 1;
            materias[cMateria].NombreMateria = txtMateria.Text;
            materias[cMateria].Nota = Convert.ToDouble(txtNota.Text);

            cMateria++;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            dgvMostrarNotas.Columns.Clear();

            dgvMostrarNotas.ColumnCount = 5;

            dgvMostrarNotas.Columns[0].Name = "Nombre Alumno";
            dgvMostrarNotas.Columns[1].Name = "Grado";
            dgvMostrarNotas.Columns[2].Name = "Seccion";
            dgvMostrarNotas.Columns[3].Name = "Materia";
            dgvMostrarNotas.Columns[4].Name = "Nota";

            for(int i=0; i<cAlumno; i++)
            {
                dgvMostrarNotas.Rows.Add();

                dgvMostrarNotas.Rows[i].Cells[0].Value = alumnos[i].Nombre;
                dgvMostrarNotas.Rows[i].Cells[1].Value = alumnos[i].Grado;
                dgvMostrarNotas.Rows[i].Cells[2].Value = alumnos[i].Seccion;
                dgvMostrarNotas.Rows[i].Cells[3].Value = materias[i].NombreMateria;
                dgvMostrarNotas.Rows[i].Cells[4].Value = materias[i].Nota;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i =0; i<3; i++)
            {
                alumnos[i] = new Alumno();
                materias[i] = new Materia();
            }
        }
    }
}
