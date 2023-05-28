using System;
using FrontToBack.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.DataAccessLayer
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<SliderImage> SliderImages { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<ProductCategory> ProductCategories { get; set; }

		public DbSet<Kontakt> Kontakts { get; set; }

	}
}

