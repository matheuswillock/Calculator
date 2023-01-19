namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja realizar?");

            Console.WriteLine("\n" +
                    "1 - Soma\n" +
                    "2 - Subtração\n" +
                    "3 - divisão\n" +
                    "4 - Multiplicação\n" +
                    "5 - Sair\n"
                );

            Console.WriteLine("------------------\nSelecione um opção: ");
            
            short optionMenu = short.Parse(Console.ReadLine()!);

            switch (optionMenu)
            {
                case 1: operationExecute("sum"); break;
                case 2: operationExecute("subtration"); break;
                case 3: operationExecute("division"); break;
                case 4: operationExecute("multiplication"); break;
                case 5: operationExit(); break;
                default: menu(); break;
            }

        }

        static void operationExecute(string operation)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor\n");
            float valueA = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o segundo valor\n");
            float valueB = float.Parse(Console.ReadLine()!);

            switch (operation)
            {
                case "sum": sum(valueA, valueB); break;
                case "subtration": subtration(valueA, valueB); break;
                case "division": division(valueA, valueB); break;
                case "multiplication": multiplication(valueA, valueB); break;
            }
        }

        static void operationExit() 
        {
            Console.Clear();

            Console.WriteLine("Obrigado por utilizar a aplicação!");
            Environment.Exit(0); 
        }

        static void sum(float valueA, float valueB)
        {
            float resultSum = valueA + valueB;

            Console.WriteLine($"O resultado da soma é: {resultSum}\n\n\nTecle Enter para voltar ao menu novamente.");

            Console.ReadKey();
            menu();
        }

        static void subtration(float valueA, float valueB) 
        {
            float resultSubtration = valueA - valueB;

            Console.WriteLine($"O resultado da subtração é: {resultSubtration}\n\n\nTecle Enter para voltar ao menu novamente.");

            Console.ReadKey();
            menu();
        }

        static void division(float valueA, float valueB)
        {
            float resultDivision = valueA / valueB;

            Console.WriteLine($"O resultado da divisão é: {resultDivision}\n\n\nTecle Enter para voltar ao menu novamente.");

            Console.ReadKey();
            menu();
        }

        static void multiplication(float valueA, float valueB)
        {
            float resultMultiplication = valueA * valueB;

            Console.WriteLine($"O resultado da soma é: {resultMultiplication}\n\n\nTecle Enter para voltar ao menu novamente.");

            Console.ReadKey();
            menu();
        }
    }
}