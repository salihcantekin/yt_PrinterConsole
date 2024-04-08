using Microsoft.Extensions.Configuration;

namespace PrinterConsole.Printers;
internal class EpsonPosPrinter : BasePosPrinter
{
    internal EpsonPosPrinter(IConfiguration configuration)
        : base(configuration["PosPrinterName"])
    {
    }

    public override void Configure(IReceiptConstants receiptConstants)
    {
        PosPrinter.PrintableAreaWidth = 45;
        PosPrinter.CharacterSet = 1252;
    }
}