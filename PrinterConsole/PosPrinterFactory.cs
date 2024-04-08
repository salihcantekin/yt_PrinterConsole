using PrinterConsole.Printers;
namespace PrinterConsole;

internal class PosPrinterFactory
{
    internal static BasePosPrinter Create(string posPrinterType)
    {
        return posPrinterType switch
        {
            nameof(PosPrinterType.Star) => new StarPosPrinter(),
            nameof(PosPrinterType.Hp) => new HpPosPrinter(),
            nameof(PosPrinterType.Epson) => new EpsonPosPrinter(),
            _ => throw new ArgumentException("Invalid printer type"),
        };
    }

}

internal enum PosPrinterType
{
    Epson,
    Star,
    Hp
}