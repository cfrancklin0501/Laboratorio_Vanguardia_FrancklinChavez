using System.Dynamic;

namespace BibliotecaMonolito.Models
{
    public class Libro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int AnioPublicacion { get; set; }

        public int AuthorId { get; set; }

        public Autor? Autor { get; set; }


    }
}