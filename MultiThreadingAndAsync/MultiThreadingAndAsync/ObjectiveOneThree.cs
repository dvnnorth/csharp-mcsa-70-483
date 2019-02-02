using System;
using System.Threading;

namespace MultiThreadingAndAsync
{

	// Using the ParameterizedThreadStart
	class ObjectiveOneThree : IObjective
	{
		public void ThreadMethod(object o)
		{
			for (int i = 0; i < (int) o; i++)
			{
				Console.WriteLine("Objective 1.3: Thread Proc {0}", i);
				Thread.Sleep(0);
			}
		}

		public void ObjectiveMain()
		{
			Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
			t.Start(15);
			t.Join();
		}
	}
}
