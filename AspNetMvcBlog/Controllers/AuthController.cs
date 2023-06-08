using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers;

public class AuthController : Controller
{
    //Auth controller has created this area.

    public ViewResult Register()
    {
        return View();
    }
    public ViewResult Login(string redirectUrl)
    //This method has took redirectUrl parameters. its type is "String"
    {
        return View();
    }
    public ViewResult ForgetPassword()
    {
        return View();
    }

}




