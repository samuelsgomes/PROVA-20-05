namespace prova_sobre_objeto.ATIVIDADE_2;
{
    public class Gerente : Funcionario
    {
        public double CalcularBonus()
        {
          return Salario * 0.20;
        }
        public override void Mostrar()
        {
        Console.WriteLine($"O gerente {Nome} recebe um salário com bônus de R${CalcularBonus()}");
        }

    }
}