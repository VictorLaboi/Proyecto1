using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Libros
    {
        public string titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; set; }
        public Guid Id { get; set; }


        public Libros(string titulo, string autor, bool disponible)
        {
            this.titulo = titulo;
            this.Autor = autor;
            this.Disponible = disponible;
            this.Id = Guid.NewGuid();
        }

        public bool Valida() {
            return Disponible;
        }
        public void Prestamo() { 
            if(!Disponible)
            {
                throw new Exception("Libro en uso!");
            }
            Disponible = false;    
        }
        public void Devuelto() {
            Disponible = true;
        }
    }

}
