using Microsoft.Extensions.Logging;

namespace PrinterConsole.Printers;

public class StarPosPrinter(ILogger logger) : BasePosPrinter(logger)
{
    public override void ConfigurePrinterWithDefaults()
    {
        base.ConfigurePrinterWithDefaults();

        var printer = GetPrinter();

        var charSet = printer.CharacterSetList?.FirstOrDefault(i => i == PosPrinterConstants.Common.CHARSET);

        if (charSet != null && charSet != printer.CharacterSet)
            printer.CharacterSet = charSet.Value;
    }
}
