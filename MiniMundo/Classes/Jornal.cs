using MiniMundo.Interfaces;

namespace MiniMundo.Classes
{
    public class Jornal : IItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public DateTime data { get; set; }

        public string Autor { get; set; }

        public Jornal(string titulo, string editora,string author)
        {
            Titulo = titulo;
            Autor = author;
            Editora = editora;
            data = new DateTime();
        }
    }
}
