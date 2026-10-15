namespace Observer.OOP_Way;

public interface IDownloadSubscriber
{
    public void ReportDownloadState(int percentage);
}