using ConsoleApp1.Banco.Classes;

namespace ConsoleApp1.Banco.Interfaces
{
    public interface IContaService
    {
        public double PegaSaldo(Conta c);

        public double Deposita(double saldo, double valor);
    }
}