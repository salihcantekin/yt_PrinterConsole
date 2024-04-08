using PrinterConsole.Printers;

namespace PrinterConsole;
internal class ReceiptManager
{
    private readonly IReceiptConstants receiptConstants;
    private readonly MicrosoftPosPrinter printer;

    public ReceiptManager(IReceiptConstants receiptConstants)
    {
        this.receiptConstants = receiptConstants;
        printer = MicrosoftPosExplorer.CreatePrinterInstance<MicrosoftPosPrinter>();
    }


    internal void PrintReceipt(Transaction transaction)
    {
        string printData = GenerateReceiptData(transaction);

        printer.Print(printData);
    }



    internal string GenerateReceiptData(Transaction transaction)
    {
        string printData = $"""
            {receiptConstants.Left}TECH BUDDY LTD
            {receiptConstants.Right}{DateTime.Now:dd.MM.yyyy}
            {receiptConstants.Left}{transaction.Items.Select(i => $"{i.ProductName}\t{i.Price}")}

            {receiptConstants.Left}Total: {transaction.TotalPrice}
            """;

        return printData;
    }
}
