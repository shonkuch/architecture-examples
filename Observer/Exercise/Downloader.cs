using Observer.OOP_Way;

namespace Observer.Exercise;

// Simulate download progress (0–100); no actual downloading is required.
// Add two subscribers: one prints progress after each change, the other prints
// "Download complete" when progress reaches 100. Repeating a value must not notify.
// Demonstrate updates at 10, 50, and 100, and unsubscribing the progress display
// while keeping the completion notification subscribed.
// Implement two variants: OOP Observer with an interface, and C# delegates/events.
public class Downloader
{
    private int? currentProgress = null;
    // OOP way
    private readonly List<IDownloadSubscriber> subscribers = new List<IDownloadSubscriber>();
    // C# way
    
    // For consistency with OOP better to have 1 action with int signature, but I thought a dedicated event would be cleaner
    public event Action<int> downloadProgressUpdated;
    public event Action downloadCompleted;
    
    public void Subscribe(IDownloadSubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(IDownloadSubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }
    
    public void UpdateProgress(int percentage)
    {
        if (currentProgress == percentage)
        {
            return;
        }

        currentProgress = percentage;
        
        // OOP way
        //foreach (var subscriber in subscribers)
        //{
        //    subscriber.ReportDownloadState(percentage);
        //}
        
        // C# way
        downloadProgressUpdated?.Invoke(percentage);

        if (percentage == 100)
        {
            downloadCompleted?.Invoke();
        }
    }
}
