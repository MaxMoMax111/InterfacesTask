using InterfacesTask.Domain.Interfaces;
using System.Text;

namespace InterfacesTask.Domain.Products;

public class Cd : ILoanable, IPrintable
{
    private string Artist { get; }
    private string Title { get; }
    private int NumberOfTracks { get; }
    public int LoanPeriod { get; set; } = 14;
    public string? Borrower { get; set; }

    public Cd(string artist, string title, int numberOfTracks)
    {
        Artist = artist;
        Title = title;
        NumberOfTracks = numberOfTracks;
    }

    public void Borrow(string borrower)
    {
        Borrower = borrower;

        Console.WriteLine($"\nThe CD '{Title}' by {Artist} is loaned to {borrower}.");
    }

    public void Return()
    {
        Console.WriteLine($"\n{Borrower} has been returned the CD '{Title}' by {Artist}.");

        Borrower = null;
    }

    public void Print()
    {
        var result = new StringBuilder($"\nInformation about the CD:\nArtist - {Artist}\nTitle - {Title}\nNumber of tracks - {NumberOfTracks} tracks.\nLoan period - {LoanPeriod} days");

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