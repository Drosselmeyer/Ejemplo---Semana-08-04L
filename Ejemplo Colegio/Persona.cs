using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    abstract class Persona
    {
        //Propiedades
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string FechaNacimiento { set; get; }
        public string Documento { set; get; }

        //Constructor
        public Persona()
        {
            this.Id = 0;
            this.Nombre = "";
            this.FechaNacimiento = "";
            this.Documento = "";
        }

    }
}
