using System;

	class Juros
	{
		static void Main ()
		{
			//em ordem: periodo, variavel para loop
			int t, n; 

			/*em ordem: Capital, Montante, taxa de juros, Juros, 
			variavel para calculo do juros aos mês*/
			double C, M, i, J, j_m;
			
			for (int r = 0; r < 81; r++) { Console.Write("═"); r++; }

			Console.WriteLine ("\n══════ CAULCULANDO JUROS COMPOSTOS ══════");

			for (int r = 0; r < 81; r++) { Console.Write("═"); r++; }
			
			Console.WriteLine ("\nInforme o capital inicial: ");
				C = Convert.ToDouble (Console.ReadLine ());

			Console.WriteLine ("Informe o período (meses) da aplicação: ");
				t = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Informe a taxa fixa de juros a.m. (%): ");
				i = Convert.ToDouble (Console.ReadLine ());
			
			for (int r = 0; r < 80; r++) { Console.Write("═"); r++; }

			M = C * Math.Pow ((1 + (i / 100)), t); //calculo juros composto
			J = M - C; //calculo juros total
				
			n = 0; 
			while (n <= t) 
			{
				j_m = (i / 100) * C; //calculo do valor do juros p/ mês

					if ( n == 0){
						Console.WriteLine("\nCapital inicial: R$" + Math.Round(C,2) + "\n");
					}else{
						Console.WriteLine("Juros no mês " + n + ": R$" + Math.Round(C,2));
					}
				C = j_m + C; //calculo do capital p/ mês
				n++;
			}
			
			Console.WriteLine ("\nMontante final: R$" + Math.Round(M,2) + "\nJuros totais: R$" + Math.Round(J,2));
			for (int r = 0; r < 80; r++) { Console.Write("═"); r++; }
		}
	
	}
