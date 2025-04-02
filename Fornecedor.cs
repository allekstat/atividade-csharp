class Fornecedor : Pessoa
{
 public string cnpj;
 public string razaosocial;

 public void criaFornecesor(string nome, string cnpj)
 {
  this.nome = nome;
  this.cnpj = cnpj;
 }
}