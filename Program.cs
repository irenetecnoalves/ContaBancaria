using System;
using System.Globalization;
using terminal.Classes;


namespace terminal
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Digite o número da Conta ");
            int numero= int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o nome do Titular ");
            string titular = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Deseja efetuar deposito( S/N )? " );
            char resposta = char.Parse(Console.ReadLine());
           
            if (resposta == 's' || resposta =='S'){

                 Console.Write("Valor do Depósito Inicial ");
                 double depositoInicial= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                 conta= new ContaBancaria(numero, titular, depositoInicial);

            }
           else {
                conta = new ContaBancaria(numero,titular);
            
           }
                Console.WriteLine();
                Console.WriteLine("Dados da Conta");
                Console.WriteLine(conta);


             Console.Write("Deseja continuar o processo (S/N)? ");
             char resp = char.Parse(Console.ReadLine());

            while ( resp == 's' || resp=='S' ){
                Console.WriteLine();
                Console.Write("Depósito:");
                double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta.deposito(quantia);
                Console.Write("Dados da conta atualizados");
                Console.WriteLine(conta);

               Console.WriteLine();
               Console.Write("Saque:");
               quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
               conta.saque(quantia);
               Console.Write("Dados da conta atualizados");
               Console.WriteLine(conta);
               Console.WriteLine();
               Console.Write("Deseja continuar o processo (S/N) ?");
               resp = char.Parse(Console.ReadLine());

            }

        }

    }
}
