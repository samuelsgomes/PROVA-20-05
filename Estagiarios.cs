namespace prova_sobre_objeto
{
    public class Estagiarios : Funcionario
    {
        public double CalcularBonus()
        {
            return Salario * 0.5;
        }
        public override void Mostrar()
        {
            Console.WriteLine($"O estagiario {Nome} recebe um salário com bônus de R${CalcularBonus()}");
        }
    }
}