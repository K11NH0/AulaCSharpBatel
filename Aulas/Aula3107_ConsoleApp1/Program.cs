using System;

namespace Aula3107_ConsoleApp1
{
    class Program
    {

        public static int Id { get; set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello WOrld!");
            

            Console.WriteLine("Digite um Numero: ");
             Id = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("A Id que você digitou foi: " + Id);

            Console.ReadKey();





        }
    }
}
