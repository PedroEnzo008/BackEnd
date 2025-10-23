 double salario, gastos;

        Console.Write("Digite o salário recebido: R$ ");
        salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o total gasto: R$ ");
        gastos = double.Parse(Console.ReadLine());

        if (gastos <= salario)
        {
            Console.WriteLine("Gastos dentro do orçamento.");
        }
        else
        {
            Console.WriteLine("Orçamento estourado!!");
        }