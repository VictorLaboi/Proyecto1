using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Bibliotecario : Persona
    {
        private List<Libros> libros;
        public Bibliotecario(string nombre, Guid id,List<Libros>libros) : base(nombre, id) {
            this.libros = libros ?? new List<Libros>();
        }

        public override void RegistrarUsuario()
        {      
        }

        public void AgregarLibro(Libros libro)
        {
            if (libro == null) {
                throw new ArgumentNullException("No hay libro!");
            }
            libros.Add(libro);
        }

        public void ModificarLibro(Libros libro)
        {
            if (libro == null) { 
                throw new ArgumentNullException();
            }
            var existe = libros.Find(l => l.Id == libro.Id);
            if (existe != null)
            {
                existe.titulo = libro.titulo;
                existe.Autor = libro.Autor;
                existe.Disponible= libro.Disponible;
            }
        }

        public void EliminarLibro(Libros libro)
        {
            if (libro == null)
            {
                throw new ArgumentNullException(nameof(libro));
            }

            Console.WriteLine("¿ELIMINAR ESTE LIBRO? (SI/NO)");
            string resp = Console.ReadLine().Trim().ToUpper();
            if (resp == "SI")
            {
                libros.Remove(libro);
                Console.WriteLine("Libro eliminado.");
            }
            else if (resp == "NO")
            {
                Console.WriteLine("Cancelada.");
            }
            else
            {
                throw new Exception("Respuesta inválida");
            }
        }
    }
}
