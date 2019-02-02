using System;
using System.Threading;

namespace MultiThreadingAndAsync
{

	// Using a background thread
	class ObjectiveOneTwo : IObjective
	{
		public static void ThreadMethod()
		{ 
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Objective 1.2: Thread Proc {0}", i);
				Thread.Sleep(200);
			}
		}

		public void ObjectiveMain()
		{
			Thread t = new Thread(new ThreadStart(ThreadMethod));
			// IsBackground = true; Main thread finishes before it can execute,
			// program closes before this method executes
			// IsBackground = false; Main thread has to wait for this thread to finish
			t.IsBackground = false ;
			t.Start();
			t.Join(); // t.Join() with IsBackground = true still joins the threads and
			// forces the main thread to wait until this thread completes
		}
	}
}
