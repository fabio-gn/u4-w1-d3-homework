using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conto_corrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto1 = new ContoCorrente("Fabio Giannasi");
            conto1.ApriConto();
            Console.WriteLine("hai " + conto1.Saldo + " euro");
            conto1.Prelievo();
            Console.WriteLine("hai " + conto1.Saldo + " euro");
            conto1.Versamento();
            Console.WriteLine("hai " + conto1.Saldo + " euro");
            Console.ReadLine();
            
        }
    }
}
