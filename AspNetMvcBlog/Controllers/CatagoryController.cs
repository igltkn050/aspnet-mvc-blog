using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class CatagoryController : Controller
    //Catagory controller has created this area.
    {
        public ViewResult Index(int id, int page)
        //This action has name of "id" parameters. Parameters type is "int." 
        //This action has name of "page" parameters. Parameters type is "int." 
        {
            return View();
        }
    }
}
