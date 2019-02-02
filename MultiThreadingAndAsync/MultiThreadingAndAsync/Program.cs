using System;
using System.Threading;

namespace MultiThreadingAndAsync
{

	public interface IObjective
	{
		void ObjectiveMain();
	};

	class Program
	{
		static void Main(string[] args)
		{
			// Create the array of objectives
			var objectives = new IObjective[]
			{
				new ObjectiveOneOne(),
				new ObjectiveOneTwo(),
				new ObjectiveOneThree(),
				new ObjectiveOneFour(), 
				new ObjectiveOneFive(), 
			};

			// Execute every objective and require keypress to continue
			int i = 0;
			foreach (var objective in objectives)
			{
				i++;
				objective.ObjectiveMain();
				// Require keypress to continue if not final objective
				if (i < objectives.Length)
				{
					Console.WriteLine("Press any key to continue to next objective...");
					Console.ReadKey();
				}
			}
		}
	}
}
