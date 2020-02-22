using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sinema.Models;

namespace Sinema.Controllers
{
	public class HomeController : Controller
	{
		//Home//Index//3
		public IActionResult Index(int? id)
		{
			var movies = Repository.Movies;
			if (id!= null)
			{
				movies = movies.Where(x => x.CategoryId == id).ToList();

			}
			//Repository.Movies
			//Category.Categories

			//ProductCategoryModel model = new ProductCategoryModel();
			//model.Categories = CategoryRepository.Categories;
			//model.Movies = Repository.Movies;

			return View(movies);
		}

		public IActionResult Details(int id)
		{
			//ProductCategoryModel model = new ProductCategoryModel();
			//model.Categories = CategoryRepository.Categories;
			//model.Movie = Repository.GetById(id);


			return View(Repository.GetById(id));
		}





		//public IActionResult About()
		//{
		//	ViewData["Message"] = "Your application description page.";

		//	return View();
		//}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		//public IActionResult Privacy()
		//{
		//	return View();
		//}

		//[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		//public IActionResult Error()
		//{
		//	return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		//}
	}
}
