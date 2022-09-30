using System;

class Programa
{
	static void Main(string[] args)
	{
		Console.WriteLine("Executando projeto 7 - Condicionais");

		int idadeJoao = 16;
		int quantidadePessoas = 0;

		if (idadeJoao >= 18)
		{
			Console.WriteLine("Entrada liberada!");
		}
		else
		{
			if (quantidadePessoas >= 1)
			{
				Console.WriteLine("Ele está acompanhado. Entrada Liberada!");
			}
			else
			{
				Console.WriteLine("Entrada permitida apenas para maiores de 18 anos. Ou acompanhado por um maior");
			}
		}

	}
}