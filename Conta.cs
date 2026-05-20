namespace prova_sobre_objeto
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; } = "";

        private double saldo;

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            saldo -= valor;
        }
    }
}