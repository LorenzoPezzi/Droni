using System;
using System.Collections.Generic;

namespace Droni
{
    public class Missione
    {
        public int Id { get; }
        public DateTime DataInizio { get; }
        public DateTime DataFine { get; }
        public List<Velivolo> VelivoliMissione { get; set; }
        public Volo Volo { get; set; }

    }
}