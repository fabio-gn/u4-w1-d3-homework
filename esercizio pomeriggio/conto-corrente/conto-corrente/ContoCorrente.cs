using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conto_corrente
{
    internal class ContoCorrente
    {
        private double _saldo;
        public double Saldo
        {
            get
            {
                if(this.IsAperto)
                {
                    return this._saldo;
                }
                else 
                { 
                    Console.WriteLine("non puoi avere un saldo in un conto chiuso");
                    return 0;
                }
            }
            set 
            {
                if (this.IsAperto)
                {
                    this._saldo = value;
                }
                else
                {
                    Console.WriteLine("non puoi versare denaro in un conto chiuso");
                }
               
                 
            }
        }
        public string Intestatario { get; set; }

        private bool IsAperto = false;

        public void ApriConto()
        {
            Console.WriteLine("Per aprire il conto devi versare del denaro, almeno 1000 euro. \r\n" +
                "quanto desideri versare?");
            double valoreiniziale = Convert.ToDouble(Console.ReadLine());
            if(valoreiniziale >= 1000)
            {
                this.IsAperto = true;
                this.Saldo = valoreiniziale;
            }
            else
            {
                Console.WriteLine("ci dispiace ma non è abbastanza per aprire un conto, arrivederci.");
                
            }
        }
        public void Versamento()
        {
            if (this.IsAperto)
            {
                Console.WriteLine("quanto desideri versare?");
                string soldi = Console.ReadLine();
                this.Saldo += Convert.ToDouble(soldi);
                Console.WriteLine($"adesso hai {this.Saldo} euro");
            }
            else
            {
                Console.WriteLine("errore");
            }
            
        }
        public void Prelievo()
        {
            if (this.IsAperto)
            {
                Console.WriteLine("quanto desideri prelevare?");
                string soldi = Console.ReadLine();
                if (this.Saldo >= Convert.ToDouble(soldi))
                {
                    this.Saldo -= Convert.ToDouble(soldi);
                    Console.WriteLine($"hai prelevato: {Convert.ToDouble(soldi)}");
                }
                else
                {
                    Console.WriteLine("non hai abbastanza denaro");
                }
            }
            else
            {
                Console.WriteLine("non hai ancora aperto il conto.");
            }
            
        }
        public ContoCorrente(string intestatario)
        {
            this.Intestatario = intestatario;
            
        }

    }
}
