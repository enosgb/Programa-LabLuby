using System;

public class Bebida
{
	public Bebida() { }

	public string descricao { get; set; }
	public double valor { get; set; }
	public int estoque { get; set; }

	public Bebida(string descricao, double valor, int estoque)
	{
		this.descricao = descricao;
		this.valor = valor;
		this.estoque = estoque;
	}
}