using System;

public class Venda
{
    public Venda() { }

    public int VendaId { get; set; }
    public string VendaItem { get; set; }
    public double VendaValor { get; set; }

    public Venda(int VendaId, string VendaItem, double VendaValor)
    {
        this.VendaId = VendaId;
        this.VendaItem = VendaItem;
        this.VendaValor = VendaValor;
    }
}