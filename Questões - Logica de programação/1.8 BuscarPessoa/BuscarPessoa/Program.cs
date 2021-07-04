using System;

namespace BuscarPessoas
{
    class Bpessoas
    {
        public static void BuscarPessoa(string[] Vetor,String Parametro)
        {
           
            foreach(String Nomes in Vetor)
            {
                if (Nomes.Contains(Parametro))
                {
                    Console.Write("[{0}] ",Nomes);
                }
            }
        }
        static void Main(string[] args)
        {
            string[] Vetor = new string[] {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero"
                };
            
            BuscarPessoa(Vetor, "Doe");
            BuscarPessoa(Vetor, "Alice");
            BuscarPessoa(Vetor, "James");
        }
    }
}
