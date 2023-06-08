using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers;

public class PageController : Controller
{
    //Page controller has created this area. 

    public ViewResult Detail(int id)
    //This action has name of "id" parameters. Parameters type is "int."
    {
        return View();
    }

   
}




