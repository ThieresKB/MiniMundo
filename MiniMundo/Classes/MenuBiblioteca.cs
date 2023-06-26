
using MiniMundo.Interfaces;

namespace MiniMundo.Classes
{
    public class MenuBiblioteca
    {
        private Biblioteca biblioteca;

        public MenuBiblioteca()
        {
            biblioteca = new Biblioteca();
        }

        public void ExibirMenu()
        {
            Console.Write(
                "========== MENU ==========\n\n" +
                "1. Adicionar item\n" +
                "2. Buscar item por título\n" +
                "3. Buscar item por autor\n" +
                "4. Listar todos os itens\n" +
                "5. Sair\n" +
                ".: "
            );
        }

        public int LerOpcao()
        {
            Console.Write("Digite a opção desejada: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void ExecutarOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    AdicionarItem();
                    break;
                case 2:
                    BuscarPorTitulo();
                    break;
                case 3:
                    BuscarPorAutor();
                    break;
                case 4:
                    ListarItens();
                    break;
                case 5:
                    Console.WriteLine("Encerrando o programa...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private void AdicionarItem()
        {
            Console.Write(
                "===== ADICIONAR ITEM =====\n" +
                "Digite o tipo de item:\n" +
                "1 - livro\n" +
                "2 - revista\n" +
                "3 - DVD\n" +
                "4 - Manga\n" +
                "5 - Manhwa\n" +
                "6 - HQ\n" +
                "7 - Jornal\n" +
                "8 - Gibi\n" +
                ".: "
            );
            string tipo = Console.ReadLine();
            Console.Write("Digite o título do item: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do item: ");
            string autor = Console.ReadLine();

            try
            {
                switch (int.Parse(tipo))
                {
                    case 1:
                        Console.Write("Digite a editora do livro: ");
                        string editora = Console.ReadLine();
                        IItemBiblioteca livro = new Livro(titulo, autor, editora);
                        biblioteca.AdicionarItem(livro);
                        break;
                    case 2:
                        Console.Write("Digite a edição da revista: ");
                        int edicao = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o mês da revista: ");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o ano da revista: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        IItemBiblioteca revista = new Revista(titulo, autor, edicao, mes, ano);
                        biblioteca.AdicionarItem(revista);
                        break;
                    case 3:
                        Console.Write("Digite o diretor do DVD: ");
                        string diretor = Console.ReadLine();
                        Console.Write("Digite a duração do DVD (em minutos): ");
                        int duracao = Convert.ToInt32(Console.ReadLine());
                        IItemBiblioteca dvd = new DVD(titulo, autor, diretor, duracao);
                        biblioteca.AdicionarItem(dvd);
                        break;
                    case 4:
                        Console.Write("Digite a editora do manga: ");
                        editora = Console.ReadLine();
                        IItemBiblioteca manga = new Manga(titulo, autor, editora);
                        biblioteca.AdicionarItem(manga);
                        break;
                    case 5:
                        Console.Write("Digite a editora do manhwa: ");
                        editora = Console.ReadLine();
                        IItemBiblioteca manhwa = new Manhwa(titulo, autor, editora);
                        biblioteca.AdicionarItem(manhwa);
                        break;
                    case 6:
                        Console.Write("Digite a editora da Historia em Quadrinhos: ");
                        editora = Console.ReadLine();
                        IItemBiblioteca hq = new HQ(titulo, autor, editora);
                        biblioteca.AdicionarItem(hq);
                        break;
                    case 7:
                        Console.Write("Digite a editora do jornal: ");
                        editora = Console.ReadLine();
                        IItemBiblioteca jornal = new Jornal(titulo, autor, editora);
                        biblioteca.AdicionarItem(jornal);
                        break;
                    case 8:
                        Console.Write("Digite a editora da Historia em Quadrinhos: ");
                        editora = Console.ReadLine();
                        IItemBiblioteca gibi = new Gibi(titulo, autor, editora);
                        biblioteca.AdicionarItem(gibi);
                        break;
                    default:
                        Console.WriteLine("Tipo de item inválido!");
                        break;
                }
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex.ToString() );
            }
   
        }

        private void BuscarPorTitulo()
        {
            Console.WriteLine("===== BUSCAR ITEM POR TÍTULO =====");
            Console.Write("Digite o título do item: ");
            string titulo = Console.ReadLine();

            List<IItemBiblioteca> resultados = biblioteca.BuscarItemPorTitulo(titulo);
            if (resultados.Count == 0)
            {
                Console.WriteLine("Nenhum item encontrado com o título informado.");
            }
            else
            {
                Console.WriteLine("Itens encontrados:");
                foreach (IItemBiblioteca item in resultados)
                {
                    Console.WriteLine("Título: " + item.Titulo);
                    Console.WriteLine("Autor: " + item.Autor);
                    Console.WriteLine();
                }
            }
        }

        private void BuscarPorAutor()
        {
            Console.WriteLine("===== BUSCAR ITEM POR AUTOR =====");
            Console.Write("Digite o autor do item: ");
            string autor = Console.ReadLine();

            List<IItemBiblioteca> resultados = biblioteca.BuscarItemPorAutor(autor);
            if (resultados.Count == 0)
            {
                Console.WriteLine("Nenhum item encontrado com o autor informado.");
            }
            else
            {
                Console.WriteLine("Itens encontrados:");
                foreach (IItemBiblioteca item in resultados)
                {
                    Console.WriteLine("Título: " + item.Titulo);
                    Console.WriteLine("Autor: " + item.Autor);
                    Console.WriteLine();
                }
            }
        }

        private void ListarItens()
        {
            Console.WriteLine("===== LISTAR ITENS =====");
            biblioteca.ListarItens();
        }

    }
}
