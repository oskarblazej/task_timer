using System;
using System.Diagnostics; // use Stopwatch
using System.Threading;

class TimeTracker
{
	static void Main()
	{
		
		SetTimer();
		Console.WriteLine("Terminating the application...");

	}
	static void SetTimer()
	{
		string elapsedTime = "Stoper Failed. Try again.";
		Console.WriteLine("Launching timer...");
		Console.WriteLine("Press Any Key to exit.");
		Stopwatch stopW = new Stopwatch();
		while (!Console.KeyAvailable)
		{
			stopW.Start();
			Thread.Sleep(1000);
			TimeSpan tspan = stopW.Elapsed;
			elapsedTime = String.Format("{0:00}:{1:00}:{2:00} ",tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
			Console.Clear(); // Clear the console before writing time to avoid having an empty screen between seconds
			Console.WriteLine(" Task Time: " + elapsedTime);
		}
		Console.WriteLine("Your Task Time was: " + elapsedTime);
	}
}
