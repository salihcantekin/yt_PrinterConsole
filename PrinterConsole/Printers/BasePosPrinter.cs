using Microsoft.Extensions.Logging;
using PrinterConsole.PostProcessors;
using System.Collections.ObjectModel;

namespace PrinterConsole.Printers;
public abstract class BasePosPrinter(ILogger logger)
{
    private List<IDataProcessor> postProcessors;
    private MicrosoftPosPrinter printer;

    public ReadOnlyCollection<IDataProcessor> PostProcessors => postProcessors?.AsReadOnly();

    public MicrosoftPosPrinter GetPrinter() => printer;

    public int ReceiptLineWidth { get; private set; }



    public virtual void SetUpPrinter(string printerLogicalName)
    {
        printer = MicrosoftPosExplorer.CreatePrinterInstance(printerLogicalName);

        if (printer == null)
        {
            throw new Exception("BasePosPrinter: PosPrinter null instance");
        }
    }

    public void PrintWithProcessors(string printData)
    {
        ExecutePostProcessors(ref printData);

        printer.Print(printData);
    }

    public BasePosPrinter SetReceiptLineWidth(int width)
    {
        printer.PrintableAreaWidth = width;

        return this;
    }

    #region Processor Methods

    public BasePosPrinter AddPostProcessor(IDataProcessor processor)
    {
        postProcessors ??= [];

        postProcessors.Add(processor);

        return this;
    }

    private void ExecutePostProcessors(ref string data)
    {
        if (postProcessors is null)
            return;

        foreach (var processor in postProcessors)
        {
            processor.ProcessData(ref data);
        }
    }

    #endregion

    #region Printer Properties

    public bool IsPrinterClaimed => printer.IsClaimed;

    public bool IsCoverOpen => printer.IsOpened;

    #endregion

    #region Printer Operation Methods

    public virtual void ConfigurePrinterWithDefaults()
    {
        //printer.PowerNotify = PowerNotification.Enabled;
        //printer.DeviceEnabled = true;

        //printer.RecLetterQuality = true; // Print in high quality
        //printer.FreezeEvents = false;    // We should get a status update here
    }

    public virtual void OpenPrinter() => printer.Open();

    public virtual void ClaimPrinter(int claimTimeout) => printer.Claim(claimTimeout);

    #endregion

}

