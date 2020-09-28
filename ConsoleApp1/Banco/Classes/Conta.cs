using ConsoleApp1.Banco.Classes;
using ConsoleApp1.Banco.Interfaces;

namespace ConsoleApp1
{
    public abstract class Conta : IConta

    {  
        public int Numero { get; set; }
        public double Saldo { get; set; }

        private IContaService _contaService = new ContaService();
        //public Conta(IContaService contaService)
        //{
        //    _contaService = contaService;
        //}
        public Conta()
        {

        }
        public double MeuSaldo(Conta c)
        {
            return _contaService.PegaSaldo(c);
        }
        public double MeuDeposito( double saldo, double valor)
        {  
            
            return _contaService.Deposita(saldo, valor);
        }


    }


}
