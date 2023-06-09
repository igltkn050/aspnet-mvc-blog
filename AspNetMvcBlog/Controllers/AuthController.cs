using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers;

public class AuthController : Controller
{
    //Auth controller has created this area.

    public IActionResult Register()
    {
        return View();
    }
    public IActionResult Login(string redirectUrl)
    //This method has took redirectUrl parameters. its type is "String"
    {
        return View();
    }
    public IActionResult ForgetPassword()
    {
        return View();
    }

}




