using byBank.Conta;
using byBank.Titular;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Iniciando os testes de objetos e definindo valiações
        /*ContaCorrente contaDoAndre = new ContaCorrente();
        contaDoAndre.titular = "André Silva";
        contaDoAndre.numeroAgencia = 15;
        contaDoAndre.conta = "1010-X";
        contaDoAndre.saldo = 100;

        Console.WriteLine("Informações da Maria/Saldo = R$" + contaDoAndre.saldo);

        /*
        if (contaDoAndre.Depositar(100) == true)
        {
            Console.WriteLine("Deposito efetuado com sucesso");
            Console.WriteLine("Informações da Conta/Saldo = R$" + contaDoAndre.saldo);
        }
        else
        {
            Console.WriteLine("O valor do deposito deve ser maior que R$1.00");
        }

        if(contaDoAndre.Sacar(100) == true)
        {
            Console.WriteLine("Saque efetuado com sucesso");
            Console.WriteLine("Informações da Conta/Saldo = R$" + contaDoAndre.saldo);
        }
        else
        {
            Console.WriteLine("Não foi possível realizar o saque. O saldo da conta é insuficiente ou o valor mínimo de saque não foi atingido");
        }


        ContaCorrente contaDaMaria = new ContaCorrente();
        contaDaMaria.titular = "Maria Souza";
        contaDaMaria.numeroAgencia = 17;
        contaDaMaria.conta = "1010-5";
        contaDaMaria.saldo = 350;

        Console.WriteLine("Informações da Maria/Saldo = R$" + contaDaMaria.saldo);
        /*
        if (contaDoAndre.Transferir(150, contaDaMaria) == true)
        {
            Console.WriteLine("Transferência efetuada com sucesso.");
            Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
            Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);
        }
        else
        {
            Console.WriteLine("Saldo para transferência é insuficiente.");
        }


        ContaCorrente contaDoPedro = new ContaCorrente();
        contaDoPedro.titular = "Pedro Silva";
        contaDoPedro.numeroAgencia = 17;
        contaDoPedro.conta = "1010-5";
        contaDoPedro.saldo = 350;

        Console.WriteLine("Informações da Maria/Saldo = R$" + contaDoPedro.saldo);*/

        //Chamada de objetos usando os metodos construtores padrões
        /*Cliente cliente = new Cliente();
        cliente.nome = "André Silva";
        cliente.cpf = "12345678900";
        cliente.profissao = "Analista";

        ContaCorrente conta = new ContaCorrente();
        conta.titular = cliente;
        conta.conta = "1010-X";
        conta.numeroAgencia = 15;
        conta.saldo = 100.0;

        Console.WriteLine("Titular = " + conta.titular.nome);
        Console.WriteLine("CPF = " + conta.titular.cpf);
        Console.WriteLine("Profissão = " + conta.titular.profissao);
        Console.WriteLine("Número da Conta = " + conta.conta);
        Console.WriteLine("Saldo = " + conta.saldo);
        Console.WriteLine("Agência = " + conta.numeroAgencia);

        ContaCorrente conta2 = new ContaCorrente();
        conta2.titular = new Cliente();
        conta2.titular.nome = "José Souza";
        conta2.titular.profissao = "Tester";
        conta2.titular.cpf = "987654321";
        conta2.conta = "9999-X";
        conta2.numeroAgencia = 18;
        conta2.saldo = 500;

        Console.WriteLine("Titular = " + conta2.titular.nome);*/

        //Testando o metodo SetSaldo
        /*ContaCorrente conta3 = new ContaCorrente();
        conta3.SetSaldo(200.0);
        conta3.NumeroAgencia = 18;
        conta3.Conta = "1011-H";

        Console.WriteLine(conta3.Conta);
        Console.WriteLine(conta3.NumeroAgencia);
        Console.WriteLine(conta3.GetSaldo());*/

        //Testando o metodo GetSaldo
        /*ContaCorrente conta4 = new ContaCorrente(18, "1010-X");

        conta4.titular = new Cliente();
        conta4.SetSaldo(500);

        Console.WriteLine(conta4.GetSaldo());
        Console.WriteLine(conta4.NumeroAgencia);*/

        //Teste final usando os metodos construtores e propriedades das classes nos objetos
        /*ContaCorrente conta5 = new ContaCorrente(283, "1234-X", new Cliente ("Nome", "CPF", "Profissão"));
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        ContaCorrente conta6 = new ContaCorrente(283, "1234-X", new Cliente ("Cliente", "CPF", "Profissão"));
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        Console.WriteLine(conta6.titular.Cpf);*/

        ContaCorrente conta7 = new ContaCorrente(1, "1235-C", new Cliente("Maria", "00011122233", "Gerente Comercial"));
        Console.WriteLine(ContaCorrente.TaxaOperacao);

        try
        {
            ContaCorrente contaErro = new ContaCorrente(0, "1235-C", new Cliente("Maria", "00011122233", "Gerente Comercial"));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
            Console.WriteLine("Não foi possível criar a conta!");
            Console.WriteLine(ex.Message);

        }
    }
}