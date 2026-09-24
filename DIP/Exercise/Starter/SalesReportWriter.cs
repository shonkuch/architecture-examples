namespace DIP.Exercise.Starter;

public class SalesReportWriter : ISalesReportWriter
{
    private readonly string outputPath;

    public SalesReportWriter(string outputPath)
    {
        this.outputPath = outputPath;
    }
    
    public void Write(string[] report)
    {
        File.WriteAllLines(outputPath, report);
    }
}