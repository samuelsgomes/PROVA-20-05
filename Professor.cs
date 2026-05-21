namespace prova_sobre_objeto
{
    public class  Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome {Nome} e eu ganho um R${Salario} !");
           
        }
    }
}