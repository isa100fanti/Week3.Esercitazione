using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Esercitazione.Classi;

namespace Week3.Esercitazione
{
    public class Utente
    {
        public string Username { get; } = "dino.rossi89";
        public string Password { get; } = "vrossi69";
        public string Nome { get; set; } = "Dino";
        public string Cognome { get; set; } = "Rossi";

        public override string ToString()
        {
            return base.ToString() + $"Nome {Nome}, Cognome {Cognome} Username {Username} Password {Password}";
        }

        public Dictionary<DettaglioOrdine, double> Carrello()
        {
            Dictionary<DettaglioOrdine, double> carrello = new Dictionary<DettaglioOrdine, double>();
            

            return carrello;
        }

    }
}
