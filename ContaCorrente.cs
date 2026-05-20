namespace prova_sobre_objeto
{
    public class ContaCorrente : Conta
    {
        public double TaxaSaque { get; set; }
        public override void Sacar(double valor)
        {
            base.Sacar(valor + TaxaSaque);
        }

    }
}
