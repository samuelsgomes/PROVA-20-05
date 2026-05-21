namespace prova_sobre_objeto
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public double Salario { get; set; }

        public virtual void Mostrar()
        {
            Console.WriteLine($"o funcionário {Nome}, recebe um salário de R${Salario}");
        }
    }
}