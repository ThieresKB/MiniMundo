using MiniMundo.Interfaces;

namespace MiniMundo.Classes
{
    public class Livro : IItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        public Livro(string titulo, string autor, string editora)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
        }
    }
}
