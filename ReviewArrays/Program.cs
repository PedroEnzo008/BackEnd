// Criação de Variáveis
string[] nomes = new string[4];//tamanho é 4 - de 0 a 3
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;

// Estrutura do menu
do
{
    Console.Clear();
    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar Alunos");
    Console.WriteLine($"0) Sair");
    Console.Write($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    //chamar a função correta
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <Enter> para encerrar ...");
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;

        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarAlunos();
            break;

        default:
            Console.WriteLine($"opção Inválida, pressione <Enter> para continuar ...");
            Console.ReadLine();//para o sistema e espera o usuário digitar Enter!!
            break;
    } //fim do switch
} while (opcao != 0);


// =============== Funções =============== 


void CadastrarAluno()
{
    // verificar se tem espaço no array para cadastrar (totalAlunos)
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limite de ocupação atingido");
        Console.WriteLine($"Pressione <Enter> para continuar ...");
        Console.ReadLine();
        return;
    }

    //pedir os dados para o usuário (nome, idade)
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();//lê o console e guarda o valor digitado na variável temporária "n"
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());//lê o console, converte em int e guarda o valor digitado na variável temporária "n"

    // guardar/cadastrar no array
    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} aluno(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//parar o sistema e esperar o usuário dar um <Enter>
}


// função para exibir os alunos
void ListarAlunos()
{
    Console.WriteLine();//pula uma linha
    Console.WriteLine($"Resultado: ");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"    Nome: {nomes[i]}");
        Console.WriteLine($"    Idade: {idades[i]} anos");
        Console.WriteLine();//pula uma linha
    }

    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();

}



