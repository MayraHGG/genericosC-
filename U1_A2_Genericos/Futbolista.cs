using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    class Futbolista  : Deportista
    {
        public string Posicion { get; set; }
        public short NoGolesAnotados { get; set; }
        public byte NoTarjeAmarillas { get; set; }
        public byte NoTarjRojas { get; set; }

        public Futbolista(string noControl, string nom, string apepa, string apema, byte ed, string sex, double est, float pes, string pos, short golanotados, byte taramarillas, byte tarrojas)
        {
            No_Control = noControl;
            Nombre = nom;
            ApePat = apepa;
            ApeMat = apema;
            Edad = ed;
            Sexo = sex;
            Estatura = est;
            Peso = pes;
            Posicion = pos;
            NoGolesAnotados = golanotados;
            NoTarjeAmarillas = taramarillas;
            NoTarjRojas = tarrojas;

        }
        public override string ToString()
        {
            return "Fut"+"/"  + No_Control + "/" + Nombre + "/" + ApePat + "/" + ApeMat + "/" + Sexo + "/" + Edad + "/" + Estatura + "/" + Peso + "/" + Posicion + "/" + NoGolesAnotados + "/" + NoTarjeAmarillas + "/" + NoTarjRojas;
            //return this.ToString();
        }

    }
}
