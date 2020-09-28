using ConsoleApp1.Banco.Interfaces;
using ConsoleApp1.Classes.Interface;

namespace ConsoleApp1.Classes
{
    internal class ContaInvestimento : Conta, IContaInvestimento, ITributavel
    {
       
        public double Saca(Conta conta,double valor)
        {
            return conta.Saldo = conta.Saldo - (valor + 0.30);
        }

        public double CalculaTributo()
        {
            return Saldo * 0.03;
        }
    }
}