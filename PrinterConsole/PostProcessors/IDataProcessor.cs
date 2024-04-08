namespace PrinterConsole.PostProcessors;

public interface IDataProcessor
{
    void ProcessData(ref string data);
}
