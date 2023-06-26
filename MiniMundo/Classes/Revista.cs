using MiniMundo.Interfaces;

namespace MiniMundo.Classes
{
    public class Revista : IItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Edicao { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Revista(string titulo, string autor, int edicao, int mes, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Edicao = edicao;
            Mes = mes;
            Ano = ano;
        }
    }
}
