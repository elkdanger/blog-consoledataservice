using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Services;

namespace ConsoleDataService
{
	public class Person
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}

	public class ExampleDataContext
	{
		public IQueryable<Person> People
		{
			get
			{
				return new List<Person>()
				{
					new Person() { ID = 1, Name = "Steve"},
					new Person() { ID = 2, Name = "Dave"}
				}.AsQueryable();
			}
		}		
	}

	public class PersonDataService : DataService<ExampleDataContext>
	{
		public static void InitializeService(DataServiceConfiguration config)
		{
			config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
		}
	}
}
