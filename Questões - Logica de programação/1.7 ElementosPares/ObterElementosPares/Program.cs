using System;
using System.Collections.Generic;

namespace ObterElementosPares
{
    class ElementosPares
    {
        public static int[] ObterElementosPares(int[] Vetor)
        {
            //int[] temp = new int[] { };
            List<int> VetorPar = new List<int>();
            for(int i = 0; i < Vetor.Length; i++) {
                if(Vetor[i] % 2 == 0){
                    VetorPar.Add(Vetor[i]);                    
                }
            }

            int[] Vet = new int[VetorPar.Count];
            
            for(int i = 0; i < Vet.Length; i++){
                Vet[i] = VetorPar[i];
            }
            Console.WriteLine(String.Join(",",Vet));
            return Vet;
        }
        static void Main(string[] args)
        {
            int[] Vetor = new int[] {1,2,3,4,5};
            ObterElementosPares(Vetor); 
        }
    }
}
