using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend
{
	class EntryPoint
	{
		/**
		 * Basic entry point for application.
		 */
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello world! Please type something: ");
			var text = Console.ReadLine();
			Console.WriteLine("Your input was \"" + text + "\". Press enter or something to continue.");
			Console.ReadKey();
		}
	}
}
