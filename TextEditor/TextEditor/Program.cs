
namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short.TryParse(Console.ReadLine(), out short option);

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: break;
            }
        }

        static void Open()
        {

        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);
        }
    }
}