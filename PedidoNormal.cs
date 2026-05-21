namespace prova_sobre_objeto
{
    public class PedidoNormal : Pedido
    {
        public override void CalcularEntrega()
        {
            Console.WriteLine($"O Valor Com Pedido Normal: {Valor += 10}");
        }
    }
}