using MiniMundo.Classes;
static class Program
{ 
    public static void Main(string[] args)
    {
        MenuBiblioteca menu = new MenuBiblioteca();

        while (true)
        {
            menu.ExibirMenu();
            int opcao = menu.LerOpcao();
            Console.Clear();
            menu.ExecutarOpcao(opcao);
            Console.WriteLine();
        }
    }
}
