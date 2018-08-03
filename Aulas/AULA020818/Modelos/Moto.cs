using System;

namespace AULA020818.Modelos
{
    //Herdando propriedades de Veiculo
    class Moto : Veiculo, Imotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("MOTO: Acelerando pela manopla...");
            Velocidade += 6;
        }

        public void Frenar()
        {
            Console.WriteLine("MOTO: Freando pelo manete...");
            Velocidade -= 1;
        }
    }
}
