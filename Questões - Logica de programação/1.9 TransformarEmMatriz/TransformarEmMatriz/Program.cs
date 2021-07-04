using System;
using System.Collections.Generic;


namespace TMatriz
{
    class Matriz
    {
        public static void TransformarEmMatriz(String Numeros)
        {
            //remove a virgula e adiciona em lista<integer>
            List<int> Num = new List<int> { };
            for(int i = 0; i < Numeros.Length; i++){
                if (Numeros.Substring(i,1) != ",")
                {
                    Num.Add(Convert.ToInt32(Numeros.Substring(i, 1)));
                }
            }

            int[,] Matriz = new int[Num.Count/2,2];

            int cont = 0;

            //loop para adicionar os números na matriz
            for(int i = 0;i < Num.Count/2; i++){
                for (int j = 0; j < 2; j++){
                    Matriz[i,j] = Num[cont];
                    if(cont < Num.Count) cont += 1;
                }
            }

            //loop para imprimir a matriz

            for (int i = 0; i < Matriz.Length/2; i++)
            {
                
                for (int j = 0; j < 2; j++){
                    int a = i + 1;
                    if(a < (Matriz.Length/2)) Console.WriteLine(string.Join("","{",Matriz[i, j]," , ",Matriz[a,j],"}"));
                }
            }

        }
        static void Main(string[] args)
        {
 
            TransformarEmMatriz("1,2,3,4,5,6");

        }
    }
}
