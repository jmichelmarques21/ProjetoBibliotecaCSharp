UNIVERSIDADE POSITIVO
TÓPICOS ESPECIALS EM DESENVOLVIMENTO DE SOFTWARE
Atividade de Orientação a Objetos em C#
Você foi contratado(a) para desenvolver um sistema de gestão bibliotecas. O sistema deve ser capaz de gerenciar a biblioteca, as estantes e  os livros nela presentes. A seguir, são fornecidas as especificações das classes envolvidas:

 Classe Biblioteca
- Atributos:
  1. Nome: o nome da biblioteca.
  2. Localização: a localização geográfica da biblioteca.

- Métodos:
  1. ExibirInformacoes(): exibe as informações da indústria, incluindo nome, localização e ano de fundação.
  2. AdicionarEstante (estante Estante): adiciona uma estante na biblioteca.

 Classe Estante
- Atributos:
  1. Codigo: o código de localização da estante.
  2. Capacidade: a capacidade de produção da linha (quantidade de produtos por hora).

- Métodos:
  1. ExibirDetalhes(): exibe os detalhes da linha de produção, incluindo número, tipo e capacidade.
  2. AdicionarLivro(livro Livro): adiciona um livro à estante.

 
 Classe Livro
- Atributos:
  1. Id: o identificador do livro.
  2. Título: Título do livro.
  3. Autor: o autor do livro.
  4. Indicativo de que  livro está emprestado ou não

- Métodos:
  1. ExibirInformacoes(): exibe as informações da máquina, incluindo identificador, marca e modelo.
  2. Emprestar(): Altera o indicativo de que o livro está emprestado para verdadeiro.
  3. Devolver(): Altera o indicativo de que o livro está emprestado para false.

 Desafio:
- Implemente as classes conforme as especificações fornecidas.
- Crie duas bibliotecas fictícias com pelo menos duas estantes em cada biblioteca.
- Cada estante deve ter pelo menos três livros diferentes.
- Exiba as informações completas das bibliotecas, estantes e livros.

Ao finalizar a implementação das classes e dos métodos, teste o sistema criando instâncias das classes e chamando os métodos necessários para exibir todas as informações.

