namespace ControleDeAnimais
{
    public enum TipoAnimal { Cachorro, Gato, Peixe }

    public class Animal
    {
        public Animal()
        {
            Nome = "";
            Tipo = TipoAnimal.Peixe;
        }

        public Animal(string nome, TipoAnimal tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private TipoAnimal tipo;
        private readonly string nome1;
        private readonly string tipo1;

        public TipoAnimal Tipo
        {
            // Valores definidos pelo proprietário, Cachorro, Gato, Peixe
            get { return tipo; }
            set { tipo = value; }
        }
    }
}