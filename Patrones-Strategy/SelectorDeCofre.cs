using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Strategy
{
     class SelectorDeCofre
    {
        public ICofre Cofre { get; private set; }

        public void ElgirCofre(ICofre cofre)
        {
            Cofre = cofre;
        }

        public void MostrarContenido()
        {
            Console.WriteLine(Cofre.Descripcion());
            Console.WriteLine(Cofre.AbrirCofre());
        }

    }
}
