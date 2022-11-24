using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Map.ViewModels
{
	public class CitynameVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "城市必填")]
		public string Cityname { get; set; }
	}

	public class CitynameIndexVM
	{
		


		public string Cityname { get; set; }
	}
}
