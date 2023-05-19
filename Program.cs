using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolbinarioconsola
{
    public class Nodo
    {
        public int valor;
        public Nodo izquierdo;
        public Nodo derecho;
    }

    public class Arbol
    {
        public Nodo raiz;

        public void Agregar(int valor)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.valor = valor;

            if (raiz == null)
            {
                raiz = nuevoNodo;
            }
            else
            {
                AgregarRecursivo(raiz, nuevoNodo);
            }
        }

        private void AgregarRecursivo(Nodo actual, Nodo nuevoNodo)
        {
            if (nuevoNodo.valor < actual.valor)
            {
                if (actual.izquierdo == null)
                {
                    actual.izquierdo = nuevoNodo;
                }
                else
                {
                    AgregarRecursivo(actual.izquierdo, nuevoNodo);
                }
            }
            else
            {
                if (actual.derecho == null)
                {
                    actual.derecho = nuevoNodo;
                }
                else
                {
                    AgregarRecursivo(actual.derecho, nuevoNodo);
                }
            }
        }

        public void Inorden(Nodo actual)
        {
            if (actual != null)
            {
                Inorden(actual.izquierdo);
                Console.Write(actual.valor + " ");
                Inorden(actual.derecho);
            }
        }

        public void Preorden(Nodo actual)
        {
            if (actual != null)
            {
                Console.Write(actual.valor + " ");
                Preorden(actual.izquierdo);
                Preorden(actual.derecho);
            }
        }

        public void Postorden(Nodo actual)
        {
            if (actual != null)
            {
                Postorden(actual.izquierdo);
                Postorden(actual.derecho);
                Console.Write(actual.valor + " ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            arbol.Agregar(50);
            arbol.Agregar(30);
            arbol.Agregar(70);
            arbol.Agregar(20);
            arbol.Agregar(40);
            arbol.Agregar(60);
            arbol.Agregar(80);
            arbol.Agregar(90);
            arbol.Agregar(65);
            arbol.Agregar(48);


            Console.WriteLine("Recorrido en orden inorden:");
            arbol.Inorden(arbol.raiz);
            Console.WriteLine();

            Console.WriteLine("Recorrido en orden preorden:");
            arbol.Preorden(arbol.raiz);
            Console.WriteLine();

            Console.WriteLine("Recorrido en orden postorden:");
            arbol.Postorden(arbol.raiz);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}