using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Esercitazione.Classi
{
    public class Pelettronica : Prodotto
    {
        public string Produttore { get; set; }
        public override Tipo TipoProdotto { get; } = Tipo.elettronica;

        public Pelettronica(int codice, string descrizione, double prezzo, double sconto, Tipo tipo,string produttore)
        : base(codice, descrizione, prezzo, sconto, tipo)
        {
            Produttore = Produttore;
            
        }
}
}
