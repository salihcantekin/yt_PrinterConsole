using Microsoft.Extensions.Logging;
using PrinterConsole.PostProcessors;
using PrinterConsole.Printers;

namespace PrinterConsole.PrinterFactories;

public class StarPosPrinterFactory(ILogger logger, IReceiptConstants receiptConstants) : BasePosPrinterFactory(logger)
{
    public override BasePosPrinter Create()
    {
        return new StarPosPrinter(Logger)
                .SetReceiptLineWidth(PosPrinterConstants.Star.RECEIPT_WIDTH)
                .AddPostProcessor(new LineAlignmentProcessor(receiptConstants, PosPrinterConstants.Star.RECEIPT_WIDTH));
    }
}
