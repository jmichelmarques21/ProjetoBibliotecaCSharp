
using System.Security.Cryptography;

public class Program {
  public static void Main(string[] args){

    Livro livro1 = new Livro();
    livro1.id = 1;
    livro1.titulo = "Revolução dos Bichos";
    livro1.autor = "George Orwell";

    Livro livro2 = new Livro();
    livro2.id = 2;
    livro2.titulo = "O Mágico de Oz";
    livro2.autor = "L. Frank Baum";

    Livro livro3 = new Livro();
    livro3.id = 3;
    livro3.titulo = "Fahrenheit 451";
    livro3.autor = "Ray Bradbury";

    Estante estante1 = new Estante();
    estante1.id = 1;
    estante1.capacidade = 60;

    Estante estante2 = new Estante();
    estante2.id = 2;
    estante2.capacidade = 60;

    estante1.adicionarLivro(livro1);
    estante1.adicionarLivro(livro2);
    estante1.adicionarLivro(livro3);
    

    Biblioteca biblioteca1 = new Biblioteca();
    biblioteca1.nome = "Biblioteca Osório";
    biblioteca1.localizacao = "Curitiba";

    biblioteca1.adicionarEstante(estante1);
    biblioteca1.adicionarEstante(estante2);

    Biblioteca biblioteca2 = new Biblioteca();
    biblioteca2.nome = "Biblioteca Ecoville";
    biblioteca2.localizacao = "Curitiba";


   biblioteca1.exibirInformacoes();
   foreach(var bb in biblioteca1.estante) {
    System.Console.WriteLine(bb.id + " " + bb.capacidade);
   }

   foreach (var bb in estante1.livro){
    System.Console.WriteLine(bb.id + " " + bb.titulo + " " + bb.autor);
   }
   biblioteca1.exibirInformacoes();

  }
}