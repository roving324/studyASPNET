﻿using BoardWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BoardWebApp.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<IdentityUser> userManager;
		private readonly SignInManager<IdentityUser> signInManager;

		public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
		{
			this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
			this.signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
		}

		// 회원가입 첫 화면 들어갈 때 액션(메서드)
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

        // 회원가입 버튼 누른 후 DB처리 액션(메서드)
		// async 비동기식
        [HttpPost]
        public IActionResult Register(RegisterModel model)
		{
			if(ModelState.IsValid) // 입력값이 필수라고 한게 하나라도 입력안되면 false
			{
				// ASP.NET Identity만든 유저로 생성
				var user = new IdentityUser
				{
					Id = model.Id,
					UserName = model.UserName,
					Email = model.Email,
					PhoneNumber = model.PhoneNumber,

				};
			}
            return View(model);
        }
    }
}
