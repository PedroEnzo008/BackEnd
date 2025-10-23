int q = 0, i = 1, n = 1;

Console.Write("quantos numeros deseja digitar? : ");
q = int.Parse(Console.ReadLine());

while (n <= q)
{
    Console.Write("digite um numero: ");
    i = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        Console.Write($"o numero digitado é par : {i}");
    }
    n++;
}


