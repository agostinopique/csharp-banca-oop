// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, C# OOP!");

//Esercizio

//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

//La banca è caratterizzata da

//  - un nome
//  - un insieme di clienti (una lista)
//  - un insieme di prestiti concessi ai clienti (una lista)

//I clienti sono caratterizzati da
//  - nome,
//  - cognome,
//  - codice fiscale
//  - stipendio

//I prestiti sono caratterizzati da
//  - ID
//  - intestatario del prestito (il cliente),
//  - un ammontare,
//  - una rata,
//  - una data inizio,
//  - una data fine.

//Per la banca deve essere possibile:
//  - aggiungere, modificare e ricercare un cliente.
//  - aggiungere un prestito.
//  - effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//  - sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//  - sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.

//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.

//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

//  PRIMA CLASSE:       BANCA
//  SECONDA CLASSE:     CLIENTE
//  TERZA CLASSE:       PRESTITI

//  PRIMA CLASSE istanzierà delle liste di classi di clienti e dei prestiti 
//  SECONDA CLASSE non contiene nessuna lista, ha solo riferimenti nella prima (banca) e terza classe (prestito)
//  TERZA CLASSE fa solo riferimento alla seconda classe (cliente)

Bank monteDeiPaschi = new Bank("Monte dei Paschi");

Console.WriteLine("Benvenuto alla banca ");
Console.WriteLine(monteDeiPaschi.Name);

// MENU PRINCIPALE
Menu:
Console.WriteLine("Cosa vuoi fare? (scrivi il numero dell'operazione)");

Console.WriteLine("1. Cercare un cliente");
Console.WriteLine("2. Aggiungere un cliente");
int userAnswer = Convert.ToInt32(Console.ReadLine());


switch (userAnswer)
{
    case 1:

        Console.WriteLine("Inserisci il codice fiscale del cliente che stai cercando");
        string personalNumber = Console.ReadLine();
        Client c = monteDeiPaschi.GetUser(personalNumber);

        Console.WriteLine("Cosa vuoi fare? (scrivi il numero dell'operazione)");

        Console.WriteLine("1. Modifica il cliente");

        Console.WriteLine("2. Vedi i prestiti dell'utente");

        Console.WriteLine("3. Torna al menu");

        int userSearchAnswer = Convert.ToInt32(Console.ReadLine());

        if(userSearchAnswer == 1)
        {
            Console.WriteLine("Modifica del cliente");
        }else if(userSearchAnswer == 2)
        {
            Console.WriteLine("Vedi i prestiti del cliente");
        }
      
        goto Menu;


    case 2:

        Console.WriteLine("Inserisci i dati del nuovo cliente partendo da:");

        Console.WriteLine("nome:");
        string userName = Console.ReadLine();

        Console.WriteLine("cognome:");
        string surname = Console.ReadLine();

        Console.WriteLine("Codice fiscale:");
        string setPersonalNumber = Console.ReadLine();

        Console.WriteLine("Stipendio mensile:");
        int salary = Convert.ToInt32(Console.ReadLine());

        monteDeiPaschi.AddUser(userName, surname, setPersonalNumber, salary);
        break;
}
