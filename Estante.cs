public class Estante {
  public int id {get; set;}
  public int capacidade {get; set;}

  public List<Livro> livro = new List<Livro>();

  public string exibirDetalhes(){
    return this.id + " " + this.capacidade;
  }

  public void adicionarLivro(Livro livro){
    this.livro.Add(livro);
  }
}