//Faça um programa que solicite ao usuario oum numero de repetições "x". para cada repetição
//Solicite dois numeros e imprima qual é o maior deles.

int n = 0, contador = 0, n1, n2 ;

Console.WriteLine("Digite o numero de repetição");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    Console.WriteLine("Digite o primeiro numero:");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o primeiro numero:");
    n2 = int.Parse(Console.ReadLine());

    if (n1 < n2)
    {
        Console.WriteLine($"O numero {n1} e maior que o numero {n2}");
    }
    else if (n1 < n2)
    {
        Console.WriteLine($"O numero {n2} e maior que o numero {n1}");
    }
    else
    {
        Console.WriteLine($"Os dois numeros são iguais: {n1} = {n2}");
    }
        contador++;
}