using System;

namespace ValorComDescontoFormatado
{
    class VlrComDesconto
    {
        public static String CalcularValorComDescontoFormatado(String Valor,String Desconto)
        {
            Valor = Valor.Remove(0, 3);
            Desconto = Desconto.Remove(Desconto.Length - 1);
            double PorcentagemDesconto = Convert.ToDouble(Desconto)/100;
            double Total = Convert.ToDouble(Valor)-(Convert.ToDouble(Valor) * PorcentagemDesconto);
            String ValorComDesconto = Total.ToString("C");
            Console.WriteLine(ValorComDesconto);
            return ValorComDesconto;
        }
        static void Main(string[] args)
        {

            CalcularValorComDescontoFormatado("R$ 6.800,00", "30%");   
        }
    }
}
