using BoardWebApp.Data;
using BoardWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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
                    Description = string.Empty,
                    Url = string.Empty,
                    FileName = string.Empty
                };
            }
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
                    Description = "Card1 영역입니다.",
                    Url = string.Empty,
                    FileName = string.Empty
                };
            }

            List<Profile> list = new List<Profile>();
            list.Add(top);
            list.Add(card1);

            return View(top);
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