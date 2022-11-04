﻿/*Richiesta:
    Si vuole progettare un sistema per la gestione di una biblioteca dove il bibliotecario può verificare i dati dei clienti registrati

    cognome,
    nome,
    email,
    recapito telefonico,

    Il bibliotecario può effettuare dei prestiti ai suoi clienti registrati, attraverso il sistema, sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:

    un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
    titolo,
    anno,
    settore (storia, matematica, economia, …),
    stato (In Prestito, Disponibile),
    uno scaffale in cui è posizionato,
    un autore (Nome, Cognome).
    Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

    Il bibliotecario deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
    Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un cliente.
    Mi raccomando, prima di buttarvi sul codice fate qualche schema per capire le entità principali e le loro relazioni / eredità.
    Buon lavoro! (modificato) 
*/


Libro libro1 = new Libro(200, "12345678", "topolino", "10-05-2006", false, 1, "Alessandro Fulco", "Statistica");
Libro libro2 = new Libro(200, "18295432", "Guerra e pace", "10-05-2006", false, 3, "Alessandro Fulco", "Statistica");
Libro libro3 = new Libro(200, "93572746", "La Conoscienza di Zeno", "10-05-2006", false, 5, "Alessandro Fulco", "Statistica");

List<Libro> libroList = new List<Libro>();
libroList.Add(libro1);
libroList.Add(libro2);
libroList.Add(libro3);

Dvd dvd1 = new Dvd(3, "31647523", "A sangue freddo", "14-03-2011", false, 2, "Alessandro Fulco", "Matematica");
Dvd dvd2 = new Dvd(3, "62357524", "Grandi speranze", "14-03-2011", false, 4, "Alessandro Fulco", "Matematica");
Dvd dvd3 = new Dvd(3, "72624262", "Pinocchio", "14-03-2011", false, 6, "Alessandro Fulco", "Matematica");

List<Dvd> dvdList = new List<Dvd>();
dvdList.Add(dvd1);
dvdList.Add(dvd2);
dvdList.Add(dvd3);

Console.WriteLine("------ LIBRI ------");
Console.WriteLine(libro1.ToString());
Console.WriteLine(libro2.ToString());
Console.WriteLine(libro3.ToString());

Console.WriteLine();

Console.WriteLine("----- DVD ------");
Console.WriteLine(dvd1.ToString());
Console.WriteLine(dvd2.ToString());
Console.WriteLine(dvd3.ToString());

Console.WriteLine();

Utente ut1 = new Utente("Fulco", "Alessandro", "alessandro@prova.it", "1235124431", true);
Utente ut2 = new Utente("Rossi", "Mario", "mario@prova.it", "1235124431", false);



Prestito prestitolibro1 = new Prestito("10-10-2022", "15-10-2022", libro1);

List<Prestito> prestiti = new List<Prestito>();
prestiti.Add(prestitolibro1);




//Il bibliotecario deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//    Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un cliente.
//    Mi raccomando, prima di buttarvi sul codice fate qualche schema per capire le entità principali e le loro relazioni / eredità.
//    Buon lavoro! (modificato) 
public class Biblioteca
{
    
}


public class Prestito
{
    public string Inizio { get; set; }
    public string Fine { get; set; }
    public Documento Documento { get; set; }

    public Prestito(string inizio, string fine, Documento item)
    {
        Inizio = inizio;
        Fine = fine;
        Documento = item;
        Documento.Stato = true;
    }

    public override string ToString()
    {
        return "Durata prestito: " + Inizio + " - " + Fine + "documento: " + Documento;
    }
}