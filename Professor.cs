namespace prova_sobre_objeto.ATIVADE_1;
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