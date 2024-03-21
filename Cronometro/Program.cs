class Program
{
    static void Main(string[] args)
    {
        while (true)
            Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("*** Programa Iniciado ***");

        Console.WriteLine("S = Segundo  => 10s = 10 segundos");
        Console.WriteLine("M = Minuto   => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        
        Console.Write("Quanto tempo deseja contar? ");
        string data = Console.ReadLine().ToLower();

        char type = char.Parse(data.Substring(data.Length - 1,1));
        int time = int.Parse(data.Substring(0, data.Length - 1));

        if (type.Equals('m'))
            time *= 60;

        Start(time);
    }

    static void Start(int time)
    {
        int tempo = time;
        int tempoAtual = 0;

        while (tempoAtual != tempo)
        {
            Console.Clear();

            tempoAtual++;
            Console.WriteLine(tempoAtual);
            
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronômetro finalizado");

        Thread.Sleep(2500);
    }
}
