namespace InterfacesTask.Domain.Interfaces;

public interface ILoanable
{ 
    int LoanPeriod { get; set; } 
    string? Borrower { get; set; }

    void Borrow(string borrower);
    void Return();
}