namespace prova_sobre_objeto
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e possuo uma nota de aproximadamente {Nota}");
        }
    }
}