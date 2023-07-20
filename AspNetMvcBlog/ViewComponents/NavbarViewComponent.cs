using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace AspNetMvcBlog.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        //Katagöri bilgilerini alcam
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
        var database = new DatabaseContent();
            var _catagories = database._Catagories;
            //View 'a göndercem
            return View(_catagories);
        }
    }
}


