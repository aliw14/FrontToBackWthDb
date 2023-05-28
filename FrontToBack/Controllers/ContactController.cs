using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DataAccessLayer;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
public class ContactController : Controller
{
    private readonly AppDbContext _dbcontext;


    public ContactController(AppDbContext appDbContext)
    {
        _dbcontext = appDbContext;
    }

    public IActionResult Index()
    {
        var kontakt = _dbcontext.Kontakts.ToList();

        var viewModel = new ContactViewModel
        {
            Contact=kontakt
        };

        return View(viewModel);
    }

}
