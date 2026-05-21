namespace prova_sobre_objeto
{
    public class Personagem
    {
        public string Nome { get; set; } = "";

        private int vida;

        public int Vida
        {
            get { return vida; }

            set
            {
                if (value < 0)
                    vida = 0;

                else if (value > 100)
                    vida = 100;

                else
                    vida = value;
            }
        }
        public int Ataque { get; set; }
    }
}