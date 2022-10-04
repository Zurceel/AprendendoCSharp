using System;
class Programa
{
	static void Main(string[] args)
	{
		Console.WriteLine("Desafio for");

		for (int numero = 3; numero < 100; numero++)
		{


			if (numero % 3 == 0)
			{
				Console.Write(numero);
			}

		}
		Console.WriteLine();

		Console.WriteLine("Pressione a tecla Enter para fechar ...");
		Console.ReadLine();
	}
}