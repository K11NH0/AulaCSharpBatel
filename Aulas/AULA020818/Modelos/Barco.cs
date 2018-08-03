using System;

namespace AULA020818.Modelos
{
    class Barco : Veiculo, Imotorizado
    {
        public int Velocidade { get ; set ; }

        public void Acelerar()           
        {
            Console.WriteLine("BARCO: Acelerando pela alavanca...");
        }

        public void Frenar()
        {
            Console.WriteLine("BARCO: Freando pela Alavanca...");
        }
    }
}
