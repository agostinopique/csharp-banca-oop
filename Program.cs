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

Bank monteDeiPaschi = new Bank();
Console.WriteLine(monteDeiPaschi);

public class Bank
{
    public string Name { get; set; }

    List<Client> clients = new List<Client>
    {
        new Client("Ugo", "DeUghi", "UGDUGH97C26G999W", 5000),
        new Client("Agostino", "Pique", "IUESTO97C26G999W", 4000),
        new Client("Francesco", "DeFranchi", "FRNDFR88G06F888W", 1500),
        new Client("Leonardo", "Da Vinci", "LNRDVN58G65D856G", 6000)
    };



    List<Loan> loans = new List<Loan>
    {
        new Loan(4500, "Pique Agostino", 250, "Aprile 2020", "Febbraio 2025"),
        new Loan(2600, "DeUghi Ugo", 360, "Gennaio 2018", "Gennaio 2023"),
        new Loan(1600, "DeFranchi Francesco", 180, "Maggio 2017", "Maggio 2019"),
        new Loan(2500, "Da Vinci Leonardo", 250, "Aprile 1758", "Febbraio 1759")

    };
}

public class Client
{
    public string Name { set; get; }    
    public string Surname { set; get; } 
    public string PersonalNumber { set; get; }
    public int Salary { set; get; }

    public Client(string name, string surname, string personalNumber, int salary)
    {
        this.Name = name;
        this.Surname = surname;
        this.PersonalNumber = personalNumber;
        this.Salary = salary;

    }
}

public class Loan
{
    //I prestiti sono caratterizzati da
    //  - ID
    //  - intestatario del prestito (il cliente),
    //  - un ammontare,
    //  - una rata,
    //  - una data inizio,
    //  - una data fine.

    public static int ID { get; set; }
    public string Holder { get; set; }
    public int Amount { get; set; }
    public int MonthAmount { get; set; }
    public string StartAt { get; set; }
    public string EndAt { get; set; }

    public Loan(int amount, string holder, int monthAmount, string startAt, string endAt)
    {
        ID++;
        this.Holder = holder;
        this.Amount = amount;
        this.MonthAmount = monthAmount;
        this.StartAt = startAt;
        this.EndAt = endAt;
    }
}