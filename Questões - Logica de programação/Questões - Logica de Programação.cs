		
		//1.1 Implemente a função abaixo para calcular fatorial de um número.
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
		#################################################################################################################
		#################################################################################################################
		#################################################################################################################
		//1.2 Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme
		
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
		##############################################################################################################
		##############################################################################################################
		//1.3 Implemente a função abaixo para contar quantos números primos existe até o número informado.
		
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
		#################################################################################################################
		#################################################################################################################
		//1.4 Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string
		 
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
		#########################################################################################################################
		#########################################################################################################################
		//1.5 Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
		
		public static String CalcularValorComDescontoFormatado(String Valor,String Desconto)
        {
            Valor = Valor.Remove(0, 3);
            Desconto = Desconto.Remove(Desconto.Length - 1);
            double PorcentagemDesconto = Convert.ToDouble(Desconto)/100;
            double Total = Convert.ToDouble(Valor)-(Convert.ToDouble(Valor) * PorcentagemDesconto);
            String ValorComDesconto = Total.ToString("C");
            Console.WriteLine(ValorComDesconto);
            return ValorComDesconto;
        }
		##########################################################################################################################
		##########################################################################################################################
		//1.6 Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas.
		
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
		##############################################################################################################################
		##############################################################################################################################
		//1.7 Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado.
		
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
		
		################################################################################################################################
		################################################################################################################################
		
		//1.8 Implemente a função abaixo que deve buscar um ou mais elementos no vetor que contém o valor ou parte do valor informado na busca.
		
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
		
		################################################################################################################################
		################################################################################################################################
		//1.9 Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um array de array de 
		//inteiros com no máximo dois elementos.
		
		        public static void TransformarEmMatriz(String Numeros)
        {
            //remove a virgula e adiciona em lista<int>
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
		#################################################################################################################################
		#################################################################################################################################
		
		//1.10 Implemente a função abaixo que compara dois vetores e cria um novo vetor com os elementos faltantes de ambos.
		
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
            
            //passando os dados para retornar um novo vetor com os dados faltantes
            for(int i = 0; i < Faltantes.Length; i++){
                Faltantes[i] = ListFaltantes[i];
            }

            Console.WriteLine(string.Join(" ",Faltantes));

            return Faltantes;
        }
		