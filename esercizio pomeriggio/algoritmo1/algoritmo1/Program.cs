using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanto vuoi che sia lunga la lista di nomi?");
            int dimensioneArray = Convert.ToInt32( Console.ReadLine());
            string[] arrayNomi = new string[dimensioneArray];
            for(int i = 0; i < dimensioneArray; i++)
            {
                Console.WriteLine($"{i+1}° nome ");
                string nome = Console.ReadLine();
                arrayNomi[i] = nome;


            }

            Console.WriteLine("cerca un nome, ti diremo se è presente nella lista: ");
            string nomeCercato = Console.ReadLine();
            bool trovato = false;

            for(int i = 0;i < arrayNomi.Length; i++)
            {
                if (nomeCercato.Equals(arrayNomi[i]))
                {
                    Console.WriteLine($"{nomeCercato} è presente!");
                    trovato = true;
                }
                
            }
            if(!trovato)
            {
                Console.WriteLine($"{nomeCercato} non è presente nella lista");
            }
            Console.ReadLine();
        
        }

    }
}
