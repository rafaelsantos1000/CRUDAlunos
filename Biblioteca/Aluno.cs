namespace Biblioteca
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Apelido}";
            }
        }

        public override string ToString()
        {
            return $"{Id} {Nome} {Apelido}";
        }
    }
}
