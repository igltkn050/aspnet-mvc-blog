using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.ViewComponents
{
	public class FooterViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
		var _database = new DatabaseContent();
		var _catagories = _database._Catagories;

			return View(_catagories);
		}
	}
}
