using System.Collections;
Console.Clear();
Console.WriteLine($"Digite seu nome");
String nome = Console.ReadLine();
Console.WriteLine($"Digite seu sobrenome");
String sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar as boas vindas a voce!!");

Console.WriteLine($"por favor escolha uma opção abaixo:");
Console.WriteLine($"1 - Saudar com nome");
Console.WriteLine($"2 - Saudar com sobrenome ");
Console.WriteLine($"3 - Saudar com nome e sobrenome");
Console.WriteLine($"0 - Apenas saudação genérica");
Console.Clear();

int opcao = 0;
switch (opcao)
{
    case 0:
        saudacaoGenerica();
        break;
    case 1:
        saudacaoComNome(nome);
        break;
    case 2:
        saudarcomSobrenome(sobrenome);
        break;
    case 3:
        string NomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo {NomeCompleto}");
        break;
    default:
        break;
}
void saudarcomSobrenome(string sobrenomeRecbido)
{
    Console.WriteLine($"Olá, Seja bem-vindo {sobrenomeRecbido}");

}

void saudacaoGenerica()
{
    Console.WriteLine($"Olá, seja bem vindo ao nosso programa, tenha um ótimo dia :)");

}

void saudacaoComNome(String nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}

string DevolveNomeCompleto(string nomeRecebido, string sobrenomeRecbido)
{
    return $"{nomeRecebido} {sobrenomeRecbido}";
}