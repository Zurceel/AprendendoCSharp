using System;

class Programa
{
	static void Main(string[] args)
	{
		Console.WriteLine("Executando o progeto 5 - Caracteres e textos");

		char letra = 'a';
		Console.WriteLine(letra);

		letra = (char)65;
        Console.WriteLine(letra);

		letra = (char)(65 + 1);
        Console.WriteLine(letra);

		string primeirafrase = "Aula da alura 2022";
		Console.WriteLine(primeirafrase);

		string cursos = @"Cursos disponíveis: 
- Go 
- C# 
-Python 
-Java";
		Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar");
		Console.ReadLine();
	}
}