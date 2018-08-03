using AULA020818.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA020818
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            car.Modelo = "Ferrari";
            car.Acelerar();


            ExecutaTesteMotor(car);
            Console.ReadKey();

        }
        
        static void ExecutaTesteMotor (Imotorizado vec)
        {
            Console.WriteLine("Velocidade Atual: " + vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Velocidade Atual: " + vec.Velocidade);
            vec.Frenar();
            Console.WriteLine("Velocidade Atual: " + vec.Velocidade);
        }
    }
}
