using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetMvcBlog.Models;

namespace AspNetMvcBlog.Controllers;

public class HomeController : Controller
{
    //HomeController has created this area. 
    public IActionResult Index()
    {
        return View();
    }
}




