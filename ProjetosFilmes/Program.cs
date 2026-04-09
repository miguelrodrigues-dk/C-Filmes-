
using SistemaFilmes;

class Program
{
    static void Main(string[] args)
    {
        // 1. Categorias
        Categoria Ação = new Categoria("Ação");
        Categoria Drama = new Categoria("Drama");
        Categoria Cómedia = new Categoria("Cómedia");
        Categoria FicçãoCientífica = new Categoria("Ficção Científica");
        Categoria Terror = new Categoria("Terror");
        Categoria Aventura = new Categoria("Aventura");
        Categoria Documentario = new Categoria("Documentario");
        Categoria Animação = new Categoria("Animação");
        Categoria Suspense = new Categoria("Suspense");
        Categoria Fantasia = new Categoria("Fantasia");
        Categoria Romance = new Categoria("Romance");
        //2. Filmes
        Filme filme1 = new Filme("Vingadores Ultimato", 181, Ação);
        Filme filme2 = new Filme("Crepúsculo", 127, Drama);
        Filme filme3 = new Filme("The Batman", 176, Ação);
        Filme filme4 = new Filme("Golpe Baixo ", 113, Cómedia);
        Filme filme5 = new Filme("Star Wars: lV-Uma Nova Esperança ", 121, FicçãoCientífica);
        Filme filme6 = new Filme("Meu namorado é um Zumbi ", 98, Romance);
        Filme filme7 = new Filme("Jumanji: Bem Vindo à Selva", 119, Aventura);
        Filme filme8 = new Filme("Pânico 7 ", 114, Terror);
        Filme filme9 = new Filme("Apollo 11", 93, Documentario);
        Filme filme10 = new Filme("Um lugar Silencioso", 90, Suspense);
        Filme filme11 = new Filme(" Gato de Botas 2: O Último Pedido",102 , Animação);
        Filme filme12 = new Filme(" Toy Story 2",92 , Animação);
        Filme filme13 = new Filme(" Harry Potter e a Pedra Filosofal",152 , Fantasia);
        Filme filme14 = new Filme(" Shrek 2",93 , Animação);


        // 3. Lista de Filmes
        Console.WriteLine("----------------------- LISTA DE FILMES -----------------------");
        filme1.Exibir();
        filme2.Exibir();
        filme3.Exibir();
        filme4.Exibir();
        filme5.Exibir();
        filme6.Exibir();
        filme7.Exibir();
        filme8.Exibir();
        filme9.Exibir();
        filme10.Exibir();
        filme11.Exibir();
        filme12.Exibir();
        filme13.Exibir();
        filme14.Exibir();
        Console.WriteLine("----------------------------------------------------------------");
    }
}