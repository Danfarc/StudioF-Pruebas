using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StudioF_Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            List<int> listaNumeros = new List<int>();

            int numeroBuscar = 6;
            int addnumero = 10;

            listaNumeros.Add(5);
            listaNumeros.Add(6);
            listaNumeros.Add(1);
            listaNumeros.Add(2);
            listaNumeros.Add(3);
            listaNumeros.Add(4);
            listaNumeros.Add(5);
            listaNumeros.Add(6);
            PrintValues(listaNumeros);
            OrderValuesMaMe(listaNumeros);
            OrderValuesMeMa(listaNumeros);
            SearchNumero(numeroBuscar,listaNumeros);
            listaNumeros = add(addnumero,listaNumeros);
            PrintValues(listaNumeros);
            addnumero = 15;
            listaNumeros = add(addnumero,listaNumeros);
            PrintValues(listaNumeros);
            listaNumeros.Add(20);
            PrintValues(listaNumeros);
            NumeroRepetido(listaNumeros);

            Console.ReadKey();
        }


        private static void NumeroRepetido(List<int> myList)
        {
            foreach (var item in myList.GroupBy(x => x))
            {
                if(item.Count() > 1)
                Console.WriteLine($"{item.Key} encontrado {item.Count()} veces");
            }
                
        }
        private static List<int> add(int numero, List<int> myList)
        {
            myList.Add(numero);
            return myList;
        }

        private static void SearchNumero(int numeroBuscar, List<int> myList)
        {
            var Number = myList.FirstOrDefault(x => x.Equals(numeroBuscar)).ToString();
            foreach (Object obj in Number)
                Console.Write(" {0}", obj);
            Console.WriteLine();
        }

        public static void PrintValues(List<int> myList)
        {
            foreach (Object obj in myList)
                Console.Write(" {0}", obj);
            Console.WriteLine();
        }

        public static void OrderValuesMaMe(List<int> myList)
        {
            List<int> Numbers = myList.OrderByDescending(x => x).ToList();
            foreach (Object obj in Numbers)
                Console.Write(" {0}", obj);
            Console.WriteLine();

        }
        public static void OrderValuesMeMa(List<int> myList)
        {
            
            List<int> Numbers = myList.OrderBy(x => x).ThenBy(x => x).ToList();
            foreach (Object obj in Numbers)
                Console.Write(" {0}", obj);
            Console.WriteLine();

        }
    }
}
