string[] nomes = new string[3];
double[] saldos = new double[3];
int  totalClientes = 0;
int opcao = -1;//Opção inválida



do
{
    Console.Clear();
    Console.WriteLine($"== SISTEMA BANCÁRIO SIMPLES ==");
    Console.WriteLine();
    Console.WriteLine($"1 - Cadastrar Cliente");
    Console.WriteLine($"2 - Depositar");
    Console.WriteLine($"3 - Sacar");
    Console.WriteLine($"4 - Transferir");
    Console.WriteLine($"5 - Listar Clientes");
    Console.WriteLine($"0 - Sair");
    Console.WriteLine();
    Console.Write($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    //chamar a função
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");

            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarClientes();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            Console.ReadLine();//para o sistema e espera o usuário digitiar Enter!!
            break;

    }//fim do switch
    
    Console.WriteLine($"Pressione <Enter> para encerrar...");
            Console.ReadLine();
} while (opcao != 0);


//=============== Funções ===============

//Função para cadastrar cliente
void CadastrarCliente()
{
    //verificar espaço no array para cadastrar (totalAlunos)
    //pedir os dados para o usuário(nome, idade)
    Console.Write($"Digite o nome do Cliente: ");
    nomes[totalClientes] = Console.ReadLine();;
    saldos[totalClientes] = 0.0 ;//inicia o saldo zerado
    totalClientes++;

    Console.WriteLine($"Cliente cadastrado com sucesso");
    Console.WriteLine($"Há {totalClientes} Cliente(s) cadastrado(s) no sistema");
    
}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write($"Valor para Deposito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[idCliente] += valorDeposito;
    Console.WriteLine($"Deposito de R$ {valorDeposito} Realizado!");

    
}

void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.Write($"Valor do saque: ");
    double valorSolicitado = double.Parse(Console.ReadLine());

    if(saldos[idCliente] >= valorSolicitado)
    {
        saldos[idCliente] -= valorSolicitado;
        Console.WriteLine($"Saque realizado com sucesso!");
    } else
    {
        Console.WriteLine($"Saldo insuficiente");
    }
        
   
}

void Transferir()
{
    Console.WriteLine($"== Transferir ==");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }

    
    Console.WriteLine($"Conta de Destino: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }

    Console.Write($"Valor para transferir: ");
    double valor = double.Parse(Console.ReadLine());

    if (saldos[idClienteOrigem] >= valor)
    {
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteDestino] += valor;
        Console.WriteLine($"Transferencia concluida!");
    } else
    {
         Console.WriteLine($"Saldo insuficiente!");
    }
}

void ListarClientes()
{
    Console.WriteLine();
    Console.WriteLine($"== Lista de Clientes ==");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]}   |   Saldo: R$ {saldos[i] : F2}"); //mostra somente duas casas decimais 
        Console.WriteLine();
    }
    
    
}

int BuscarCliente()
{
    ListarClientes();//desenha/exibe a lista de clientes
    Console.Write($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());//posição do array onde ele está

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;//cliente não encontrado

    }
    return idCliente;//retorna o id do cliente cadastrado
}
