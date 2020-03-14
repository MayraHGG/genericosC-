using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    class Basketbolista : Deportista
    {
        public byte PuntosAnotados { get; set; }
        public short NoRebores { get; set; }
        public short NoAsistencias { get; set; }



        public Basketbolista(string noControl, string nom, string apepa, string apema, byte ed, string sex, double est, float pes, byte panot, short rebotes, short asistencias)
        {
            No_Control = noControl;
            Nombre = nom;
            ApePat = apepa;
            ApeMat = apema;
            Edad = ed;
            Sexo = sex;
            Estatura = est;
            Peso = pes;
            PuntosAnotados = panot;
            NoRebores = rebotes;
            NoAsistencias = asistencias;

        }

        public override string ToString()
        {
            return "Basket" + "/" + No_Control + "/" + Nombre + "/" + ApePat + "/" + ApeMat + "/" + Edad + "/" + Sexo + "/" + Estatura + "/" + Peso + "/" + PuntosAnotados + "/" + NoRebores + "/" + NoAsistencias;
            //return this.ToString();
        }
    }
}
