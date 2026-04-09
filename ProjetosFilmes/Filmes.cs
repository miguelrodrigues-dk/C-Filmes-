namespace SistemaFilmes
{
    public class Filme
    {
        public string Titulo { get; }
        public int Duracao { get; }
        public Categoria Genero { get; }

        // Construtor obrigatório
        public Filme(string titulo, int duracao, Categoria genero)
        {
            Titulo = titulo;
            Duracao = duracao;
            Genero = genero;
        }

        public void Exibir()
        {
            Console.WriteLine($"Filme: [{Titulo}] | Duracao: [{Duracao}] min | Genero: [{Genero.Nome}]");
        }
    }
}