using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DataAccessLayer;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontToBack.Controllers;

public class ShopController : Controller
{
    private readonly AppDbContext _dbcontext;


    public ShopController(AppDbContext appDbContext)
    {
        _dbcontext = appDbContext;
    }

    public IActionResult Index()
    {
        var product = _dbcontext.Products.Include(p => p.ProductCategories).ToList();


        var viewModel = new ShopViewModel
        {
            Products = product,
        };

        return View(viewModel);
    }

}


