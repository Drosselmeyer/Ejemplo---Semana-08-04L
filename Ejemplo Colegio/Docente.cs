using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    class Docente : Persona
    {
        //Propiedades de docente
        public string GradoEnc { set; get; }
        public string SeccionEnc { set; get; }

        //Constructor
        public Docente()
        {
            this.Id = 0;
            this.Nombre = "";
            this.FechaNacimiento = "";
            this.GradoEnc = "";
            this.SeccionEnc = "";
            this.Documento = "";
        }
    }
}
