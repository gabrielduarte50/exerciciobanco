using ConsoleApp1.Banco.Interfaces;

namespace ConsoleApp1.Banco.Classes
{
    public class ContaService : IContaService
    {
           
        public double PegaSaldo(Conta c)
        {
            return c.Saldo;
        }

        public double Deposita(double saldo, double valor)
        {
            
            return saldo+=valor;
        }
    }
}