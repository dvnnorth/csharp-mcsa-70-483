using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace MultiThreadingAndAsync
{

	// Using the ThreadStatic attribute
	// Threads have their own call stack and scope
	class ObjectiveOneFive : IObjective
	{
		[ThreadStatic]
		public static int _field = 0; // Can't access non-static fields in static
                                  // methods

		public void ObjectiveMain()
		{
			var t1 = new Thread(new ThreadStart(() =>
			{
				for (var i = 0; i < 10; i++)
				{
					_field++;
					Console.WriteLine("Objective 1.5: Thread A: {0}", _field);
				}
			}));
			t1.Start();

			var t2 = new Thread(new ThreadStart(() =>
			{
				for (var i = 0; i < 10; i++)
				{
					_field++;
					Console.WriteLine("Objective 1.5: Thread B: {0}", _field);
				}
			}));
			t2.Start();
		}
		/*
		 * Each thread, t1 and t2, has their own _field because of the [ThreadStatic]
		 * attribute. Without that attribute (comment it out to check), then _field
		 * increments all the way to 20 because both threads are incrementing it.
		 * With the [ThreadStatic] attribute, each thread gets their own _field.
		 */
	}
}
