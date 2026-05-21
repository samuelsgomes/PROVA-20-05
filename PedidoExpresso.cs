namespace prova_sobre_objeto
{
    public class PedidoExpresso : Pedido
    {
          public override void CalcularEntrega()
        {
        Console.WriteLine($"O Valor Com Pedido Express: {Valor += 25}");
        }
    }
}