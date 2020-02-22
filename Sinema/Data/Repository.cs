using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinema.Models
{
	public static class Repository
	{
		private static List<Movie> _movies = null;

		static Repository()
		{
			_movies = new List<Movie>()
			{
				new Movie()
				{
					Id =1,
					Name ="Shazam" ,
					Description ="<p> Shazam izlenmesi gereken yapımdır </p>",
					ShortDescription ="Shazam",
					ImageUrl ="shazam.jpg",
					CategoryId = 1
				},
				new Movie()
				{
					Id =2,
					Name ="Amazing Grace" ,
					Description = "<p> Amazing Grace 196 ödüllüdür </p>",
					ShortDescription ="Amazing Grace",
					ImageUrl ="amazinggrace.jpg",
					CategoryId = 2

				},
				new Movie()
				{
					Id =3,
					Name ="High Life" ,
					Description="<p> Amazing Grace 196 ödüllüdür </p>",
					ShortDescription ="High Life",
					ImageUrl ="highlife.jpg",
					CategoryId = 2
				},
				new Movie()
				{
					Id =4,
					Name ="BillBoard" ,
					Description="<p> Amazing Grace 196 ödüllüdür </p>",
					ShortDescription ="BillBoard",
					ImageUrl ="billboard.jpg",
					CategoryId = 3
				},
				new Movie()
				{
					Id =5,
					Name ="Storm Boy" ,
					Description="<p> Amazing Grace 196 ödüllüdür </p>",
					ShortDescription ="Storm Boy",
					ImageUrl ="stormboy.jpg",
					CategoryId = 3
				},


			};
		}

		public static List<Movie> Movies
		{
			get
			{
				return _movies;
			}
		}
		public static void AddMovie(Movie entity)
		{
			
			 _movies.Add(entity);
		}
		public static Movie GetById(int id)
		{
			return _movies.FirstOrDefault(x => x.Id==id);
		}
	}
}
