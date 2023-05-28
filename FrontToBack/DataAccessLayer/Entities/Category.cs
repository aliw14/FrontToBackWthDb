using System;
namespace FrontToBack.DataAccessLayer.Entities
{
	public class Category
	{
		public string ImageUrl { get; set; }

		public int Id { get; set; }

		public string Name { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

    }
}

