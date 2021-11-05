using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Strategy
{
    class Jugador
    {
        public SelectorDeCofre Selector { get; set; }
        public ICofre Cofre { get; set; }

        public void MostrarCofre()
        {

            Selector.ElgirCofre(Cofre);
            Selector.MostrarContenido();
        }






    }
}
