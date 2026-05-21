namespace prova_sobre_objeto
{
    public class Pessoa 
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, e possuo uma {Idade} significante");
        }
    }
}