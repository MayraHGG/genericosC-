using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    public class Deportista
    {
        public string No_Control { get; set; }
        public string Nombre { get; set; }
        public string ApePat { get; set; }
        public string ApeMat { get; set; }
        public byte Edad { get; set; }
        public string Sexo { get; set; }
        public double Estatura { get; set; }
        public float Peso { get; set; }

        //public Deportista(string noControl, string nom, string apepa, string apema, byte ed, string sex, double est, float pes)
        //{
        //    No_Control = noControl;
        //    Nombre = nom;
        //    ApePat = apepa;
        //    ApeMat = apema;
        //    Edad = ed;
        //    Sexo = sex;
        //    Estatura = est;
        //    Peso = pes;

        //}
        //public override string ToString()
        //{
        //    return No_Control + "\t" + Nombre + "\t" + ApePat + "\t" + "\t" + ApeMat + "\t" + Edad + "\t" + Sexo + "\t" + Estatura + "\t" + Peso;
        //    //return this.ToString();
        //}




    }
}
