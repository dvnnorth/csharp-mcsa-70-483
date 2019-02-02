using System;
using System.Threading;

namespace MultiThreadingAndAsync
{
	// Creating a thread with the Thread class
	class ObjectiveOneOne : IObjective
	{

		public ObjectiveOneOne()
		{
		
		}

		public void ThreadMethod()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Objective 1.1: Thread Proc {0}", i);
				Thread.Sleep(200);
			}
		}

		public void ObjectiveMain()
		{
			Thread t = new Thread(new ThreadStart(ThreadMethod));
			t.Start();
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Objective 1.1: Main Thread: Doing Some Work");
				Thread.Sleep(0);
			}

			t.Join();
			Console.WriteLine("Objective 1.1: After Join");
		}
	}
}
