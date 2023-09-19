using Atividade_eranca.Classes;

class Program
{
    static void Main(string[] args)
    {
        int Nconta = 1;
        string agencia = "Ji-paraná";
        while (true)
        {
            Console.WriteLine("Olá seja bem vindo á Siceb, oque você deseja fazer hoje?" +
                "\n 1 - Para conta normal" +
                "\n 2 - Para cota estudante" +
                "\n 3 - Para conta empresarial" +
                "\n 4 - Fechar programa");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular:");
            string nomeTitular = Console.ReadLine();
            if(opcao == 1)
            {
                Conta conta = new Conta(Nconta, agencia, nomeTitular, 0);
                while (true)
                {
                    Console.WriteLine("Digite 1 para depositar" +
                        "\nDigite 2 para sacar" +
                        "\nDigite 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if(opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valor);
                        Console.WriteLine($"Novo saldo é de: {conta.Saldo}");
                    }
                    else if(opcao == 2 )
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        conta.Saque(valor);
                        Console.WriteLine($"Novo saldo é de: {conta.Saldo}");
                    }
                    else if (opcao == 3 )
                    {
                        break;
                    }
                }
            }
            else if(opcao == 2)
            {
                Console.WriteLine("Digite o CPF do estudante:");
                string cpf = Console.ReadLine();

                Console.WriteLine("Digite o nome da Instituição:");
                string instituição = Console.ReadLine();
                ContaEstudante contaest = new ContaEstudante(100, cpf, instituição, Nconta, agencia, nomeTitular, 0);

                while(true)
                {

                }
            }
            else if( opcao == 3)
            {
                ContaEmpresarial contaempr = new ContaEmpresarial(10, 100, 2000, Nconta, agencia, nomeTitular, 0);
                Nconta += 1;

                while(true)
                {
                    Console.WriteLine("Digite 1 para depositar" +
                        "\nDigite 2 para sacar" +
                        "\nDigite 3 para fazer emprestimo" +
                        "\nDigite 4 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if(opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        contaempr.Depositar(valor);
                        Console.WriteLine($"Novo saldo é de: {contaempr.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        contaempr.Saque(valor);
                        Console.WriteLine($"Novo saldo é de: {contaempr.Saldo}");
                    }
                    else if(opcao == 3)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        contaempr.RealizarEmprestimo(valor);
                        Console.WriteLine($"Novo saldo é de: {contaempr.Saldo}");
                    }
                    else if (opcao == 4)
                    {
                        break;
                    }
                }
            }

            else if( opcao == 4 )
            {
                Console.Clear();
                break;
            }
        }

        /*while (true)
        {
            Console.WriteLine("Seja bem vida Siceb, sua agencia bancaria favoritinha do Brasil!!");
            Console.WriteLine("Digite 0 caso sua conta for empresarial, digite 1 caso sua conta for Estudantiu ");
            int acao = Convert.ToInt32(Console.ReadLine());
          
        }*/

    }
}