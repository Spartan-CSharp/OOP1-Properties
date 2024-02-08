using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			AddressModel address = new AddressModel("123 Some Street", "Scranton", "PA", "12345-6789");

			Console.WriteLine(address.FullAddress);

			_ = Console.ReadLine();
		}
	}
}
