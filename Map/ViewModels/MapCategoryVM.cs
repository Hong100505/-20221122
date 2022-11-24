using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.ViewModels
{
	internal class MapCategoryVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string KindOfFun { get; set; }
	}

	internal class MapCityVM
	{
		public int Id { get; set; }
		public string Cityname { get; set; }
		
	}
	internal class MapKOFVM
	{
		public int Id { get; set; }
		public string KindOfFun { get; set; }

	}

}
