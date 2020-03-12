using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1A2_Genericos
{
    class Predicados
    {
        internal static bool ValidarSexo(Deportista deportista)
        {
            if (deportista.Sexo == "F")
            {
                return true;
            }
            return false;
        }
    }
}
