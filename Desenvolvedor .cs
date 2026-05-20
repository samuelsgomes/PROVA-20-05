namespace prova_sobre_objeto
{
    public class Desenvolvedor : Funcionario
    {
        public double CalcularBonus()
        {
            return Salario * 0.10;
        }
        public override void Mostrar()
        {
            Console.WriteLine($"O Desenvolvedor {Nome} recebe um salário com bônus de R${CalcularBonus()}");
        }
    }
}