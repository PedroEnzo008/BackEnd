Console.Write("Digite o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco;
        if (quantidade >= 12)
        {
            preco = 0.25;
        }
        else
        {
            preco = 0.30;
        }

        double total = quantidade * preco;

        Console.WriteLine($"O valor total da compra é: R$ {total:F2}");