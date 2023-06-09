
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetMvcBlog.Models;

namespace AspNetMvcBlog.Controllers;

public class CatagoryController : Controller
{
	//CatagoryController has created this area. 
	public IActionResult Index(int id, int page)
	{
		return View();
	}
}
