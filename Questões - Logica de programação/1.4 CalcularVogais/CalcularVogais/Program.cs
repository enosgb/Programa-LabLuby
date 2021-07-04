using System;

namespace CalcularVogais
{
    class Vogais
    {

        public static int CalcularVogais(String palavra)
        {
            int contador = 0;
            foreach(char v in palavra)
            {
                switch(v)
                {
                    case 'a': case 'A':
                    contador += 1;
                    break;

                    case 'e': case 'E':
                    contador += 1;
                    break;

                    case 'i': case 'I':
                    contador += 1;
                    break;

                    case 'o': case 'O':
                    contador += 1;
                    break;

                    case 'u': case 'U':
                        contador += 1;
                    break;
                }
            }
            Console.Write(contador);
            return contador;
        }
        static void Main(string[] args)
        {
            CalcularVogais("Luby Software");
        }
    }
}
