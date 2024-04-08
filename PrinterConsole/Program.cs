


using PrinterConsole;

var transaction = new Transaction()
{
    Items =
    [
        new("DevOps Course", 699, 300),
        new("NET6 Library",  499, 200)
    ]
};


ReceiptManager manager = new(new ReceiptConstants(), configuration: null, logger: null);

manager.PrintReceipt(transaction);
