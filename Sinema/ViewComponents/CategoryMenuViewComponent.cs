using Microsoft.AspNetCore.Mvc;
using Sinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Sinema.ViewComponent;
using Microsoft.AspNetCore.Routing;

namespace Sinema.ViewComponent
{
	public class CategoryMenuViewComponent //Burası aynı
	{
		//public IViewComponentResult Invoke()
		//{
		//if (RouteData.Values["Action"].ToString() == "Index") ;
		//	ViewBag.SelectedCategory = RouteData?.Values["id"];
		//	return View(CategoryRepository.Categories);
		//}



		//Controller/Action/id?
		//home/index/3
		//RouteData.Values["controller"] ==> controller
		//RouteData.Values["Action"] ==> index
		//RouteData.Values["id"] ==> 3


		private IViewComponentResult ViewComponent(List<Category> categories)
		{
			if (RouteData.Values["action"].ToString() == "Index") 
			ViewBag.SelectedCategory = RouteData?.Values["id"];
			return ViewComponent(CategoryRepository.Categories);
		}

	}
}
