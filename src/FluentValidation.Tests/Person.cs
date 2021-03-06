#region License
// Copyright 2008-2009 Jeremy Skinner (http://www.jeremyskinner.co.uk)
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
// 
// http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
// 
// The latest version of this file can be found at http://www.codeplex.com/FluentValidation
#endregion

namespace FluentValidation.Tests {
	using System;
	using System.Collections.Generic;
	using Attributes;

    [Validator(typeof(TestValidator))]
	public class Person {
    	public string NameField;
    	public int Id { get; set; }
		public string Surname { get; set; }
		public string Forename { get; set; }

		public List<Person> Children { get; set; }

		public DateTime DateOfBirth { get; set; }

		public int? NullableInt { get; set; }

		public Person() {
			Children = new List<Person>();
			Orders = new List<Order>();
		}

		public int CalculateSalary() {
			return 20;
		}

    	public Address Address { get; set; }
		public IList<Order> Orders { get; set; }

    	public string Email { get; set; }
		public decimal Discount { get; set; }
	}


	public class Address {
		public string Line1 { get; set; }
		public string Line2 { get; set; }
		public string Town { get; set; }
		public string County { get; set; }
		public string Postcode { get; set; }
		public Country Country { get; set; }
	}

	public class Country {
		public string Name { get; set; }
	}

	public class Order {
		public string ProductName { get; set; }
		public decimal Amount { get; set; }
	}

}