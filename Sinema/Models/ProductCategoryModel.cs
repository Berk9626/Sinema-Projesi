using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinema.Models
{
	public class ProductCategoryModel
	{
		public IEnumerable<Movie> Movies { get; set; }
		public IEnumerable<Category> Categories { get; set; }
		public Movie Movie { get; set; }
	}
}
