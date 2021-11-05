using System;

namespace Patrones_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador();
            jugador.Cofre = new CofreComun();
            jugador.Selector = new SelectorDeCofre();

            jugador.MostrarCofre();

            Console.ReadKey();
        }
    }
}
