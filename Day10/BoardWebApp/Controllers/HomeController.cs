using BoardWebApp.Data;
using BoardWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.WebRequestMethods;

namespace BoardWebApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        // 이게 있어야 DB연결
        private readonly ApplicationDbContext _context;

		public HomeController(ApplicationDbContext context)
		{
			_context = context;
		}

		//public HomeController(ILogger<HomeController> logger)
		//{
		//    _logger = logger;
		//}

		public IActionResult Index()
        {
            // DB에서 데이터 로드
            // TOP위치에 넣을 데이터
            var query = @"SELECT TOP 1 *
                            FROM profiles 
                           WHERE Division = 'TOP' 
                        ORDER BY Id DESC";
			Profile top = _context.profiles.FromSqlRaw(query).FirstOrDefault();
            if (top == null)
            {
                top = new Profile // DB에 데이터가 없으 때 가짜 데이터
                {
                    Title = "공사중",
                    Division = "TOP",
                    Description = string.Empty,
                    Url = string.Empty,
                    FileName = "https://placeimg.com/900/400/any"
                };
            }

            // Card1영역
            query = @"SELECT TOP 1 *
                        FROM profiles 
                       WHERE Division = 'Card1' 
                    ORDER BY Id DESC";
            Profile card1 = _context.profiles.FromSqlRaw(query).FirstOrDefault();
            if (card1 == null)
            {
                card1 = new Profile // DB에 데이터가 없으 때 가짜 데이터
                {
                    Title = "Card1 영역",
                    Division= "Card1",
                    Description = "Card1 영역입니다.",
                    Url = string.Empty,
                    FileName = "https://placeimg.com/900/400/any"
				};
            }

			// Card2영역
			query = @"SELECT TOP 1 *
                        FROM profiles 
                       WHERE Division = 'Card2' 
                    ORDER BY Id DESC";
			Profile card2 = _context.profiles.FromSqlRaw(query).FirstOrDefault();
			if (card2 == null)
			{
				card2 = new Profile // DB에 데이터가 없으 때 가짜 데이터
				{
					Title = "Card2 영역",
					Division = "Card2",
					Description = "Card2 영역입니다.",
					Url = string.Empty,
					FileName = "https://placeimg.com/900/400/any"
				};
			}
			// Card3영역
			query = @"SELECT TOP 1 *
                        FROM profiles 
                       WHERE Division = 'Card3' 
                    ORDER BY Id DESC";
			Profile card3 = _context.profiles.FromSqlRaw(query).FirstOrDefault();
			if (card3 == null)
			{
				card3 = new Profile // DB에 데이터가 없으 때 가짜 데이터
				{
					Title = "Card3 영역",
					Division = "Card3",
					Description = "Card3 영역입니다.",
					Url = string.Empty,
					FileName = "https://placeimg.com/900/400/any"
				};
			}

			List<Profile> list = new List<Profile> { top, card1, card2, card3 };

			return View(list);
        }

        [HttpGet]
        public IActionResult About()
        {
			// Card1영역
			var query = @"SELECT TOP 1 *
                        FROM profiles 
                       WHERE Division = 'Card1' 
                    ORDER BY Id DESC";
			Profile card1 = _context.profiles.FromSqlRaw(query).FirstOrDefault();
			if (card1 == null)
			{
				card1 = new Profile // DB에 데이터가 없으 때 가짜 데이터
				{
					Title = "Card1 영역",
					Division = "Card1",
					Description = "Card1 영역입니다.",
					Url = string.Empty,
					FileName = string.Empty
				};
			}

			// Card2영역
			query = @"SELECT TOP 1 *
                        FROM profiles 
                       WHERE Division = 'Card2' 
                    ORDER BY Id DESC";
			Profile card2 = _context.profiles.FromSqlRaw(query).FirstOrDefault();
			if (card2 == null)
			{
				card2 = new Profile // DB에 데이터가 없으 때 가짜 데이터
				{
					Title = "Card2 영역",
					Division = "Card2",
					Description = "Card2 영역입니다.",
					Url = string.Empty,
					FileName = string.Empty
				};
			}
			// Card3영역
			query = @"SELECT TOP 1 *
                        FROM profiles 
                       WHERE Division = 'Card3' 
                    ORDER BY Id DESC";
			Profile card3 = _context.profiles.FromSqlRaw(query).FirstOrDefault();
			if (card3 == null)
			{
				card3 = new Profile // DB에 데이터가 없으 때 가짜 데이터
				{
					Title = "Card3 영역",
					Division = "Card3",
					Description = "Card3 영역입니다.",
					Url = string.Empty,
					FileName = string.Empty
				};
			}

			List<Profile> list = new List<Profile> { card1, card2, card3 };

			return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}