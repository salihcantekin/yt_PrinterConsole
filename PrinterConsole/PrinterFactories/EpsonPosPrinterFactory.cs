using Microsoft.Extensions.Logging;
using PrinterConsole.Printers;

namespace PrinterConsole.PrinterFactories;

public class EpsonPosPrinterFactory(ILogger logger) : BasePosPrinterFactory(logger)
{
    public override BasePosPrinter Create()
    {
        return new EpsonPosPrinter(Logger);
    }
}
