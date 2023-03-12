using System.Text;
using InterfacesTask.Domain.Interfaces;

namespace InterfacesTask.Domain.Products;

public class Book : ILoanable, IPrintable
{
    private string Author { get; }
    private string Title { get; }
    private string Isbn { get; }
    public int LoanPeriod { get; set; } = 21;
    public string? Borrower { get; set; }

    public Book(string author, string title, string isbn)
    {
        Author = author;
        Title = title;
        Isbn = isbn;
    }

    public void Borrow(string borrower)
    {
        Borrower = borrower;

        Console.WriteLine($"\nThe book '{Title}' by the author {Author} is loaned to {borrower}.");
    }

    public void Return()
    {
        Console.WriteLine($"\n{Borrower} has been returned the book '{Title}' by the author {Author}.");

        Borrower = null;
    }

    public void Print()
    {
        var result = new StringBuilder($"\nInformation about the book:\nAuthor - {Author}\nTitle - {Title}\nISBN - {Isbn}\nLoan period - {LoanPeriod} days");

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