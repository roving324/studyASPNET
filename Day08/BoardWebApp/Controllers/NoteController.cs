﻿using BoardWebApp.Data;
using BoardWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.WebRequestMethods;

namespace BoardWebApp.Controllers
{
    public class NoteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NoteController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 기본 리스트 조회화면
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(int page = 1)
        {
            // EntityFramework로 쿼리없이
            //IEnumerable<Note> list = _context.Notes.ToList(); // DB에서 데이터 가져와서...
            //var list = _context.Notes.FromSqlRaw($"SELECT TOP(5) * FROM Notes").ToList();
            int totalCount = _context.Notes.FromSqlRaw($"SELECT * FROM Notes").Count();
            int countNum = 10; // 게시판 한페이지에 뿌릴 글 개수
            int totalpage = totalCount / countNum;
            if (totalCount % countNum > 0) totalpage++; // 페이지 수를 증가
            if (totalpage < page) page = totalpage;

			int startpage = ((page - 1) / countNum) * countNum + 1; // 1
            int endpage = startpage + countNum - 1; // 10
            if(totalpage < endpage) endpage = totalpage;

            int startCount = ((page - 1) * countNum) + 1;//1, 11
			int endCount = startCount + 9; // 10, 20

            

            // 뷰에 마지막 페이지, 이전페이지, 다음페이지 표시
            ViewBag.StartPage = startpage;
            ViewBag.EndPage = endpage;
            ViewBag.Page = page;
            ViewBag.TotalPage = totalpage;

			//ViewBag.EndPage = totalCount;
			//startCount = page; endCount = page;
            var list = _context.Notes.FromSqlRaw($"EXECUTE dbo.USP_PagingNotes @StartCount = {startCount}, @EndCount={endCount}").ToList();


            ViewData["Title"] = "컨트롤러에 온 게시판"; // ViewData는 백엔드 프론트엔 어디든지 쓸수있음
            return View(list);
        }

        /// <summary>
        /// GET 액션(메서드)
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// POST 액션(메서드)
        /// </summary>
        /// <param name="note">프론트엔드에서 작성한 모델</param>
        /// <returns>리스트로 다시 돌아감</returns>
        [HttpPost]
        [ValidateAntiForgeryToken] // 크로스 사이트 요청 위조를 막는 부분
        public IActionResult Create(Note note)
        {
            _context.Notes.Add(note); // INSERT 쿼리 실행
            _context.SaveChanges();   // 트랜잭션 commit

            // 처리메세지 추가
            TempData["success"] = "저장되었습니다.";

            return RedirectToAction("Index", "Note"); // 화면전환
        }

        /// <summary>
        /// Edit 액션
        /// </summary>
        /// <param name="id">수정할 글 아이디</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int? id)
        {
			if (id is null) return NotFound();
            var note = _context.Notes.Find(id);
			if (note == null) return NotFound();
            
            return View(note);
		}

        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Note note)
        {
            _context.Notes.Update(note);
            _context.SaveChanges();

            // 수정메세지 추가
            TempData["success"] = "수정되었습니다.";
            return RedirectToAction("Index", "Note");
		}
        
        [HttpGet]
        public IActionResult Delete(int? id)
        {
			if (id is null) return NotFound();
			var note = _context.Notes.Find(id);
			if (note == null) return NotFound();

           return View(note);
		}

        // Action 이름이 Delete가 아니지만 Delete로 동작하게 해주는 기능 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
			if (id is null) return NotFound();
			var note = _context.Notes.Find(id);
			if (note == null) return NotFound();

			_context.Notes.Remove(note); // EELETE 쿼리
			_context.SaveChanges();

			// 삭제메세지 추가
			TempData["success"] = "삭제되었습니다.";
			return RedirectToAction("Index", "Note");
		}

        /// <summary>
        /// 상세보기
        /// </summary>
        /// <param name="id">게시글 번호</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Detail(int? id)
        {
            if (id is null) return NotFound();

            var note = _context.Notes.Find(id); // SELECT 쿼리
            if (note == null) return NotFound();

            // 조회수 + 1
            note.ReadCount++;
            _context.Notes.Update(note); // UPDATE 쿼리
            _context.SaveChanges();

            return View(note);
        }
    }
}