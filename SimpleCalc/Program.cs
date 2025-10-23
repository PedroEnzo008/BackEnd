/*Pedir o nome do usuario, dois números e mostrar a soma dos números no final */

String nome;
int numero1;
int numero2;

//pedir os nome pro usuario
Console.WriteLine("Digite seu Nome");
nome = Console.ReadLine(); //pede o nome do usuario


Console.WriteLine(nome); // exibe o nome do usuario

//-----------------------------pedindo numero 1-----------------------------//
Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine(numero1);

//-----------------------------pedindo numero 2-----------------------------//
Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());
Console.WriteLine(numero2);

//-----------------------------Somar os dois numeros-----------------------------//
int soma = numero1 + numero2;

//-----------------------------exibir nome e soma-----------------------------//
Console.WriteLine(nome);
Console.WriteLine(soma);

