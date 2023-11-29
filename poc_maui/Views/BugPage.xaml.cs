using System.Diagnostics;

namespace poc_maui.Views;

public partial class BugPage : ContentPage
{
    private Timer timer;
    private DateTime startTime;
    private TimeSpan elapsedTime;

    public BugPage()
	{
		InitializeComponent();
        InitializeTimer();

        this.Loaded += BugPage_Loaded;	
	}

    private void InitializeTimer()
    {
        var timer = Dispatcher.CreateTimer(); // Timer interval in milliseconds
        timer.Tick += Timer_Tick;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        elapsedTime = DateTime.Now - startTime;
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Timer.Text = elapsedTime.ToString(@"hh:mm:ss");
        });
    }

    private void BugPage_Loaded(object sender, EventArgs e)
    {
        //Stopwatch stopwatch = new Stopwatch();
        //Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        //{
        //    Timer.Text = $"{stopwatch.Elapsed.Hours.ToString()}:{stopwatch.Elapsed.Minutes.ToString()}:{stopwatch.Elapsed.Seconds.ToString()}";
        //    return true;
        //});

        startTime = DateTime.Now - elapsedTime;
        Dispatcher.StartTimer(elapsedTime, null);
    }
}
