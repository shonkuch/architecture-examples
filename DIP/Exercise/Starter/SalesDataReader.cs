namespace DIP.Exercise.Starter;

public class SalesDataReader : ISalesDataReader
{
    private readonly string inputPath;

    public SalesDataReader(string inputPath)
    {
        this.inputPath = inputPath;
    }

    public string[] Read()
    {
        return File.ReadAllLines(inputPath);
    }
}