using System;
namespace FrontToBack.DataAccessLayer.Entities
{
	public class ProductCategory
	{
		public int CategoryId { get; set; }

		public int ProductId { get; set; }

		public int Id { get; set; }

		public Category Category { get; set; }

		public Product Product { get; set; }
	}
}

