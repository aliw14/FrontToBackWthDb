using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FrontToBack.Models;
using FrontToBack.DataAccessLayer;
using FrontToBack.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _dbcontext;


    public HomeController(AppDbContext appDbContext)
    {
        _dbcontext = appDbContext;
    }

    public IActionResult Index()
    {
        var sliderImage = _dbcontext.SliderImages.FirstOrDefault();

        var product = _dbcontext.Products.Include(p=>p.ProductCategories).ToList();

        var categories = _dbcontext.Categories.ToList();

        var viewModel = new HomeViewModel
        {
            sliderImage = sliderImage,
            Products=product,
            Categories=categories
        };

        return View(viewModel);
    }

}

