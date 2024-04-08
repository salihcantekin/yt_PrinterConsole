namespace PrinterConsole.Printers;

internal class HpPosPrinter : BasePosPrinter
{
    public override void Configure(IReceiptConstants receiptConstants)
    {
        PosPrinter.PrintableAreaWidth = 44;
        PosPrinter.CharacterSet = 1252;
    }
}