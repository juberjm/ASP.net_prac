using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EWebApp.Models;

using BuissObjLayer;
using BuissLogicLayer;

namespace EWebApp.Controllers;

public class productsController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogManager manager = new CatalogManager();
        List<prod> Allproducts = manager.getAllProduct();
        this.viewData["prods"]=Allproducts;
        return view();
    }

    public IActionResult Details(int id)
    {
        CatalogManager manager=new CatalogManager();
        prod product = manager.GetProduct(id);
        this.viewData["prod"]=product;
        return View();
    }

    public IActionResult Insert(){
        return View();
    }

    public IActionResult Delete(int id){
        return RedirectToAction("Index");
    }
}
