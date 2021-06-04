using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Esercitazione.Classi
{
    public class Pabbigliamento : Prodotto
    {
        public string Taglia { get; set; }
        public string Brand { get; set; }

        public Pabbigliamento(int codice, string descrizione, double prezzo, double sconto, Tipo tipo, string taglia, string brand)
        : base(codice, descrizione, prezzo, sconto, tipo)
        {
            Taglia = taglia;
            Brand = brand;

        }
    public override Tipo TipoProdotto { get; } = Tipo.abbigliamento;
    }
}
