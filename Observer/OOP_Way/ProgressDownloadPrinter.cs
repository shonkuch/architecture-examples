namespace Observer.OOP_Way;

public class ProgressDownloadPrinter : IDownloadSubscriber
{
    public void ReportDownloadState(int percentage)
    {
        Console.WriteLine($"Download progress: {percentage}");
    }
}