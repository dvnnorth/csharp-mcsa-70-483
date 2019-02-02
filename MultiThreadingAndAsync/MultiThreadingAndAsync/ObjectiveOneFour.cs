using System;
using System.Threading;

namespace MultiThreadingAndAsync
{

	// Stopping a thread (and ThreadStart lambdas)
	class ObjectiveOneFour : IObjective
	{
		public void ObjectiveMain()
		{
			bool running = true;
			Console.WriteLine("Press any key to kill this thread loop");
			Thread t = new Thread(new ThreadStart(() =>
			{
				while (running)
				{
					Console.WriteLine("Running Controlled Thread");
					Thread.Sleep(1000);
				}
			}));
			t.Start();
			Console.ReadKey();
			running = false;
			Console.WriteLine("Thread stopped");
			t.Join();
		}
	}
}
