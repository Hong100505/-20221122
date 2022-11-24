using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Map.ViewModels
{
	public class KofVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "類型必填")]
		public string KindOfFun { get; set; }
	}

	public class KofindexVM
	{
		//public int Id { get; set; }
		
		public string KindOfFun { get; set; }
	}
}
