using System;
using System.Diagnostics; // use Stopwatch
using System.Threading;

class TimeTracker
{
	public static void Main()
	{
		SetTimer();
		Console.WriteLine("Terminating the application");
	}
	static void SetTimer()
	{
		Stopwatch stopW = new Stopwatch();
		stopW.Start();
		Thread.Sleep(1000);
		stopW.Stop();
		TimeSpan tspan = stopW.Elapsed;
		string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00} ", 		tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
		Console.WriteLine(" RunTime " + elapsedTime);
	}
}
