using Microsoft.Extensions.Logging;

namespace PrinterConsole.Printers;
public class EpsonPosPrinter(ILogger logger) : BasePosPrinter(logger)
{
}