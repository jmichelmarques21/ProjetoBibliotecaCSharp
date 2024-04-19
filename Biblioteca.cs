public class Biblioteca {
  public string nome {get; set;}
  public string localizacao {get; set;}

  public List<Estante> estante = new List<Estante>();

  public string exibirInformacoes(){
    return this.nome + " " + this.localizacao;
  }

  public void adicionarEstante(Estante estante){
    this.estante.Add(estante);
  }
}