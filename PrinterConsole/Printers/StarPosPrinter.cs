namespace PrinterConsole.Printers;

internal class StarPosPrinter : BasePosPrinter
{
    public override void Configure(IReceiptConstants receiptConstants)
    {
        PosPrinter.PrintableAreaWidth = 46;
        PosPrinter.CharacterSet = 1252;
    }
}
