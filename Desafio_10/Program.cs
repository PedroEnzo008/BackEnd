using System;


    
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("===> MENU DE EXERCÍCIOS <===");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Entrada inválida. Pressione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("Pressione <Enter> para voltar ao menu...");
                Console.ReadLine();
            }

        } while (opcao != 0);
    

    static void Exercicio1()
    {
    Console.WriteLine("Exercício 1...");
        
         double salario, gastos;

        Console.Write("Digite o salário recebido: R$ ");
        salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o total gasto: R$ ");
        gastos = double.Parse(Console.ReadLine());

        if (gastos <= salario)
        {
            Console.WriteLine("Gastos dentro do orçamento.");
        }
        else
        {
            Console.WriteLine("Orçamento estourado!!");
        }
    }

    static void Exercicio2()
    {
    Console.WriteLine("Exercício 2...");
        
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

    }

    static void Exercicio3()
    {
        Console.WriteLine("Exercício 3...");
         double lado1, lado2, lado3;

        Console.Write("Digite o valor do primeiro lado: ");
        lado1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
        lado2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
        lado3 = double.Parse(Console.ReadLine());

      
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("É um Triângulo Equilátero (3 lados iguais).");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("É um Triângulo Isósceles (2 lados iguais).");
            }
            else
            {
                Console.WriteLine("É um Triângulo Escaleno (3 lados diferentes).");
            }
        }
        else
        {
            Console.WriteLine("As medidas informadas não formam um triângulo.");
        }

    }

    static void Exercicio4()
    {
    Console.WriteLine("Exercício 4...");
        
        int senha = 1234;

Console.Write("Digite a senha: ");
senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.Write("ACESSO PERMITIDO !!! ");

}

else
{
    Console.Write("ACESSO NEGADO !!! ");
}
    }

    static void Exercicio5()
    {
        Console.WriteLine("Exercício 5...");
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
    }

    static void Exercicio6()
    {
    Console.WriteLine("Exercício 6...");
        
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


    }

