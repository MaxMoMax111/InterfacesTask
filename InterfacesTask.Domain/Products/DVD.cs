using InterfacesTask.Domain.Interfaces;
using System.Text;

namespace InterfacesTask.Domain.Products;

public class Dvd : ILoanable, IPrintable
{
    private string Director { get;  }
    private string Title { get; }
    private int LengthInMinutes { get; }
    public int LoanPeriod { get; set; } = 7;
    public string? Borrower { get; set; }

    public Dvd(string director, string title, int lengthInMinutes)
    {
        Director = director;
        Title = title;
        LengthInMinutes = lengthInMinutes;
    }

    public void Borrow(string borrower)
    {
        Borrower = borrower;

        Console.WriteLine($"\nThe DVD '{Title}' is loaned to {borrower}.");
    }

    public void Return()
    {
        Console.WriteLine($"\n{Borrower} has been returned the DVD '{Title}'.");

        Borrower = null;
    }

    public void Print()
    {
        var result = new StringBuilder($"\nInformation about the DVD:\nDirector - {Director}\nTitle - {Title}\nLength in minutes - {LengthInMinutes} min.\nLoan period - {LoanPeriod} days");

        if (Borrower != null)
        {
            result.Append($"\nBorrower - {Borrower}");

            Console.WriteLine(result.ToString());
        }
        else
        {
            result.Append("\nBorrower - Free at the moment.");

            Console.WriteLine(result.ToString());
        }
    }
}