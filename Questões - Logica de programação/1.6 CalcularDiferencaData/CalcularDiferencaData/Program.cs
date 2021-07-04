using System;

namespace CalcularDiferencaData
{
    class DiferencaData
    {
        public static int CalcularDiferencaData(String Data1,String Data2)
        {
            int anos = (Convert.ToInt32(Data2.Substring(4, 4)) - Convert.ToInt32(Data1.Substring(4, 4)))*365;
            int meses = (Convert.ToInt32(Data2.Substring(2, 2)) - Convert.ToInt32(Data1.Substring(2, 2)))*30;
            int dias = Convert.ToInt32(Data2.Substring(0, 2))- Convert.ToInt32(Data1.Substring(0, 2));
            dias = anos + meses + dias;

            if(dias < 0){
                dias = dias * -1;
            }
            Console.WriteLine(dias);
            return dias;
        }
        static void Main(string[] args)
        {

            CalcularDiferencaData("10122020", "25122020"); 
        }
    }
}
