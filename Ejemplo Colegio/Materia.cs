using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    class Materia
    {
        //Propiedades de materia
        public int Id { set; get; }
        public string NombreMateria { set; get; }
        public double Nota { set; get; }

        //Constructor de materia
        public Materia()
        {
            this.Id = 0;
            this.NombreMateria = "";
            this.Nota = 0;
        }
    }
}
