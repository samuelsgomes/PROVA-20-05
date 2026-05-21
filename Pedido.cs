namespace prova_sobre_objeto
{
    public class Pedido
    {
        public decimal Valor { get; set; }

        public virtual void CalcularEntrega()
        {
          Console.WriteLine("O tipo de Entrega:");
        }
    }
}