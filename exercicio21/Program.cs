int n, resultado = 0;




for (int i = 1; i >= 3; i--)
{

    Console.WriteLine("Digite o numero: ");
    n = int.Parse(Console.ReadLine());
    resultado += n;
}

Console.WriteLine($"Somatoria total: {resultado}");
