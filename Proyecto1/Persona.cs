using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public Guid ID { get; set; }

        public Persona(string nombre, Guid id)
        {
            Nombre = nombre;
            this.ID = new Guid();
        }

        public abstract void RegistrarUsuario();
    }
}
