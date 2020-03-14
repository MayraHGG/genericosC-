using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    class Voleibolista: Deportista
    {
        public int NumBloqueos { get; set; }
        public int PuntAnotados { get; set; }
        public int NumSalvadas { get; set; }

        public Voleibolista(string noControl, string nom, string apepa, string apema, byte ed, string sex, double est, float pes, int numBlo, int punAn, int numSal)
        {
            No_Control = noControl;
            Nombre = nom;
            ApePat = apepa;
            ApeMat = apema;
            Edad = ed;
            Sexo = sex;
            Estatura = est;
            Peso = pes;
            NumBloqueos = numBlo;
            PuntAnotados = punAn;
            NumSalvadas = numSal;

        }

        public override string ToString()
        {
            return "Voleibolista" + "/" + No_Control + "/" + Nombre + "/" + ApePat + "/" + ApeMat + "/" + Edad + "/" + Sexo + "/" + Estatura + "/" + Peso + "/" + NumBloqueos + "/" + PuntAnotados + "/" + NumSalvadas;
            //return this.ToString();
        }
    }
}
