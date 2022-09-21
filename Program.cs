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


Console.WriteLine(monteDeiPaschi.Name);

monteDeiPaschi.;

public class Bank
{
    public string Name { get; set; }
    public Bank(string name)
    {
        this.Name = name;
    }


    List<Loan> loans = new List<Loan>
    {
        new Loan(4500, "Pique Agostino", 250, "Aprile 2020", "Febbraio 2025"),
        new Loan(2600, "DeUghi Ugo", 360, "Gennaio 2018", "Gennaio 2023"),
        new Loan(1600, "DeFranchi Francesco", 180, "Maggio 2017", "Maggio 2019"),
        new Loan(2500, "Da Vinci Leonardo", 250, "Aprile 1758", "Febbraio 1759")

    };

    public void PrintLoan()
    {
        if(loans.Count == 0)
        {
            Console.WriteLine("Non ci sono prestiti aperti");
        }

        foreach(Loan loan in loans)
        {
            Console.WriteLine("File del prestito di: ");
            Console.WriteLine(loan.Holder);
            Console.WriteLine("--------");
            Console.WriteLine("Rata mensile: ");
            Console.WriteLine(loan.MonthAmount);
            Console.WriteLine("Cifra data in prestito: ");
            Console.WriteLine(loan.Amount);
        }
        
    }
    

    List<Client> clients = new List<Client>
    {
        new Client("Ugo", "DeUghi", "UGDUGH97C26G999W", 5000),
        new Client("Agostino", "Pique", "IUESTO97C26G999W", 4000),
        new Client("Francesco", "DeFranchi", "FRNDFR88G06F888W", 1500),
        new Client("Leonardo", "Da Vinci", "LNRDVN58G65D856G", 6000)
    };

    public void AddUser(string name, string surname, string personalNumber, int salary)
    {
        clients.Add(new Client(name, surname, personalNumber, salary);
        Console.WriteLine("Cliente aggiunto con successo");
    }

    public void GetUser(string personalNumber)
    {
        if(personalNumber == null)
        {
            Console.WriteLine("Inserisci il codice fiscale per ricercare il cliente.");
        }
        else
        {
            foreach(Client client in clients)
            {
                if(client.PersonalNumber == personalNumber)
                {
                    Console.WriteLine("Utente trovato: ");
                    Console.WriteLine(client.Name + client.Surname);
                }
            }
        }

    }

    
}
