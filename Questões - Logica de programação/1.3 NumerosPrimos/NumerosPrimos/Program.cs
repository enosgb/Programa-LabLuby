using System;

namespace NumerosPrimos
{
    class Primos
    {

        public static int ContarNumerosPrimos(int num)
        {
            int Contador = 0;
            int Primos = 0; 

            for(int i = 2; i <= num; i++){
                for (int j = 1; j <= i; j++){
                    if (i % j == 0){
                        Contador += 1;
                    }
                }
            if (Contador <= 2){
                    Primos += 1;
            }
            Contador = 0;  
            }
            Console.WriteLine(Primos);
            return Primos;
        }

        static void Main(string[] args)
        {
        ContarNumerosPrimos(10);
        }
    }
}
