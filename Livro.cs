using System.Reflection.Metadata.Ecma335;

public class Livro {
  public int id {get; set;}
  public string titulo {get; set;}
  public string autor {get; set;}
  public bool emprestado {get; set;}

  public string exibirInformacoes(){
    return this.id + " " + this.titulo + " " + this.autor;
  }

  public bool emprestar(){
    this.emprestado = true;
    return this.emprestado;
  }

  public bool devolver(){
    this.emprestado = false;
    return this.emprestado;
  }
}