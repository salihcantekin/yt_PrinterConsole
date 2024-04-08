using Microsoft.Extensions.Logging;
using PrinterConsole.PostProcessors;
using PrinterConsole.Printers;

namespace PrinterConsole.PrinterFactories;

public class HpPosPrinterFactory(ILogger logger, IReceiptConstants receiptConstants) : BasePosPrinterFactory(logger)
{
    public override BasePosPrinter Create()
    {
        return new HpPosPrinter(Logger)
                .SetReceiptLineWidth(PosPrinterConstants.Hp.RECEIPT_WIDTH)
                .AddPostProcessor(new LineAlignmentProcessor(receiptConstants, PosPrinterConstants.Hp.RECEIPT_WIDTH));
    }
}
