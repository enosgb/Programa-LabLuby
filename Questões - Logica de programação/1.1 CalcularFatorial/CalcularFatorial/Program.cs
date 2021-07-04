using System;

namespace CalcularFatorial
{
    class Fatorial
    {
        //Forma recursiva
        public static int CalcularFatorial(int num)
            {
                int Fat = 0;
                
            if(num == 1)
                {
                    Fat = 1;
                }else{
                    Fat = num * CalcularFatorial(num - 1);
                }

            Console.WriteLine(Fat);
            return Fat;
            }

        public static void Main(string[] args)
        {
            CalcularFatorial(5);
        }
    }
}
