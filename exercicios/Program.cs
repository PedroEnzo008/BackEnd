double salario, salario_reajustdo, aumento = 0;
string cargo;

Console.Write("Digite o seu cargo: ");
cargo = Console.ReadLine();

Console.Write("Digite o seu salario: ");
salario = double.Parse(Console.ReadLine());

if (cargo == "produção")
{
    aumento = 6.5;
}
else if (cargo == "administrativo")
{
    aumento = 7.5;
}
else if (cargo == "diretoria")
{
    aumento = 12;
}


salario_reajustdo = salario + (salario * aumento / 100);
{
    Console.WriteLine($"cargo: {cargo}");
    Console.WriteLine($"salario antigo R$: {salario}");
    Console.WriteLine($"aumento: {aumento}%");
    Console.WriteLine($"Salario reajustado R$: {salario_reajustdo}");
}