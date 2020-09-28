using ConsoleApp1.Banco.Interfaces;

namespace ConsoleApp1.Classes
{
    internal class ContaCorrente : Conta
    {
      
        public ContaCorrente():base()
        {
           
        }


        public double Saca(Conta conta,double valor)
        {   
           return conta.Saldo = conta.Saldo-(valor + 0.15);
        }
    }
}