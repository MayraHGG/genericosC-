using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    class Predicados
    {
        internal static bool ValidarSexo(Deportista deportista)
        {
            if(deportista.Sexo == "Femenino")
            {
                return true;
                
            }
            return false;
        }


        internal static bool ValidarEquipo(Equipo<Deportista> deportista, Deportista dep)
        {

            return deportista.Tipo == dep.Sexo;


        }


        //
        //if ((deportista.Tipo=="Varonil") && (dep.Sexo=="M"))
        //{
        //    return true;
        //}
        //return false;
        //public static bool NoMaxIntegrantes(Equipo<Deportista> e)
        //{
        //    return e.Integrantes.Count < e.NoIntegrantes;
        //}
    }
}
