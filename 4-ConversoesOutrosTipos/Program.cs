using System;
class Programa
{
	static void Main(string[] args)
	{

		double salario = 3000.61;
		Console.WriteLine("Meu salário é " + salario);

		int salarioInteiro = (int)salario;
		Console.WriteLine("Meu salário inteiro é " + salarioInteiro);

		long x = 3412012012910000000;
		Console.WriteLine("Quanto eu queria ter na conta " + x);

		float peso = 100.72f;
		Console.WriteLine("Meu peso é " + peso);

		Console.WriteLine("Pressione a tecla Enter para fechar ...");
		Console.ReadLine();
	}
}