namespace PrinterConsole.Printers;
internal class MicrosoftPosPrinter
{
    public void Print(string printData)
    {
        // actual printing logic in SDK
    }



    public int PrintableAreaWidth { get; set; }

    public int CharacterSet { get; set; }

    public bool IsOpened { get; set; }

    public bool IsClaimed { get; set; }
    public bool IsClosed { get; set; }

    public void Open()
    {

    }

    public void Claim(int timeout)
    {

    }
    public void Close() { }


}






// From SDK
internal class MicrosoftPosExplorer
{
    public static MicrosoftPosPrinter CreatePrinterInstance(string posPrinterName)
    {
        // find the registered printer by bane

        return Activator.CreateInstance<MicrosoftPosPrinter>();
    }
}