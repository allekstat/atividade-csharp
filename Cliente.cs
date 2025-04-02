public class Cliente : Pessoa
{
	public string cpf;
	public string rg;

	public void criaCliente(string cpf, string nome)
	{
		this.cpf = cpf;
		this.nome = nome;
	}
}