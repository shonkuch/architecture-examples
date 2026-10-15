using Observer.Exercise;
using Observer.OOP_Way;

var downloader = new Downloader();

ProgressDownloadPrinter progress = new ProgressDownloadPrinter();
CompletionDownloadPrinter completion = new CompletionDownloadPrinter();

// OOP way
//downloader.Subscribe(progress);
//downloader.Subscribe(completion);

// C# way
downloader.downloadProgressUpdated += progress.ReportDownloadState;
downloader.downloadCompleted += completion.ReportDownloadComplete;

downloader.UpdateProgress(10);
downloader.UpdateProgress(50);
downloader.UpdateProgress(50);
// OOP way
//downloader.Unsubscribe(progress);
// C# way
downloader.downloadProgressUpdated -= progress.ReportDownloadState;
downloader.UpdateProgress(100);
