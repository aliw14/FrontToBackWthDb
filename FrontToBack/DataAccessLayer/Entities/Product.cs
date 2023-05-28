using System;
namespace FrontToBack.DataAccessLayer.Entities
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string ImageUrl { get; set; }

		public List<ProductCategory> ProductCategories { get; set; }
	}
}

