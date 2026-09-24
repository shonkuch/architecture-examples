using System.Globalization;

namespace DIP.Exercise.Starter;

public class SalesReportGenerator
{
    private readonly ISalesDataReader salesDataReader;
    private readonly ISalesAnalyzer salesAnalyzer;
    private readonly ISalesReporter salesReporter;
    private readonly ISalesReportWriter salesReportWriter;

    public SalesReportGenerator(ISalesDataReader salesDataReader, ISalesAnalyzer salesAnalyzer,
        ISalesReporter salesReporter, ISalesReportWriter salesReportWriter)
    {
        this.salesDataReader = salesDataReader;
        this.salesAnalyzer = salesAnalyzer;
        this.salesReporter = salesReporter;
        this.salesReportWriter = salesReportWriter;
    }
    public void Generate(string inputPath, string outputPath)
    {
        var lines = salesDataReader.Read();

        var totals = salesAnalyzer.Analyze(lines);
        
        var report = salesReporter.GenerateReport(totals);
        
        salesReportWriter.Write(report);
    }
}
