using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Lector:Persona
    {
        public List<Libros> LibrosPrestamo { get; private set; }
        public Lector(string nombre, Guid id) : base(nombre,id) { 
            LibrosPrestamo = new List<Libros>();
        }
        public override void RegistrarUsuario()
        {

        }
        public List<Libros> LibrosPrestados() { 
            return LibrosPrestamo;
        }
        public void Prestamo(Libros libro) {
            if (!libro.Valida()) {
                throw new Exception("Libro no disponible");
            }
            libro.Prestamo();
            LibrosPrestamo.Add(libro);
        }
        public void Devolucion(Libros libro) {
            if (LibrosPrestamo.Contains(libro)) {
                libro.Devuelto();
                LibrosPrestamo.Remove(libro);
            }
        }

    }
}
