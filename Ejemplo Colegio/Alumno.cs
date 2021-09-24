using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    class Alumno : Persona
    {
        //Propiedades solo de alumno
        public string Responsable { set; get; }
        public string Grado { set; get; }
        public string Seccion { set; get; }

        //Contructor
        public Alumno()
        {
            this.Id = 0;
            this.Nombre = "";
            this.FechaNacimiento = "";
            this.Grado = "";
            this.Seccion = "";
            this.Responsable = "";
            this.Documento = "";
        }
    }
}
