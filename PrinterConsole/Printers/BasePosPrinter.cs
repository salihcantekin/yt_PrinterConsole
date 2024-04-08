namespace PrinterConsole.Printers;
internal class BasePosPrinter
{
    protected MicrosoftPosPrinter PosPrinter { get; set; }

    public BasePosPrinter(string posPrinterName)
    {
        PosPrinter = MicrosoftPosExplorer.CreatePrinterInstance(posPrinterName);
    }

    public virtual void Configure(IReceiptConstants receiptConstants)
    {
        // why not set the charset here?
    }
}
