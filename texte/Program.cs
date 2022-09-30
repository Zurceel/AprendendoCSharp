using System;

class Programa
{
	static void Main(string[] args)
	{
		Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

		int idade = 23;
		int idadeGabriel = idade;

		Console.WriteLine(idadeGabriel);

		string parcela_1 = "10";
		string parcela_2 = "20";

		Console.WriteLine(parcela_1 + parcela_2);
		
		Console.WriteLine("Tecle enter para fechar ...");
		Console.ReadLine();
	}
}