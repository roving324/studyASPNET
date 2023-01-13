using BoardWebApp.Data;
using BoardWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Permissions;

namespace BoardWebApp.Controllers
{
	public class ProfileController : Controller
	{
		private readonly ApplicationDbContext _context;
		// 파일 업로드 웹환경
		private readonly IWebHostEnvironment _environment;


		public ProfileController(ApplicationDbContext context, IWebHostEnvironment environment)
		{
			_context = context;
			_environment = environment;
		}

		public IActionResult Index()
		{
			var list = _context.profiles.ToList();
			return View(list);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(TempProfile temp)
		{
			if (ModelState.IsValid)
			{
				// 파일 업로드
				string upFileName = UploadImageFile(temp);

				// 파일명을 받아서 TmepProfile의 내용을 profile로 이전
				Profile profile = new Profile
				{
					Title = temp.Title,
					Description = temp.Description,
					Division = temp.Division,
					Url = temp.Url,
					FileName = upFileName
				};

				_context.profiles.Add(profile);
				_context.SaveChanges();

				TempData["success"] = "프로필 저장완료!";

				return RedirectToAction("Index", "Profile");
			}
			return View();
		}

		[HttpGet]
		public IActionResult Edit(int? id)
		{
			if (id is null) return NotFound();
			var profile = _context.profiles.Find(id);
			if (profile == null) return NotFound();

			// 이미지 때문에 추가작업
			TempProfile temp = new TempProfile
			{
				Id = profile.Id,
				Title = profile.Title,
				Description = profile.Description,
				Division = profile.Division,
				Url = profile.Url,
				FileName = profile.FileName,
			};

			return View(temp);
		}

		[HttpPost]
		public IActionResult Edit(TempProfile temp)
		{
			if (ModelState.IsValid)
			{
				// 파일 업로드
				string upFileName = UploadImageFile(temp);

				// 새로 업로드된 파일이 없고, 이전 파일명이 있으면
				// 그 파일명을 그대로 사용!!
				if(upFileName == string.Empty && temp.FileName != string.Empty) upFileName = temp.FileName;

				// 파일명 받아서 TempProfile -> profile
				Profile profile = new Profile
				{
					Id = temp.Id,
					Title = temp.Title,
					Description = temp.Description,
					Division = temp.Division,
					Url = temp.Url,
					FileName = upFileName
				};

				_context.profiles.Update(profile);
				_context.SaveChanges();

				TempData["success"] = "프로필 수정완료";
				return RedirectToAction("Index", "Profile");
			}
			return View(temp);
		}

		[HttpGet]
		public IActionResult Delete(int? id)
		{
			if(id is null) return NotFound();
			var profile = _context.profiles.Find(id);
			if(profile == null) return NotFound();

			_context.profiles.Remove(profile);
			_context.SaveChanges();

			TempData["success"] = "프로필 삭제 완료";
			return RedirectToAction("Index", "Profile");
		}

		#region `업로드메서드 - Routing에 관련없음`
		/// <summary>
		/// 파일 업로드
		/// </summary>
		/// <param name="temp"></param>
		/// <returns></returns>
		private string UploadImageFile(TempProfile temp)
		{
			var resultFileName = string.Empty;

			if (temp.ProFileImage != null)
			{
				string uploadFolder = Path.Combine(_environment.WebRootPath, "Uploads");
				resultFileName = Guid.NewGuid() + "_" + temp.ProFileImage.FileName; // Guid.NewGuid() 임의 넘버(글+숫자)
				string filePath = Path.Combine(uploadFolder, resultFileName); //Path: 경로

				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					temp.ProFileImage.CopyTo(fileStream);
				}
			}
			return resultFileName;
		}

		#endregion
	}
}