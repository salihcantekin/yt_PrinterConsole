using Microsoft.Extensions.Logging;
using PrinterConsole.PrinterFactories;
namespace PrinterConsole;

public class PosPrinterFactory
{
    public static BasePosPrinterFactory CreatePosPrinterFactory(ILogger logger, IReceiptConstants receiptConstants, string posPrinterType)
    {
        return posPrinterType switch
        {
            nameof(PosPrinterType.Star) => new StarPosPrinterFactory(logger, receiptConstants),
            nameof(PosPrinterType.Hp) => new HpPosPrinterFactory(logger, receiptConstants),
            nameof(PosPrinterType.Epson) => new EpsonPosPrinterFactory(logger),
            _ => throw new ArgumentException("Invalid printer type"),
        };
    }
}

public enum PosPrinterType
{
    Epson,
    Star,
    Hp
}