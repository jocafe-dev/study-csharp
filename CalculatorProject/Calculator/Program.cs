
namespace Calculator
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

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------------");
            Console.WriteLine("Selecione uma opção: ");
            short.TryParse(Console.ReadLine(), out short res);

            switch (res)
            {
                case (short)EOperation.Soma: Soma(); break;
                case (short)EOperation.Subtracao: Subtracao(); break;
                case (short)EOperation.Divisao: Divisao(); break;
                case (short)EOperation.Multiplicacao: Multiplicacao(); break;
                case (short)EOperation.Sair: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float.TryParse(Console.ReadLine(), out float firstValue);

            Console.WriteLine("Segundo valor:");
            float.TryParse(Console.ReadLine(), out float secondValue);

            Console.WriteLine("");

            float result = firstValue + secondValue;
            Console.WriteLine($"O resultado da soma é {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float.TryParse(Console.ReadLine(), out float firstValue);

            Console.WriteLine("Segundo valor:");
            float.TryParse(Console.ReadLine(), out float secondValue);

            Console.WriteLine("");

            float result = firstValue - secondValue;
            Console.WriteLine($"O resultado da subtração é {result}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            float.TryParse(Console.ReadLine(), out float firstValue);

            Console.WriteLine("Insira o segundo valor:");
            float.TryParse(Console.ReadLine(), out float secondValue);

            Console.WriteLine("");

            float response = firstValue / secondValue;
            Console.WriteLine($"O resultado da divisão é: {response}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            float.TryParse(Console.ReadLine(), out float firstValue);

            Console.WriteLine("Insira o segundo valor:");
            float.TryParse(Console.ReadLine(), out float secondValue);

            Console.WriteLine("");

            float response = firstValue * secondValue;
            Console.WriteLine($"O resultado da multiplicação é: {response}");
            Console.ReadKey();
            Menu();
        }

        enum EOperation
        {
            Soma = 1,
            Subtracao = 2,
            Divisao = 3,
            Multiplicacao = 4,
            Sair = 5
        }
    }
}