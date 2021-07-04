using System;
using System.Collections.Generic;

namespace EFaltantes
{
    class ElementosFaltantes
    {
        public static int[] ObterElementosFaltantes(int[] Vetor1,int[] Vetor2)
        {
            //listas para armazenar vetores 
            List<int> Vet1 = new List<int> { };
            List<int> Vet2 = new List<int> { };
            List<int> ListFaltantes = new List<int> { };

            //passando os dados do vetor para lista
            for(int i = 0; i < Vetor1.Length; i++){
                Vet1.Add(Vetor1[i]);
            }
            //passando os dados do vetor para lista
            for (int i = 0; i < Vetor2.Length; i++){
                Vet2.Add(Vetor2[i]);
            }
            //verificando os dados faltantes em um dos vetores
            for(int i = 0; i < Vet1.Count; i++){
                if (!Vet2.Contains(Vet1[i])){
                    ListFaltantes.Add(Vet1[i]);
                }
            }
            //verificando os dados faltantes em um dos vetores
            for (int i = 0; i < Vet2.Count; i++){
                if (!Vet1.Contains(Vet2[i]))
                {
                    ListFaltantes.Add(Vet2[i]);
                }
            }

            int[] Faltantes = new int[ListFaltantes.Count];
            
            //passando os dados para retornar um novo vetor coms os dados faltantes
            for(int i = 0; i < Faltantes.Length; i++){
                Faltantes[i] = ListFaltantes[i];
            }

            Console.WriteLine(string.Join(" ",Faltantes));

            return Faltantes;
        }
        static void Main(string[] args)
        {
           // faltam elementos no vetor2
            int[] vetor1 = new int[] { 1, 2, 3, 4, 5 };
            int[] vetor2 = new int[] { 1, 2, 5 };
            ObterElementosFaltantes(vetor1, vetor2);
            
            
            // faltam elementos no vetor3
            int[] vetor3 = new int[] { 1, 4, 5 };
            int[] vetor4 = new int[] { 1, 2, 3, 4, 5 };
            ObterElementosFaltantes(vetor3, vetor4);

            
            // faltam elementos em ambos vetores
            int[] vetor5 = new int[] { 1, 2, 3, 4 };
            int[] vetor6 = new int[] { 2, 3, 4, 5 };
            ObterElementosFaltantes(vetor5, vetor6);
            
            // não faltam items
            int[] vetor7 = new int[] { 1, 3, 4, 5 };
            int[] vetor8 = new int[] { 1, 3, 4, 5 };
            ObterElementosFaltantes(vetor7, vetor8);
            
        }
    }
}
