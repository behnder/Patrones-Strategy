using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Strategy
{
    class CofreComun : ICofre
    {
        public string AbrirCofre()
        {
            return "Se ha abierto un cofre con: \n100 de oro\n2 Tarjetas de habilidad\n3 items de crafteo";
        }

        public string Descripcion()
        {
            return "Este cofre contiene 3 items, su rareza es comun";
        }
    }
}
