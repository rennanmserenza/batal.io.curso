internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
            Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("-------------");

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("0 - Sair");

        Console.WriteLine("-------------");

        Console.Write("Qual opção deseja escolher: ");
        short selectedOption = short.Parse(Console.ReadLine());

        SeletorFuncao(selectedOption);
    }

    static void SeletorFuncao(short selectedOption)
    {
        switch (selectedOption)
        {
            case 0: Console.WriteLine("Obrigado por utilizar esta calculadora."); Environment.Exit(0); break;
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            default: Console.WriteLine("!!!Valor selecionado inválido!!!"); Console.ReadKey(); break;
        }
    }

    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("*** SOMA ***");
        Console.Write("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;
        Console.WriteLine($"\nO resultado da Soma dos dois valores é igual a: {resultado}");

        Console.ReadKey();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("*** SUBTRAÇÃO ***");
        Console.Write("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 - v2;
        Console.WriteLine($"\nO resultado da Subtração dos dois valores é igual a: {resultado}");

        Console.ReadKey();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("*** DIVISÃO ***");
        Console.Write("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2;
        Console.WriteLine($"\nO resultado da Divisão dos dois valores é igual a: {resultado}");

        Console.ReadKey();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("*** MULTIPLICAÇÃO ***");
        Console.Write("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 * v2;
        Console.WriteLine($"\nO resultado da Multiplicação dos dois valores é igual a: {resultado}");

        Console.ReadKey();
    }
}