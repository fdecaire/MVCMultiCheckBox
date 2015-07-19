using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMultiCheckBox.Models
{
	public class HomeViewModel
	{
		public List<PersonModel> Persons { get; set; }
	}

	public class PersonModel
	{
		public string Name { get; set; }
		public bool Checked { get; set; }
	}
}