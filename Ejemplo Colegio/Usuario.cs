using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Colegio
{
    class Usuario:Persona
    {
        //Propiedades de Usuario
        public string User { set; get; }
        public string Password { set; get; }

        //Constructor
        public Usuario() : base()
        {
            this.User = "";
            this.Password = "";
        }
    }
}
