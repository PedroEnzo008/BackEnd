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