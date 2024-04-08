namespace PrinterConsole;
public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public decimal TotalPrice => Items.Sum(x => x.Price);

    public IEnumerable<TransactionItem> Items { get; set; } = [];
}

public record TransactionItem(string ProductName, decimal Price, decimal Discount);
