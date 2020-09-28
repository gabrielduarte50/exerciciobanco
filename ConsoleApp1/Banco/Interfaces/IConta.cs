namespace ConsoleApp1.Banco.Interfaces
{
    public interface IConta
    {
        public int Numero { get; set; } /*auto-implemented property*/
        public double Saldo { get; set; }
    }
}