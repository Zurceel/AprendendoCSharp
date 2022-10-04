﻿using System;

class Programa
{
	static void Main(string[] args)
	{
		Console.WriteLine("Executando o projeto 13 - Encadeando For");

		//for com Break
		for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
		{
			for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
			{
				Console.Write("*");
				if (contadorColunas >= contadorLinhas)
					break;
			}
			Console.WriteLine();
		}

		// for sem Break
		for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
		{
			for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}


		Console.WriteLine("Tecle enter para fehcar");
		Console.ReadLine();
	}
}