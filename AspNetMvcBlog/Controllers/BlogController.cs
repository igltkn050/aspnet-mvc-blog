using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
    public class BlogController : Controller
    {
        DatabaseContent database = new DatabaseContent();
        //Blog controller has created this area. 
        public IActionResult Index(int? id, string search) 
        {
            var _blogs = database._Blogs.ToList();
            if (id.HasValue)
            {
                _blogs = database._Blogs.Where(x=>x.Id == id).ToList();
            }
            if(search != null)
            {
                _blogs = database._Blogs.Where(p=>p.Title.ToLower().Contains(search.ToLower())).ToList();
            }
        return View(_blogs);
        }
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
