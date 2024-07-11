using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Transacciones
    {
        private Guid id { get; set; }
        public Persona Persona { get; private set; }
        public Libros libros { get; private set; }
        public TimeOnly tiempoPrestamo { get; private set; }
        public bool devuelto { get; private set; }

        public Transacciones (Guid id, Persona persona, Libros libros, TimeOnly tiempoPrestamo, bool devuelto)
        {
            this.id = new Guid();
            Persona = persona;
            this.libros = libros;
            this.tiempoPrestamo = tiempoPrestamo;
            this.devuelto = devuelto;
        }

        
    }
}
