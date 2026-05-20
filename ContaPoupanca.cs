namespace prova_sobre_objeto
{
    public class ContaPoupanca : Conta
    {
        public void Render(double taxa)
        {
            Depositar(Saldo * taxa);
        }

    }
}