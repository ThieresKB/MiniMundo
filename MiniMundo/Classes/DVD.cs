using MiniMundo.Interfaces;

namespace MiniMundo.Classes
{
    public class DVD : IItemBiblioteca
    {
        public string Titulo{ get; set; }
        public string Autor{ get; set; }
        public string Diretor{ get; set; }
        public int Duracao{ get; set; }

        public DVD(string titulo, string autor, string diretor, int duracao)
        {
            Titulo = titulo;
            Autor = autor;
            Diretor = diretor;
            Duracao = duracao;
        }
    }
}
