using System;

public class Bebida
{
	public Bebida() { }

	public string Descricao { get; set; }
	public double Valor { get; set; }
	public int Estoque { get; set; }

	public Bebida(string descricao, double valor, int estoque)
	{
		this.Descricao = descricao;
		this.Valor = valor;
		this.Estoque = estoque;
	}
}