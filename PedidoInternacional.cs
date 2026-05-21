namespace prova_sobre_objeto
{
    public class PedidoInternacional : Pedido
    {
         public override void CalcularEntrega()
        {
        Console.WriteLine($"O Valor Com Pedido Internacional: {Valor += 50}");
        }
    }
}