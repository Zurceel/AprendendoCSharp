using System;

class Programa
{
	static void Main(string[] args)
	{
		Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

		double investimento = 1000;

		// rendimento de 0.5% (0.005) ao mês

		//investimento = investimento + investimento * 0.005;
		////////Console.WriteLine(investimento);

		int mes = 1;

		while (mes <= 12)
		{
			investimento = investimento + investimento * 0.005;
			Console.WriteLine("No mes " + mes + " você tem " + investimento);

			mes++;
		}

		Console.WriteLine("Clique na telca enter para fechar ...");
		Console.ReadLine();
	}
}