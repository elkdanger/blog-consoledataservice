using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Services;

namespace ConsoleDataService
{
	public class Program
	{

		public static void Main()
		{
			DataServiceHost host = new DataServiceHost(typeof(PersonDataService), new Uri [] { new Uri("http://localhost:999")});

			try
			{
				host.Open();

				Console.WriteLine("Host is running; press a key to stop");
				Console.ReadKey();

				host.Close();
			}
			catch (Exception)
			{
				host.Abort();
				throw;
			}

		}

	}
}
