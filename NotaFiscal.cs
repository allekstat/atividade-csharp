class NotaFiscal
{
 public double numero;
 public Fornecedor fornecedor;
 public Produto produto;

 public void criaNotaFiscal(Cliente cliente, Fornecedor fornecedor)
 {
  this.fornecedor = fornecedor;
 }
 public void adicionaProduto(Produto produto)
 {
  this.produto = produto;
 }
}