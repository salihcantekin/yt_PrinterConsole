using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrinterConsole.Printers;

namespace PrinterConsole;
internal class PrinterWrapper
{
    private BasePosPrinter printer;


    public void SetupPrinter(string posPrinterType)
    {
        printer = PosPrinterFactory.Create(posPrinterType);
    }
    

    public void Print(string printData)
    {
        // actual printing logic in SDK
        printer.Print(printData);
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
