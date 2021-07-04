using System;

namespace CalcularPremio
{
    class Program
    {
        public static double CalcularPremio(double ValorPremio, String Tipo,int? Fator)
        {
            //O tipo do fator foi definido como "int?" para que ele receba valores nulos e inteiros
           
            int Mtipo = 0;

            // matriz 5x2 com os tipos de prêmios e seus multiplicadores 
            //Obs: poderia ter sido feito com "switch"
            String[,] premio = { { "basic" , "1"},
                                 { "vip"   , "1,2"},
                                 { "premium", "1,5"},
                                 { "deluxe", "1,8"},
                                 { "special","2"} };

            //loop para verificar qual tipo de premio foi selecionado
            for (int i = 0; i < 5; i++){
                if (Tipo == premio[i, 0]){
                    Mtipo = i;
                }
            }
            //Condição para que o valor do fator seja valido
            if(Fator <= 0){
                //Fator inválido
                Console.WriteLine("Erro Fator invalido");
                return 0;
            }
            //Condição para tratar a possibilidade do Fator ser nulo
            if (Fator != null){
                ValorPremio = ((Convert.ToDouble(premio[Mtipo, 1]) * ValorPremio) * Convert.ToDouble(Fator));
            }else{
                ValorPremio = Convert.ToDouble(premio[Mtipo, 1])* ValorPremio;
            }
            //Condição para que o valor seja positivo ou diferente de zero
            if(ValorPremio > 0){
                Console.WriteLine(ValorPremio.ToString("N2"));
                return ValorPremio;
            }else{
                //valor de prêmio invalido!
                Console.WriteLine("Erro valor de prêmio invalido");
                return 0;
            }

        }

        static void Main(string[] args)
        {
            CalcularPremio(100, "vip", null);
            CalcularPremio(100, "basic", 3);
        }
    }
}
