// See https://aka.ms/new-console-template for more information
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
