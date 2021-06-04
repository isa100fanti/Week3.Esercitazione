using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Esercitazione.Classi
{
    public class Carrello
    {
        public double Prezzo { get; set; }
        public DettaglioOrdine Dettaglio { get; set; }

        public List<Prodotto> MioCarrello()
        {
            List<Prodotto> carrello = new List<Prodotto>();
            foreach(Prodotto p in carrello)
            {
                carrello.Add(p);
            }
            return carrello;
        }

        public static List<Prodotto> AggiungiProdotto()
        {
            List<Prodotto> carrello = new List<Prodotto>();
            Console.WriteLine("scegli il tipo di prodotto");
            string prodotto = Console.ReadLine();
            if(prodotto == "abbigliamento")
            {
                Prodotto p = new Pabbigliamento(1234, "Jeans a zampa", 19.50, 20 , Tipo.abbigliamento, "XL", "Calvin Klein");
                carrello.Add(p);
            }
            else if(prodotto == "elettronica")
            {
                Prodotto p = new Pelettronica(234, "iphone 12", 950, 10, Tipo.elettronica, "Apple");
                carrello.Add(p);
            }
            else if(prodotto == "alimentare")
            {
                Prodotto p = new Palimentare(345, "Pandoro bauli", 5.50, 30, Tipo.alimentare, new DateTime(12 / 12 / 2021));
                carrello.Add(p);
            }

            return carrello;

        }

        public static void EliminaProdotto(int codice)
        {
            throw new NotImplementedException();
        }

        public static void ModificaQuantità()
        {
            throw new NotImplementedException();
        }
    }
}
