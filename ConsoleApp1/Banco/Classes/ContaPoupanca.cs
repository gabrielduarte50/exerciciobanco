using ConsoleApp1.Banco.Classes;
using ConsoleApp1.Banco.Interfaces;
using ConsoleApp1.Classes.Interface;

namespace ConsoleApp1.Classes
{
    public class ContaPoupanca : Conta, IContaPoupanca, ITributavel
    {
       

        public double Saca(Conta conta, double valor)
        {
            return conta.Saldo = conta.Saldo - (valor + 0.10);
        }

        public double CalculaTributo()
        {
            return Saldo * 0.05;
        }
    }
}