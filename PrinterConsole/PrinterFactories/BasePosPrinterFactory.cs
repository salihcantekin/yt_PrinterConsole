
using Microsoft.Extensions.Logging;
using PrinterConsole.Printers;

namespace PrinterConsole.PrinterFactories;

/// <summary>
/// BasePosPrinterFactory abstract class
/// </summary>
public abstract class BasePosPrinterFactory(ILogger logger)
{
    protected ILogger Logger { get; } = logger;

    public abstract BasePosPrinter Create();
}