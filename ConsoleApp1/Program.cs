using ConsoleApp1.Banco.Interfaces;
using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*CONTA CORRENTE*/
            ContaCorrente();

            /*CONTA POUPANCA*/
            ContaPoupanca();

            /*CONTA INVESTIMENTO*/
            ContaInvestimento();
        }

        private static void ContaInvestimento()
        {
            ContaInvestimento ci = new ContaInvestimento();
            ci.Numero = 110;
            ci.Saldo = 100;
            Console.WriteLine("Nova conta investimento");
            ci.Saldo = ci.MeuDeposito(ci.Saldo, 200);
            ci.Saca(ci,150);
            double saldoci = ci.MeuSaldo(ci);
            double tribci = ci.CalculaTributo();
            Console.WriteLine($"Valor Saldo: {saldoci}");
            Console.WriteLine($"Valor Tributavel: {tribci}");
            Console.WriteLine("----------");
        }

        private static void ContaPoupanca()
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Numero = 100;
            cp.Saldo = 50;
            Console.WriteLine("Nova conta poupança");
            cp.Saldo = cp.MeuDeposito(cp.Saldo, 200);
            cp.Saca(cp,110);
            double saldocp = cp.MeuSaldo(cp);
            double tribcp = cp.CalculaTributo();
            Console.WriteLine($"Valor Saldo: {saldocp}");
            Console.WriteLine($"Valor Tributavel: {tribcp}");
            Console.WriteLine("----------");
        }

        private static void ContaCorrente()
        {
            
            ContaCorrente c = new ContaCorrente();
            c.Numero = 10;
            c.Saldo = 20;
            Console.WriteLine("Nova conta corrente");
            c.Saldo = c.MeuDeposito(c.Saldo, 100);
            c.Saca(c,50);
            double saldoc = c.MeuSaldo(c);
            Console.WriteLine($"Valor Saldo: {saldoc}");
            Console.WriteLine("-----------");
        }
    }
}