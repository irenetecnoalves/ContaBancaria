
using System.Globalization;
using System;
namespace terminal.Classes
{
    public class ContaBancaria
    {

        public int Numero { get; private set; }

        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {

            this.Numero = numero;
            this.Titular = titular;
        }
       
        public ContaBancaria(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;

        }


        public void deposito(double quant){
            Saldo += quant;

        }
        public void saque(double quant){
            Saldo -= quant+5.00;

        }


        public override string ToString()

        {
            return "Conta: " + Numero  + "  Titular : " + Titular  + " Saldo da Conta : R$  " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }

}


