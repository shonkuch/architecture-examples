using DIP.Exercise.Starter;

namespace DIP.Exercise;

public static class SalesReportExercise
{
    public static void Run()
    {
        Console.WriteLine("SALES REPORT EXERCISE: separate workflow, business rules, and file handling");
        var inputPath = Path.Combine(AppContext.BaseDirectory, "Exercise", "Data", "sales.csv");
        var outputPath = Path.Combine(AppContext.BaseDirectory, "sales-report.txt");
        
        var reader = new SalesDataReader(inputPath);
        var analyzer = 
        
        var writer = new SalesReportWriter(outputPath);
        
        new SalesReportGenerator().Generate(inputPath, outputPath);

        Console.WriteLine(File.ReadAllText(outputPath));
        Console.WriteLine($"Report saved to: {outputPath}");
    }
}
