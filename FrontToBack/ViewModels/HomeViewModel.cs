using System;
using FrontToBack.DataAccessLayer.Entities;

namespace FrontToBack.ViewModels
{
	public class HomeViewModel
	{
		public SliderImage sliderImage { get; set; }

		public List<Product> ?Products { get; set; }

		public List<Category> ?Categories { get; set; }
	}
}

