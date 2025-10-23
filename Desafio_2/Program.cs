int golsTime1, golsTime2;

        Console.Write("Digite o número de gols do primeiro time: ");
        golsTime1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de gols do segundo time: ");
        golsTime2 = int.Parse(Console.ReadLine());

        if (golsTime1 > golsTime2)
        {
            Console.WriteLine("Vitória do primeiro time!");
        }
        else if (golsTime2 > golsTime1)
        {
            Console.WriteLine("Vitória do segundo time!");
        }
        else
        {
            Console.WriteLine("O jogo terminou empatado!");
        }
