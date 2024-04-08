using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PrinterConsole.Printers;

namespace PrinterConsole;
public class ReceiptManager
{
    private readonly IReceiptConstants receiptConstants;
    private readonly BasePosPrinter printerWrapper;

    public ReceiptManager(IReceiptConstants receiptConstants, IConfiguration configuration, ILogger logger)
    {
        string printerType = configuration["PrinterType"];
        this.receiptConstants = receiptConstants;

        printerWrapper = PosPrinterFactory
                            .CreatePosPrinterFactory(logger, receiptConstants, printerType)
                            .Create();
    }


    public void PrintReceipt(Transaction transaction)
    {
        string printData = GenerateReceiptData(transaction);

        printerWrapper.PrintWithProcessors(printData);
    }



    public string GenerateReceiptData(Transaction transaction)
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
