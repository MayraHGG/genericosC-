using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    public class Beisbolistas : Deportista
    {
        public float PromBateo { get; set; }
        public int NumHits { get; set; }
        public int NumCarrProd { get; set; }
        public int NumCarrAnot { get; set; }

        public Beisbolistas(string noControl, string nom, string apepa, string apema, byte ed, string sex, double est, float pes, float promB, int numH, int numC, int numCA)
        {
            No_Control = noControl;
            Nombre = nom;
            ApePat = apepa;
            ApeMat = apema;
            Edad = ed;
            Sexo = sex;
            Estatura = est;
            Peso = pes;
            NumHits = numH;
            NumCarrProd = numC;
            NumCarrAnot = numCA;

        }

        public override string ToString()
        {
            return "Beisbolista" + "/" + No_Control + "/" + Nombre + "/" + ApePat + "/" + ApeMat + "/" + Edad + "/" + Sexo + "/" + Estatura + "/" + Peso + "/" + PromBateo + "/" + NumHits + "/" + NumCarrProd + "/" + NumCarrAnot;
            //return this.ToString();
        }
    }
}
