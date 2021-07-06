using System;
using System.Linq;
using System.Collections.Generic;
public sealed class Variaveis_Globais
{

    private static volatile Variaveis_Globais instance;
    private static object sync = new Object();

    private Variaveis_Globais() { }

    public static Variaveis_Globais Instance
    {
        get
        {
            if (instance == null)
            {
                lock (sync)
                {
                    if (instance == null)
                    {
                        instance = new Variaveis_Globais();
                    }
                }
            }
            return instance;
        }

    }

    public List<Venda> ListaVendas {get;set;}

}