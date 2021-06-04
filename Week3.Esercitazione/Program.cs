using System;
using System.Collections.Generic;
using Week3.Esercitazione.Classi;

namespace Week3.Esercitazione
{
    public class Program
    {

        /*Esercitazione pratica
Creare una Console App per la gestione di un carrello di un e-commerce.
Il sito ha degli utenti iscritti. (Inserire almeno un utente già iscritto).
L’utente è definito con
•	Username, 
•	Password, 
•	Nome e Cognome.
L’e-commerce prevede che vengano messi in vendita prodotti d’abbigliamento, alimentari e di elettronica tutti caratterizzati da:
•	un codice, 
•	una descrizione, 
•	il prezzo, 
•	una percentuale di sconto.
I prodotti di tipo abbigliamento specificano anche una taglia (string) e il brand (string), i prodotti alimentari hanno anche una data di scadenza mentre i prodotti di elettronica un produttore (string.

Per ogni utente è previsto un solo carrello contenente le righe di dettaglio dell’ordine e il prezzo totale da pagare (nota: è importante risalire dall’utente al carrello e non il viceversa).

Ciascuna riga di dettaglio contiene le seguenti caratteristiche:
•	prodotto, 
•	la quantità ordinata, 
•	il prezzo totale al netto dello sconto (rispetto alla quantità e al prezzo “pieno” del prodotto), 
•	il prezzo totale scontato (calcolato rispetto alla percentuale di sconto del singolo prodotto).

All’accesso, viene chiesto username e password. Se sono corrette si accede al menu.
1.	Aggiungi prodotto al carrello* 
2.	Elimina prodotto 
3.	Modifica la quantità di un prodotto già inserito 
4.	Stampa a video riepilogo del carrello dell’utente (formato a piacere) 
5.	Esci 
*Nel caso sia inserito un prodotto che già esiste nel carrello questo va a modificare la quantità del prodotto precedentemente inserito.

Requisiti tecnici:
- Rappresentare opportunamente la gerarchia dei prodotti.
- Utilizzare la collection adeguata considerando che ogni prodotto ha un codice univoco.

Consigli:
Creare metodi ad hoc per creare le entità di partenza “precaricate” nell’e-commerce.




Mettere la prova pratica e teorica su Github.






*/


        /*
         All’accesso, viene chiesto username e password. Se sono corrette si accede al menu.
1.	Aggiungi prodotto al carrello* 
2.	Elimina prodotto 
3.	Modifica la quantità di un prodotto già inserito 
4.	Stampa a video riepilogo del carrello dell’utente (formato a piacere) 
5.	Esci */

        static void Main(string[] args)
        {
            Utente utente = new Utente();


            List<Prodotto> carrello = new List<Prodotto>();
            Console.WriteLine("Inserisci le credenziali");
            string nutente = Console.ReadLine();
            string password = Console.ReadLine();
            int scelta = 0;
            if ((nutente == utente.Username) && (password == utente.Password))  //ho posto delle credenziali di base nella classe utente
            {
                Program.Menu();
                do
                {
                    scelta = Program.Scelta(scelta);

                } while (scelta != 5);
            }
            else
                Console.WriteLine("log in errato!");
                    
        }

        public static void Scelta(int scelta)
        {
            //List<Prodotto> carrello = new List<Prodotto>();
            int codice = 0;
            switch (scelta)
            {
                case 1://aggiungi un prodotto al carrello
                    List<Prodotto>carrello = Carrello.AggiungiProdotto();
                    break;
                case 2://elimina prodotto
                    Carrello.EliminaProdotto(codice);
                    break;
                case 3://modifica quantità
                    Carrello.ModificaQuantità();
                    break;
                case 4://stampa a video repilogo

                    break;
                default:
                    Console.WriteLine("non conosco il comando");
                    break;

            }
        }

        public static void Menu()
        {
            Console.WriteLine("1-aggiungi un prodotto al carrello");
            Console.WriteLine("2-elimina un prodotto da carrello");
            Console.WriteLine("3-modifica quantità prodotto al carrello");
            Console.WriteLine("4- visualizza carrello");
            int opzione = Convert.ToInt32(Console.ReadLine());
        }
    }
}
