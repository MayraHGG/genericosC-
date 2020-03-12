using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1A2_Genericos
{
    class Futbolista : Deportista
    {
        public string Posicion { get; set; }
        public short GolesAnotados { get; set; }
        public byte TAmarillas { get; set; }
        public byte TRojas { get; set; }
    }
}
