using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_mattina
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CV curriculum = new CV();
            curriculum.InformazioniPersonali = new InformazioniPersonali("Fabio","Giannasi", "3334445555","fabio.gianni24@gmail.com");
            curriculum.Studi = new Studi("","Liceo Scientifico","diploma","2010","2015");
            curriculum.Impiego = new Impiego();
            curriculum.Impiego.Esperienze = new List<Esperienza>();
            Esperienza esperienza1 = new Esperienza("IntesaSanpaolo", "Banchiere", "2020", "2023","", "scaldasedia");
            Esperienza esperienza2 = new Esperienza("Casa Mia", "cuoco", "2024", "2025","", "scaldasedia");
            curriculum.Impiego.Esperienze.Add(esperienza1);
            curriculum.Impiego.Esperienze.Add(esperienza2);
            Console.WriteLine(curriculum.Impiego.Esperienze[0].DataInizio);
            curriculum.StampaDettagliCvSuSchermo();
            Console.ReadLine();



        }
    }
}
