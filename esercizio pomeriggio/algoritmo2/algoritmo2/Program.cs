using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace algoritmo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input x lunghezza array
            Console.WriteLine("quanti numeri servono?");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arrayNumeri = new int[num];

            //ciclo che chiede tanti input quanto è lunga l'array
            for(int i = 0; i < arrayNumeri.Length; i++) 
            {
                Console.WriteLine($"{i+1}° numero:");
                int newNum = Convert.ToInt32(Console.ReadLine());
                arrayNumeri[i] = newNum;
            }

            //somma di tutti i valori inseriti nell'array
            int sum = 0;
            for(int i = 0;i < arrayNumeri.Length; i++)  
            {
                sum += arrayNumeri[i];
            }
            Console.WriteLine($"La somma di tutti i numeri è: {sum}");

            //media aritmetica di tutti i valori inseriti nell'array
            int media = sum / arrayNumeri.Length;
            Console.WriteLine($"La media di tutti i numeri è: {media}");

            Console.ReadLine();
        }
    }
}
