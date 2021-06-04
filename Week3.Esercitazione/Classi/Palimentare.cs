using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Esercitazione.Classi
{
    public class Palimentare : Prodotto
    {
        public Palimentare(int codice, string descrizione, double prezzo, double sconto , Tipo tipo,DateTime dataScadenza)
        : base(codice,descrizione,prezzo,sconto,tipo)
        {
            DataScadenza = dataScadenza;
           
        }

        public DateTime DataScadenza { get; set; }
        public override Tipo TipoProdotto { get; } = Tipo.alimentare;

    }
}
