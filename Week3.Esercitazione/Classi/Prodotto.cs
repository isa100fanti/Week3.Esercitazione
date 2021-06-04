using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Esercitazione
{
    public enum Tipo
    {
        abbigliamento,
        alimentare,
        elettronica
    }
    public abstract class Prodotto
    {
        public int Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double PercentualeSconto { get; set; }
        public abstract Tipo TipoProdotto { get; }

        public Prodotto(int codice, string descrizione, double prezzo, double sconto, Tipo tipo)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
            PercentualeSconto = sconto;
        }
        public override string ToString()
        {
            string tipo="";
            if(TipoProdotto == Tipo.abbigliamento)
            {
                tipo = "abbigliamento";
            }
            else if (TipoProdotto == Tipo.elettronica)
            {
                tipo = "elettronica";
            }
            if (TipoProdotto == Tipo.alimentare)
            {
                tipo = "alimentare";
            }
            return  $"COdice {Codice}, Descrizione {Descrizione} , Prezzo {Prezzo},\n Percentuale sconto {PercentualeSconto}, Tipo prodotto " + tipo;
        }

    }
}
