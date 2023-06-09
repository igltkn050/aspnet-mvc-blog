using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class BlogController : Controller
    {
        //Blog controller has created this area. 

        public IActionResult Detail(int id)
        //This action has name of id parameters. Parameters type is "String." 
        {
            return View();
        }

        public IActionResult Search(int page, string query)
        //This action has name of "page" parameters. Parameters type is "int." 
        //This action has name of "query" parameters. Parameters type is "string." 
        {
            return View();
        }

    }
}
