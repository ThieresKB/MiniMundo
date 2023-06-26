using MiniMundo.Interfaces;

namespace MiniMundo.Classes
{
    public class Biblioteca
    {
        private List<IItemBiblioteca> listaItens;

        public Biblioteca()
        {
            listaItens = new List<IItemBiblioteca>();
        }

        public void AdicionarItem(IItemBiblioteca item)
        {
            listaItens.Add(item);
            Console.WriteLine("Item adicionado com sucesso!");
        }

        public List<IItemBiblioteca> BuscarItemPorTitulo(string titulo)
        {
            List<IItemBiblioteca> resultados = new List<IItemBiblioteca>();
            foreach (IItemBiblioteca item in listaItens)
            {
                if (item.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    resultados.Add(item);
                }
            }
            return resultados;
        }

        public List<IItemBiblioteca> BuscarItemPorAutor(string autor)
        {
            List<IItemBiblioteca> resultados = new List<IItemBiblioteca>();
            foreach (IItemBiblioteca item in listaItens)
            {
                if (item.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase))
                {
                    resultados.Add(item);
                }
            }
            return resultados;
        }

        public void ListarItens()
        {
            foreach (IItemBiblioteca item in listaItens)
            {
                Console.WriteLine("Título: " + item.Titulo);
                Console.WriteLine("Autor: " + item.Autor);
                Console.WriteLine();
            }
        }
    }
}
