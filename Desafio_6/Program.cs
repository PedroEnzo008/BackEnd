{

        Console.Write("Digite a média do aluno: ");
        double media = double.Parse(Console.ReadLine());

        Console.Write("Digite a frequência do aluno (em %): ");
        double frequencia = double.Parse(Console.ReadLine());

        // Estruturas de decisão
        if (frequencia < 75)
        {
            Console.WriteLine("Aluno REPROVADO por frequência.");
        }
        else if (media >= 7.0)
        {
            Console.WriteLine("Aluno APROVADO.");
        }
        else if (media >= 3.0)
        {
            Console.WriteLine("Aluno em RECUPERAÇÃO.");
        }
        else
        {
            Console.WriteLine("Aluno REPROVADO por média.");
        }
    }

