namespace prova_sobre_objeto
{
    public class Diretor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"O diretor {Nome}, ganha um salário R${Salario} !");
        }
    }
}