using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			AddressModel address = new AddressModel("123 Some Street", "Scranton", "PA", "12345-6789");

			Console.WriteLine(address.FullAddress);

			_ = Console.ReadLine();
		}
	}
}
