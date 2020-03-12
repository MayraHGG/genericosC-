using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1A2_Genericos
{
    class Equipo<T> : IEnumerable, IEnumerator where T : Deportista
    {

        public string Entrenador { get; set; }
        public byte NoIntegrantes { get; set; }
        public string Tipo { get; set; }

        public object Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        List<T> Integrantes;

        public Equipo(string entrenador, byte integrante, string tipo)
        {
            Entrenador = entrenador;
            NoIntegrantes = integrante;
            Tipo = tipo;
        }
        public void AgregarIntegrante(T nuevoIntegrante)
        {
            Integrantes.Add(nuevoIntegrante);
        }
        public void EliminarElmento(T integrante)
        {
            Integrantes.Remove(integrante);
        }

       
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
