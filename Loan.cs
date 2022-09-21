// See https://aka.ms/new-console-template for more information
public class Loan
{

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