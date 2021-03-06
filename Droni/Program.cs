using System;
using System.Collections.Generic;

namespace Droni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Velivolo
        {
            public int Id { get; }
            public double OreVolate { get; set; }
            public string Tipologia { get; set; }

            //Tipologia(valori assumibili: ala fissa, rotore)

            //Tipologia(valori assumibili: manned, unmanned)

        }

        class Missione
        {
            public int Id { get; }
            public DateTime DataInizio { get; }
            public DateTime DataFine { get; }
            public List<Velivolo> VelivoliMissione { get; set; }
            public Volo Volo { get; set; }

        }

        class Volo
        {
            public int Id { get; }
            public DateTime DataInizio { get; }
            public DateTime DataFine { get; }
            public Velivolo Velivolo { get; }
        }
    }
}

/*
 * Il nostro cliente è un gestore di “flotte droni”, dal colloquio apprendiamo che: 

•	I droni sono dei velivoli i cui voli sono monitorati e registrati; 

•	I voli sono autorizzati solo se all’interno dello span (intervallo ndr) di una missione; 

•	Un drone può partecipare a più voli a patto che il loro span temporale non sia coincidente o intersecante; 

•	Un drone per volare all’interno di una missione deve essere registrato alla missione; 

•	Un drone può partecipare a più missioni a patto che il loro span temporale non sia coincidente o intersecante; 

Il nostro analista descrive così quindi le “entità” del dominio applicativo: 

 

Missione { 

Codice Identificativo 

Data di inizio 

Data di fine 

Velivoli 

Voli 

} 

 

Volo { 

Codice Identificativo 

Data di inizio 

Data di fine 

Velivolo 

} 

 

Velivolo { 

Codice Identificativo 

Ore volate 

Tipologia (valori assumibili: ala fissa, rotore) 

Tipologia (valori assumibili: manned, unmanned) 

} 

 

Avendo l’elenco dei velivoli e delle missioni prepopolato, l’applicazione oggetto dello sviluppo dovrà, con le opportune validazioni: 

•	Permettere l’inserimento di un nuovo drone. 

•	Permettere l’inserimento di un nuovo volo; 

•	Permettere di scegliere una missione e visualizzarne i dettagli. 
 */
