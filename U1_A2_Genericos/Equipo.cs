using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    class Equipo<T> where T : Deportista
    {
        public string Entrenador { get; set; }
        public byte NoIntegrantes { get; set; }
        public string Tipo { get; set; }

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
            Integrantes.Add(nuevoIntegrante);
        }

        public void Eliminar(T integrante)
        {
            Console.WriteLine("Datos eliminados");
            Integrantes.Remove(integrante);
        }


    }
}
