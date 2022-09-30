using System;
using System.Linq.Expressions;

class Programa
{
	static void Main(string[] args)
	{
		Console.WriteLine("Executando o projeto 8 - Condicionais 2");

		int idadeJoao = 16;
		int quantidadePessoas = 1;

		if(idadeJoao >= 18 || quantidadePessoas > 0)
		{
			Console.WriteLine("Entrada liberada");
		}
		else
		{
			Console.WriteLine("Entrada permitida para maiores de 18 anos ou acompanhado por um responsável");
		}
	}
}