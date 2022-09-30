using System;

class Programa
{
	static void Main(string[] args)
	{
		Console.WriteLine("Executando o projeto 9 - Escopo");

		int idadeJoao = 16;
		int quantidadePessoas = 0;

		bool acompanhado = quantidadePessoas > 0;

		string textoAdicional;

		if (acompanhado == true)
		{
			textoAdicional = "João está acompanhando";
		}
		else
		{
			textoAdicional = "João não está acompanhando";
		}

		if (idadeJoao >= 18 || acompanhado)
		{
			Console.WriteLine(textoAdicional);
			Console.WriteLine("Entrada liberada!");
		}
		else
		{
			Console.WriteLine(textoAdicional);
			Console.WriteLine("Entrada permitida para maiores de 18 anos ou acompanhado por um responsável");
		}
	}
}