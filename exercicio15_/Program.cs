//Faça um programa que receba 4 notas de um aluno, calcule e imprima a média 
//Aritmetica das notas e a mensagem de aprovado para media superior ou igual a 
//7.0 RECUPERAÇÃO para notas entre 5.0 e 7.0 ou a mensagem de REPROVADO

double nota1, nota2, nota3, nota4, media;

Console.Write("Digite a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
        
Console.Write("Digite a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());

Console.Write("Digite a quarta nota: ");
nota4 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;
 Console.WriteLine($"\nA média do aluno é: {media:F1}");

        // Verificação da situação
        if (media >= 7.0)
        {
            Console.WriteLine("Situação: APROVADO");
        }
        else if (media >= 5.0)
        {
            Console.WriteLine("Situação: RECUPERAÇÃO");
        }
        else
        {
            Console.WriteLine("Situação: REPROVADO");
        }
    



