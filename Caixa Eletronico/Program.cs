// See https://aka.ms/new-console-template for more information
using Caixa_Eletronico;

Usuario a = new Usuario();

Console.WriteLine("Bem vindo, por favor digite seu nome:");
string cliente = Console.ReadLine();
a.SetNome(cliente);
Console.WriteLine("Por favor digite sua senha:");
int pass = int.Parse(Console.ReadLine());
a.SetSenha(pass);

Console.WriteLine(" ");
Console.WriteLine(a);
Operacoes op = new Operacoes();

int encerramento;

do
{
    Console.WriteLine("\r\nO que deseja fazer?\r\n1 - Saque\r\n2 - Depósito\r\n3 - Saldo\r\n");

    int escolha = int.Parse(Console.ReadLine());
   


    if (escolha == 1)
    {
        Console.WriteLine("\r\nQuanto deseja sacar?");

        double saq = double.Parse(Console.ReadLine());

        if (op.Saque > op.Saldo)
        {
            Console.WriteLine("\r\nVocê não possui saldo suficiente.");
        }
        else
        {
            op.OpSaque(saq);
            Console.WriteLine("\r\nOperação bem sucedida");
            Console.WriteLine("\r\nO seu novo saldo é de R$ " + op.Saldo.ToString("F2"));
        }

    }

    if (escolha == 2)
    {
        Console.WriteLine("\r\nQuanto deseja depositar?");
        double dep = double.Parse(Console.ReadLine());
        op.OpDeposito(dep);
        Console.WriteLine("\r\nSeu novo saldo é de R$ " + op.Saldo.ToString("F2"));
    }

    if (escolha == 3)
    {
        Console.WriteLine("\r\nSeu saldo é de R$ " + op.Saldo.ToString("F2"));
    }

    Console.WriteLine("Deseja realizar uma nova transação?\r\n1 - Sim\r\n2 - Não");
    encerramento = int.Parse(Console.ReadLine());
    

} while(encerramento != 2);


