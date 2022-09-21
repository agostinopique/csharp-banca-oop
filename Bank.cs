// See https://aka.ms/new-console-template for more information
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
        clients.Add(new Client(name, surname, personalNumber, salary));
        Console.WriteLine("Cliente aggiunto con successo");
    }


    public Client GetUser(string personalNumber)
    {
        if(personalNumber == null)
        {
            Console.WriteLine("Inserisci il codice fiscale per ricercare il cliente.");
            return null;
        }
        else
        {
            foreach(Client client in clients)
            {
                if(client.PersonalNumber == personalNumber)
                {
                    
                    Console.WriteLine("Utente trovato: ");
                    Console.WriteLine(client.Name + " " + client.Surname);
                    return client;
                }
            }
            return null;
        }

    }

    
}
