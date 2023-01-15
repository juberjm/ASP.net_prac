using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using zbrStore.Models;

namespace zbrStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult Login()
    {
        return View();
    }




    public IActionResult validate(string email, string password)
    {
        if(email=="zbrstore@gmail.com" && password=="zbr"){
            return Redirect("/Home/welcome");
        }
        return View();
    }

     public IActionResult welcome()
    {
        return View();
    }

     public IActionResult Register()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
