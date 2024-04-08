using System.Text;

namespace PrinterConsole.PostProcessors;

public class LineAlignmentProcessor(IReceiptConstants receiptConstants, int lineWidth) : IDataProcessor
{
    public void ProcessData(ref string data)
    {
        var builder = new StringBuilder();

        var lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        for (int i = 0; i < lines.Length; i++)
        {
            var line = lines[i];

            // doSomething with the line

            builder.AppendLine(line);
        }

        builder = builder.Remove(builder.Length - Environment.NewLine.Length, Environment.NewLine.Length); // remove the last NewLine
        data = builder.ToString();
    }
}
