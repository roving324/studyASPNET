<img src="https://camo.githubusercontent.com/0c391b5545096b63cac7def5d0f2eb5c4c43260323d456c2689cc841d2bbdf09/68747470733a2f2f63617073756c652d72656e6465722e76657263656c2e6170702f6170693f747970653d776176696e67266865696768743d32303026746578743d576176696e672126666f6e74416c69676e3d383026666f6e74416c69676e593d343026636f6c6f723d6772616469656e74" alt="ASPNET" data-canonical-src="https://capsule-render.vercel.app/api?type=ASPNET&amp;height=200&amp;text=ASPNET!&amp;fontAlign=80&amp;fontAlignY=40&amp;color=gradient" style="max-width: 100%;">

# studyASPNET
ASP.NET Core 학습 리포지토리
- 개발 Tool <br/>
<img alt="Html" src ="https://img.shields.io/badge/HTML-E34F26.svg?&style=for-the-badge&logo=HTML5&logoColor=white"/> <img alt="Css" src ="https://img.shields.io/badge/CSS3-1572B6.svg?&style=for-the-badge&logo=CSS3&logoColor=white"/> <img alt="JavaScript" src ="https://img.shields.io/badge/JavaScriipt-F7DF1E.svg?&style=for-the-badge&logo=JavaScript&logoColor=olive"/> <img alt="VisualStudio" src ="https://img.shields.io/badge/VisualStudio-5C2D91.svg?&style=for-the-badge&logo=VisualStudio&logoColor=Magenta "/> <img alt="Microsoft SQL Server" src ="https://img.shields.io/badge/Microsoft SQL Server-CC2927.svg?&style=for-the-badge&logo=Microsoft SQL Server&logoColor=sirver"/> <img alt="Bootstrap" src ="https://img.shields.io/badge/Bootstrap-7952B3.svg?&style=for-the-badge&logo=Bootstrap&logoColor=violet"/>

## 1일차
1. Git/Github Desktop 설정
2. Visual Studio(IDE) 개발환경 설정
3. 웹 기반기술
   - HTML 5, CSS 3, javascript (ECMAScript 6) 전체개요
  
## 2일차
1. 웹 기반기술
   - HTML 기본태그
   - CSS 전반 학습
   
## 3일차
1. 웹 기반기술
   - 반응형 웹 (Responsive Web)
   - Javascript 문법
   - Dom (Document Object Model)
   - [jQuery](https://code.jquery.com)
   
## 4일차
1. 웹 기반기술 총 복습
   - 핀터레스트 스타일 프론트엔드 연습
   - [랜덤이미지추가](https://placeimg.com/)
   - [소스](https://github.com/roving324/studyASPNET/tree/main/Day04/FrontEndExec/Pages)
   
- 메인컨텐트 사이즈별 반응형 웹
```
#main-section {
    width: 920px;
    margin: 0 auto;
}

/* 세줄 */
@media (max-width: 919px) {
    #main-section {
      width: 690px
    }
}

/* 네줄 */
@media (min-width: 920px) and (max-width: 1149px) {
    #main-section {
      width: 920px
    }
}
```
2. 결과화면

![메인화면](https://github.com/roving324/studyASPNET/blob/main/Images/html_screen01.png)
메인화면

![라이트박스화면](https://github.com/roving324/studyASPNET/blob/main/Images/html_screen02.png)
라이트박스화면<br/>


## 5일차
1. ASP.NET Core
   - 기본개요
   - 기본프로젝트
   - 게시판 만들기 프로젝트 생성
   - NuGet 패키지 설치
     - Microsoft.EntityFrameworkCore
     - Microsoft.EntityFrameworkCore.SqlServer
     - Microsoft.EntityFrameworkCore.Tools
     - Microsoft.VisualStudio.Web.CodeGeneration.Design
   
## 6일차
1. ASP.NET Core
   - 게시판 만들기 시작
   - 게시판 리스트
   - 게시판 글 생성
   - [trumbowyg](https://getbootstrap.com)
   
## 7일차
1. ASP.NET Core
   - 게시판 추가기능
   - 페이징 기능
   - 게시판 완성
   - 회원가입 진행 중
   - [Toastr](https://github.com/CodeSeven/toastr)
   
2. 결과화면
![게시판페이징화면](https://github.com/roving324/studyASPNET/blob/main/Images/Index.PNG)
게시판페이징화면

## 8일차
1. ASP.NET Core
   - 회원가입 완료
   - 계정관리(회원가입,로그인)
   - 세션관리
   - [Freebootstrap](https://startbootstrap.com/themes)
   - [velog](https://velog.io/)
  
-오류발생시 출력
```
foreach (var error in result.Errors)
{
	ModelState.AddModelError(string.Empty, error.Description);
}  
```

- 패스워드 정책 변경 설정
```
builder.Services.Configure<IdentityOptions>(
    opt =>
    {
        opt.Password.RequiredLength = 4;             // 최소 번호 개수
        opt.Password.RequireNonAlphanumeric = false; // 특수문자
        opt.Password.RequireDigit = false;           // 영문자
        opt.Password.RequireLowercase = false;       // 소문자
        opt.Password.RequireUppercase = false;       // 대문자
    }
);
```
2. 결과화면

![템플릿적용화면](https://github.com/roving324/studyASPNET/blob/main/Images/template.PNG)
템플릿적용화면

![회원가입화면](https://github.com/roving324/studyASPNET/blob/main/Images/register.png)<br/>
회원가입화면



## 9일차
1. ASP.NET Core
   - Bootstrap 템플릿 적용 1차 완료
   - 로그인 계정으로 글쓰기
   - 메인페이지 DB연동
   - [stackoverflow](https://stackoverflow.com/)
   
2. 개발화면
![메인페이지](https://github.com/roving324/studyASPNET/blob/main/Images/Day09.PNG)
메인페이지 DB연동

## 10일차
1. ASP.NET Core
   - 메인페이지 DB연동(관리자) 완료
   - 권한관리
   ```
   builder.Services.AddAuthorization(options =>
   {
       options.AddPolicy("AdminRolePolicy", policy => policy.RequireRole("Admin"));
   });
   
   builder.Services.AddAuthorization(options =>
   {
       options.AddPolicy("EditRolePolicy", policy => policy.RequireRole("Edit Role"));
       options.AddPolicy("DeleteRolePolicy", policy => policy.RequireRole("Delete Role"));
   });
   ```
   - 마무리
   - 최종소스
   
2. 개발화면

![권한관리화면](https://github.com/roving324/studyASPNET/blob/main/Images/Roles.PNG)
권한관리화면

![메인관리화면](https://github.com/roving324/studyASPNET/blob/main/Images/Profile.PNG)
메인관리화면

