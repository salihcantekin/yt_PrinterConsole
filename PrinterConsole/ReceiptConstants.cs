namespace PrinterConsole;
public class ReceiptConstants : IReceiptConstants
{
    public string Left { get; set; } = "";
    public string Right { get; set; } = "";
    public string Center { get; set; } = "";
    public string Bold { get; set; } = "";
    public string Underline { get; set; } = "";
    public string Cut { get; set; } = "";
    public string NewLine { get; set; } = "";
    public string Print { get; set; } = "";
    public string PrintAndCut { get; set; } = "";
    public string PrintAndNewLine { get; set; } = "";
}

public interface IReceiptConstants
{
    string Left { get; set; }
    string Right { get; set; }
    string Center { get; set; }
    string Bold { get; set; }
    string Underline { get; set; }
    string Cut { get; set; }
    string NewLine { get; set; }
    string Print { get; set; }
    string PrintAndCut { get; set; }
    string PrintAndNewLine { get; set; }
}
