using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Map.ViewModels
{
	internal class MapIndex
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string KindOfFun { get; set; }
	}
	public class MapVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "名稱必填")]
		public string Name { get; set; }
		[Required(ErrorMessage = "城市必選")]
		public string City { get; set; }
		[Required(ErrorMessage = "地址必填")]
		public string Address { get; set; }
		[Required(ErrorMessage = "類型必選")]
		public string KindOfFun { get; set; }
	}
}
