namespace Observer.OOP_Way;

public class CompletionDownloadPrinter : IDownloadSubscriber
{
    public void ReportDownloadComplete()
    {
        Console.WriteLine("Download complete");
    }
    
    public void ReportDownloadState(int percentage)
    {
        if (percentage != 100)
        {
            return;
        }

        ReportDownloadComplete();
    }
}