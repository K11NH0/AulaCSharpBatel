using System;

namespace Aula3107_ConsoleApp1
{
    class Program
    {

        public static int Num1 { get; set; }
        public static int Num2 { get; set; }

        static void Main(string[] args)
        {

                       

            Console.WriteLine("Digite um Numero: ");
             Num1 = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("Digite o 2 numero: ");
            Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma entre os dois numeros é: ");
            Console.WriteLine(Num1 + Num2);

            Console.WriteLine("A subtração entre os dois numeros é: ");
            Console.WriteLine(Num1 - Num2);

            Console.WriteLine("A multiplicação entre os dois numeros é: ");
            Console.WriteLine(Num1 * Num2);


            Console.WriteLine("A divisão entre os dois numeros é: ");
            Console.WriteLine(Num1 / Num2);


            Console.ReadKey();

            
        }

       

    }
}
