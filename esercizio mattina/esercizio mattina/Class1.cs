using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_mattina
{
    internal class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public Studi Studi { get; set; }
        public Impiego Impiego { get; set; }
        public Esperienza Esperienza { get; set; }

        
        public void StampaDettagliCvSuSchermo()
        {
            Console.WriteLine($"****INFORMAZIONI PERSONALI**** \r\n" +
                $"nome: {this.InformazioniPersonali.Nome}\r\n" +
                $"cognome: {this.InformazioniPersonali.Cognome}\r\n" +
                $"telefono: {this.InformazioniPersonali.Telefono}\r\n" +
                $"email: {this.InformazioniPersonali.Email}\r\n" +
                $"*****STUDI E FORMAZIONE******\r\n" +
                $"istituto: {this.Studi.Istituto}\r\n" +
                $"qualifica: {this.Studi.Qualifica}\r\n" +
                $"tipo di studi:{this.Studi.Tipo}\r\n" +
                $"dal: {this.Studi.dataInizio}\r\n" +
                $"al: {this.Studi.dataFine}\r\n" +
                $"******ESPERIENZE PROFESSIONALI******\r\n" +
                $"");
            for (int i = 0; i < Impiego.Esperienze.Count; i++)
            {
                Console.WriteLine($"" +
                    $"tipo di lavoro: {Impiego.Esperienze[i].JobTitle}\r\n" +
                    $"presso: {Impiego.Esperienze[i].Azienda}\r\n" +
                    $"tipo di lavoro: {Impiego.Esperienze[i].Compiti}\r\n" +
                    $"tipo di lavoro: {Impiego.Esperienze[i].DataInizio}\r\n" +
                    $"tipo di lavoro: {Impiego.Esperienze[i].DataFine}\r\n");
            }
        }
    }
    
}

public class InformazioniPersonali
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }

    public InformazioniPersonali(string nome, string cognome, string telefono, string email) 
    {
        this.Nome = nome;
        this.Cognome = cognome;
        this.Email = email;
        this.Telefono = telefono;

    }

}
public class Studi
{
    public string Qualifica { get; set; }
    public string Istituto { get; set; }
    public string Tipo { get; set; }
    public string dataInizio { get; set; }
    public string dataFine { get; set; }

    public Studi(string qualifica, string istituto, string tipo, string dal, string al)
    {
        this.Qualifica = qualifica;
        this.Istituto = istituto;
        this.Tipo = tipo;
        this.dataInizio = dal;
        this.dataFine = al;
    }
}
public class Impiego
{
    public List<Esperienza> Esperienze { get; set; }
}
public class Esperienza
{
    public string Azienda { get; set; }
    public string JobTitle { get; set; }
    public string DataInizio { get; set; }
    public string DataFine { get; set; }
    public string Descrizione { get; set;}
    public string Compiti { get; set; }
    public Esperienza(string azienda, string jobTitle, string dataInizio, string dataFine, string descrizione, string compiti)
    {
        Azienda = azienda;
        JobTitle = jobTitle;
        DataInizio = dataInizio;
        DataFine = dataFine;
        Descrizione = descrizione;
        Compiti = compiti;
    }
}
