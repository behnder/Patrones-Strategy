using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Strategy
{
    class CofreEpico : ICofre
    {
        public string AbrirCofre()
        {
            return 
                "Se ha abierto un cofre con: \n1500 de oro\n6 Tarjetas de habilidad\n8 items de crafteo" +
                "\n3 Booster de exp x1h\n1 Skin Halloween + 1 Skin Navidad" +
                "\n1 Mascota Rana\n1 Saludo personalizado temp 1";
        }

        public string Descripcion()
        {
            return "Este cofre contiene 7 items, su rareza es Epica";
        }
    }
}
