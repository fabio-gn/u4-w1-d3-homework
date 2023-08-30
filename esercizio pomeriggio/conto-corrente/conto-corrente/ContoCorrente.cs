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

        static public void Inizializza()
        {
            Console.WriteLine("A chi deve essere intestato il conto?");
                string nomeIntestatario = Console.ReadLine();
            ContoCorrente conto1 = new ContoCorrente(nomeIntestatario);
            conto1.PrintMenu(nomeIntestatario);
            conto1.Menu();
        }

        private void PrintMenu(string nome)
        {
            Console.WriteLine(
                "------------------------------------------ \r\n" +
                "------------------------------------------ \r\n" +
                $"CONTO CORRENTE DI {nome.ToUpperInvariant()}\r\n" +
                "------------------------------------------ \r\n" +
                "------------------------------------------ \r\n" +
                "1) Apri un conto\r\n" +
                "2) Fai un versamento\r\n" +
                "3) Preleva denaro\r\n" +
                "4) Verifica saldo \r\n" +
                "5) Torna al menù \r\n \r\n" +
                "****************************************** \r\n");


        }

        public void Menu()
        {
            
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice < 1 || choice > 5)
            {
                Console.WriteLine("scelta non valida.");
                Menu();
            }
            else if (choice == 1)
            {
                ApriConto();
            }
            else if (choice == 2)
            {
                Versamento();
            }
            else if (choice == 3)
            {
                Prelievo();
            }
            else if(choice == 4)
            {
                Console.WriteLine($"hai {this.Saldo} euro sul conto.");
                Menu();
            }
            else if( choice == 5)
            {
                Console.Clear();
                PrintMenu(this.Intestatario);
                Menu();
            }


        }

        private void ApriConto()
        {
            Console.WriteLine("Per aprire il conto devi versare del denaro, almeno 1000 euro. \r\n" +
                "quanto desideri versare?");
            double valoreiniziale = Convert.ToDouble(Console.ReadLine());
            if(valoreiniziale >= 1000)
            {
                this.IsAperto = true;
                this.Saldo = valoreiniziale;
                Console.WriteLine($"Complimenti {this.Intestatario}, hai appena aperto il tuo conto! \r\n " +
                    $"cosa vuoi fare adesso?");
                Menu();
            }
            else
            {
                Console.WriteLine("ci dispiace ma non è abbastanza per aprire un conto, arrivederci.");
                Menu();
                
            }
        }
        private void Versamento()
        {
            if (this.IsAperto)
            {
                Console.WriteLine("quanto desideri versare?");
                string soldi = Console.ReadLine();
                this.Saldo += Convert.ToDouble(soldi);
                Console.WriteLine($"adesso hai {this.Saldo} euro");
                Menu();
            }
            else
            {
                Console.WriteLine("errore");
                Menu();
            }
            
        }
        private void Prelievo()
        {
            if (this.IsAperto)
            {
                Console.WriteLine("quanto desideri prelevare?");
                string soldi = Console.ReadLine();
                if (this.Saldo >= Convert.ToDouble(soldi))
                {
                    this.Saldo -= Convert.ToDouble(soldi);
                    Console.WriteLine($"hai prelevato: {Convert.ToDouble(soldi)} euro, ti restano {this.Saldo} euro");
                    Menu();
                }
                else
                {
                    Console.WriteLine("non hai abbastanza denaro");
                    Menu();
                }
            }
            else
            {
                Console.WriteLine("non hai ancora aperto il conto.");
                Menu();
            }
            
        }
        public ContoCorrente(string intestatario)
        {
            this.Intestatario = intestatario;
            
        }

    }
}
