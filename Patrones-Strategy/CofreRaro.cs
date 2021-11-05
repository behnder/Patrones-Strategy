using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Strategy
{
    class CofreRaro : ICofre
    {
        public string AbrirCofre()
        {
            return "Se ha abierto un cofre con: \n580 de oro\n3 Tarjetas de habilidad\n5 items de crafteo\n1 Booster de exp x1h\n1 Skin Halloween";
        }

        public string Descripcion()
        {
            return "Este cofre contiene 5 items, su rareza es Rara";
        }
    }
}
