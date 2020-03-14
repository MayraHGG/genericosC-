using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    class Equipo<T> where T : Deportista
    {
        public static string MASCULINO = "Masculino";
        public static string FEMENINO = "Femenino";
        public static string MIXTO = "Mixto";

        public string Entrenador { get; set; }
        public byte NoIntegrantes { get; set; }
        public string Tipo {
            get;
            set{
                string [] valoresPermitidos = [Deportista.MASCULINO, Deportista.FEMENINO, Deportista.MIXTO];
                boolean tipoNoEsUnValorPermitido = !valoresPermitidos.Contains(value);
                if(tipoNoEsUnValorPermitido){
                    throw new ArgumentException(value + " no es un valor permitido para tipo");
                }
                return value;
            }
        }

        public List<T> Integrantes = new List<T>();
        public T[] Miembros { get; set; }

        public Equipo(int maxIntegrantes)
        {
            Miembros = new T[maxIntegrantes];
        }

        public Equipo(string entrenador, byte integrante, string tipo)
        {
            Entrenador = entrenador;
            NoIntegrantes = integrante;
            Tipo = tipo;
        }



        private class Node
        {

            public Node(T t)
            {
                next = null;
                data = t;
            }

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }


            private T data;


            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node integrante;

        public Equipo()
        {
            integrante = null;
        }

        //public void AgregarIntegrante(T input)
        //{
        //    Node n = new Node(input);
        //    n.Next = integrante;
        //    integrante = n;
        //}


        ////eliminar integrante
        //public void Eliminar(T output)
        //{

        //    Node n = new Node(output);
        //    n.Next = integrante;
        //    n = null;
        //    Console.WriteLine("integrante eliminado");


        //}

        public IEnumerator<T> GetEnumerator()
        {
            Node current = integrante;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


        public void AgregarIntegrante(T nuevoIntegrante)
        {
            if(this.SePermiteCualquierSexo()){
                Integrantes.Add(nuevoIntegrante);
                return;
            }
            else if(this.PerteneceAEsteEquipoPorSexo(nuevoIntegrante.Sexo)){
                Integrantes.Add(nuevoIntegrante);
                return;
            }
            throw new ArgumentException("el deportista no puede estar en este equipo");
        }

        public void Eliminar(T integrante)
        {
            Console.WriteLine("Datos eliminados");
            Integrantes.Remove(integrante);
        }


        // puse esto de region para que veas donde añadí el código
        // bórralo junto con esto comentarios
        // con el tiempo usar región sólo molesta a la vista
        #region predicados
        private boolean PerteneceAEsteEquipoPorSexo(sexo){
            return this.Tipo == sexo;
        }

        private boolean SePermiteCualquierSexo(){
            return this.Tipo == Equipo.MIXTO;
        }
        #endregion


    }
}
