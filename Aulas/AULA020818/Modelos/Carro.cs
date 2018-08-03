using System;

namespace AULA020818.Modelos
{
    class Carro : Veiculo, Imotorizado

    {
        public int Velocidade { get; set ; }

        public void Acelerar()
        {
            Console.WriteLine("Pisando no Pedal...");
            Velocidade += 5;               
        }

        public void Frenar()
        {
            Console.WriteLine("Pisando no pedal (freio)...");
            Velocidade -= 3;
        }
    }
}
