using System;
namespace Operaciones
{
	class Program
	{
        public static void Oper(){
            int N1, N2, R1, R2;
            Console.WriteLine("Este programa Realiza la Suma y Resta de dos numeros que acontinuacion colocaras");
            Console.WriteLine("Ingresa Primer Valor");
            N1=int.Parse(Console.ReadLine();
            Console.WriteLine("Ingresa Segundo Valor");
            N2=int.Parse(Console.ReadLine();
            R1=N1+N2;
            R2=N1-N2;
            Console.WriteLine("El Resultado de la Suma es: "+R1);
            Console.WriteLine("El Resultado de la Resta es: "+R2);
			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
        
        
        }


		public static void Main(string[] args)
		{
            Oper();
		}
	}
}